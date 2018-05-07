using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	public static class TaskExtensions
	{
		public static async Task WithCancellation(this Task task, CancellationToken cancellationToken)
		{
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
			using (cancellationToken.Register(delegate(object s)
			{
				((TaskCompletionSource<bool>)s).TrySetResult(true);
			}, taskCompletionSource))
			{
				if (task != await Task.WhenAny(new Task[]
				{
					task,
					taskCompletionSource.Task
				}).ConfigureAwait(false))
				{
					throw new OperationCanceledException(cancellationToken);
				}
			}
			await task.ConfigureAwait(false);
		}
		public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
		{
			Action<object> action = null;
			TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
			if (action == null)
			{
				action = delegate(object s)
				{
					((TaskCompletionSource<bool>)s).TrySetResult(true);
				};
			}
			using (cancellationToken.Register(action, taskCompletionSource))
			{
				if (task != await Task.WhenAny(new Task[]
				{
					task,
					taskCompletionSource.Task
				}).ConfigureAwait(false))
				{
					throw new OperationCanceledException(cancellationToken);
				}
			}
			return await task.ConfigureAwait(false);
		}
	}
}
