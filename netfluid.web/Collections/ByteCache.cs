using Netfluid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Netfluid.Collections
{
	/// <summary>
	/// This is a generic cache subsystem based on key/value pairs, where key is generic, too. Key must be unique.
	/// Every cache entry has its own timeout.
	/// Cache is thread safe and will delete expired entries on its own using System.Threading.Timers (which run on <see cref="ThreadPool"/> threads).
	/// </summary>
	public class ByteCache<K> : IDisposable
	{
        #region Constructor and class members

		private Dictionary<K, byte[]> cache = new Dictionary<K, byte[]>();
		private Dictionary<K, Timer> timers = new Dictionary<K, Timer>();
		private ReaderWriterLockSlim locker = new ReaderWriterLockSlim();

        long memory = 0;
        public long MemoryLimit { get; set; } = 1024 * 1024 * 1024;

        public Func<K,byte[]> Load { get; set; }
        public event Action<K,byte[]> OnRemove;

		#endregion

		#region IDisposable implementation
		private bool disposed = false;

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing">
		///   <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				disposed = true;

				if (disposing)
				{
					// Dispose managed resources.
					locker.EnterWriteLock();
					try
					{
						try { timers.Values.ForEach(t => t.Dispose()); }
						catch
						{ }

						timers.Clear();
						cache.Clear();
					}
					finally { locker.ExitWriteLock(); }

					locker.Dispose();
				}
				// Dispose unmanaged resources
			}
		}
		#endregion

		#region CheckTimer
		// Checks whether a specific timer already exists and adds a new one, if not 
		private void CheckTimer(K key, int cacheTimeout, bool restartTimerIfExists)
		{
			Timer timer;

			if (timers.TryGetValue(key, out timer))
			{
				if (restartTimerIfExists)
				{
					timer.Change(
						(cacheTimeout == Timeout.Infinite ? Timeout.Infinite : cacheTimeout * 1000),
						Timeout.Infinite);
				}
			}
			else
				timers.Add(
					key,
					new Timer(
						new TimerCallback(RemoveByTimer),
						key,
						(cacheTimeout == Timeout.Infinite ? Timeout.Infinite : cacheTimeout * 1000),
						Timeout.Infinite));
		}

		private void RemoveByTimer(object state)
		{
			Remove((K)state);
		}
		#endregion

		#region AddOrUpdate, Get, Remove, Exists 
		/// <summary>
		/// Adds or updates the specified cache-key with the specified cacheObject and applies a specified timeout (in seconds) to this key.
		/// </summary>
		/// <param name="key">The cache-key to add or update.</param>
		/// <param name="cacheObject">The cache object to store.</param>
		/// <param name="cacheTimeout">The cache timeout (lifespan) of this object. Must be 1 or greater.
		/// Specify Timeout.Infinite to keep the entry forever.</param>
		/// <param name="restartTimerIfExists">(Optional). If set to <c>true</c>, the timer for this cacheObject will be reset if the object already
	   /// exists in the cache. (Default = false).</param>
		public void AddOrUpdate(K key, byte[] cacheObject, int cacheTimeout, bool restartTimerIfExists = false)
		{
			if (disposed) return;

			if (cacheTimeout != Timeout.Infinite && cacheTimeout < 1)
                throw new ArgumentOutOfRangeException("cacheTimeout must be greater than zero.");

            if (memory >= MemoryLimit)
                Dump();

			locker.EnterWriteLock();
			try
			{
				CheckTimer(key, cacheTimeout, restartTimerIfExists);

                if (!cache.ContainsKey(key))
                {
                    memory += cacheObject.Length;
                    cache.Add(key,cacheObject);
                }
                else
                {
                    memory -= cache[key].Length;
                    memory += cacheObject.Length;
                    cache[key] = cacheObject;
                }
			}
			finally { locker.ExitWriteLock(); }
		}

        private void Dump()
        {
            locker.EnterWriteLock();

            var arr = cache.Keys.Reverse().ToArray();
            var i = 0;
            while (memory > MemoryLimit)
            {
                Remove(arr[i]);
            }

            locker.ExitWriteLock();
        }

        /// <summary>
        /// Gets the cache entry with the specified key or returns <c>default(byte[])</c> if the key is not found.
        /// </summary>
        /// <param name="key">The cache-key to retrieve.</param>
        /// <returns>The object from the cache or <c>default(byte[])</c>, if not found.</returns>
        public byte[] this[K key] => Get(key);

		/// <summary>
		/// Gets the cache entry with the specified key or return <c>default(byte[])</c> if the key is not found.
		/// </summary>
		/// <param name="key">The cache-key to retrieve.</param>
		/// <returns>The object from the cache or <c>default(byte[])</c>, if not found.</returns>
		public byte[] Get(K key)
		{
			if (disposed) return null;

			locker.EnterReadLock();
            byte[] val=null;

			try
			{
                if (!cache.TryGetValue(key, out val) && Load != null)
                    val = Load(key);
            }
			finally { locker.ExitReadLock(); }
            return val;
		}

		/// <summary>
		/// Tries to gets the cache entry with the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="value">(out) The value, if found, or <c>default(byte[])</c>, if not.</param>
		/// <returns><c>True</c>, if <c>key</c> exists, otherwise <c>false</c>.</returns>
		public bool TryGet(K key, out byte[] value)
		{
			if (disposed)
			{
                value = null;
				return false;
			}

			locker.EnterReadLock();

            bool ret=false;
            try
			{
                ret = cache.TryGetValue(key, out value);
                if (!ret && Load != null)
                {
                    value = Load(key);
                    ret = true;
                }
            }
			finally { locker.ExitReadLock(); }
            return ret;
		}

		/// <summary>
		/// Removes the specified cache entry with the specified key.
		/// If the key is not found, no exception is thrown, the statement is just ignored.
		/// </summary>
		/// <param name="key">The cache-key to remove.</param>
		public void Remove(K key)
		{
			if (disposed) return;

			locker.EnterWriteLock();
			try
			{
                byte[] bytes;
				if (cache.TryGetValue(key,out bytes))
				{
					try { timers[key].Dispose(); }
					catch { }

                    memory -= bytes.Length;
					timers.Remove(key);
					cache.Remove(key);

                    if(OnRemove!=null)
                    {
                        System.Threading.Tasks.Task.Factory.StartNew(()=> 
                        {
                            if (OnRemove != null) OnRemove(key,bytes);
                        });
                    }
				}
			}
			finally { locker.ExitWriteLock(); }
		}

		/// <summary>
		/// Checks if a specified key exists in the cache.
		/// </summary>
		/// <param name="key">The cache-key to check.</param>
		/// <returns><c>True</c> if the key exists in the cache, otherwise <c>False</c>.</returns>
		public bool Exists(K key)
		{
			if (disposed) return false;
            bool ex;

			locker.EnterReadLock();
			try
			{
				ex = cache.ContainsKey(key);
			}
			finally { locker.ExitReadLock(); }
            return ex;
		}
		#endregion
	}
}
