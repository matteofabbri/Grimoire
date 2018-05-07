// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using Netfluid.Sessions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Netfluid
{
    /// <summary>
    /// Virtual host manager
    /// </summary>
    public class NetfluidHost
    {
        HttpListener listener;

        [Json.JsonIgnore]
        public RouteCollection Routes { get; private set; }

        [Json.JsonIgnore]
        public RouteCollection Filters { get; private set; }

        [Json.JsonIgnore]
        public RouteCollection Triggers { get; private set; }

        public List<IPublicFolder> PublicFolders { get; set; }

        [Json.JsonIgnore]
        public ISessionManager Sessions { get; set; }

        [Json.JsonIgnore]
        public Func<Context,Exception,dynamic> OnException;

        [Json.JsonIgnore]
        public Logger Logger { get; set; }

        Task listeningTask;

        static List<NetfluidHost> instances;

        public static IEnumerable<NetfluidHost> Instances
        {
            get
            {
                return instances;
            }
        }

        static NetfluidHost()
        {
            var max = Environment.ProcessorCount * 250;
            var min = Environment.ProcessorCount * 10;
            ThreadPool.SetMinThreads(min, max);
            ThreadPool.SetMaxThreads(max, max);

            ServicePointManager.DefaultConnectionLimit = 65000;
            instances = new List<NetfluidHost>();
        }

        public NetfluidHost()
        {
            listener = new HttpListener();

            lock (instances)
            {
                instances.Add(this);
            }

            OnException = (c, e) => 
            {
                var ex = e;
                var sb = new StringBuilder();

                while (ex!=null)
                {
                    sb.Append(ex.Message + "<br/>" + ex.StackTrace+"<br/>");
                    ex = ex.InnerException;
                }
                return sb.ToString();
            };

            Logger = new Logging.NullLogger();
            Filters = new RouteCollection();
            Triggers = new RouteCollection();
            Routes = new RouteCollection();

            PublicFolders = new List<IPublicFolder>();
            Sessions = new DefaultSessionManager();

            StartTime = DateTime.Now;
        }

        public NetfluidHost(IEnumerable<string> prefixes) : this()
        {
            prefixes.ForEach(x => listener.Prefixes.Add(x));
        }

        public NetfluidHost(params string[] prefixes):this()
        {
            prefixes.ForEach(x => listener.Prefixes.Add(x));
        }

        [Json.JsonIgnore]
        public bool HasRoutes
        {
            get
            {
                return (Filters.Any() || Triggers.Any() || Routes.Any() || PublicFolders.Any());
            }
        }

        public DateTime StartTime { get; private set; }

        public TimeSpan UpTime { get { return DateTime.Now - StartTime; } }

        #region HTTP LISTENER PROPERTIES
        //
        // Summary:
        //     Gets a value that indicates whether System.Net.HttpListener can be used with
        //     the current operating system.
        //
        // Returns:
        //     true if System.Net.HttpListener is supported; otherwise, false.
        public static bool IsSupported { get { return HttpListener.IsSupported; } }
        //
        // Summary:
        //     Gets or sets the scheme used to authenticate clients.
        //
        // Returns:
        //     A bitwise combination of System.Net.AuthenticationSchemes enumeration values
        //     that indicates how clients are to be authenticated. The default value is System.Net.AuthenticationSchemes.Anonymous.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public AuthenticationSchemes AuthenticationSchemes { get { return listener.AuthenticationSchemes;  } set { listener.AuthenticationSchemes = value; } }
        //
        // Summary:
        //     Gets or sets the delegate called to determine the protocol used to authenticate
        //     clients.
        //
        // Returns:
        //     An System.Net.AuthenticationSchemeSelector delegate that invokes the method used
        //     to select an authentication protocol. The default value is null.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate { get { return listener.AuthenticationSchemeSelectorDelegate; } set { listener.AuthenticationSchemeSelectorDelegate = value; } }
        //
        // Summary:
        //     Gets a default list of Service Provider Names (SPNs) as determined by registered
        //     prefixes.
        //
        // Returns:
        //     A System.Security.Authentication.ExtendedProtection.ServiceNameCollection that
        //     contains a list of SPNs.
        public ServiceNameCollection DefaultServiceNames { get { return listener.DefaultServiceNames; } }
        //
        // Summary:
        //     Get or set the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        //     to use for extended protection for a session.
        //
        // Returns:
        //     A System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
        //     that specifies the policy to use for extended protection.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        //     property, but the System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.CustomChannelBinding
        //     property was not null.
        //
        //   T:System.ArgumentNullException:
        //     An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        //     property to null.
        //
        //   T:System.InvalidOperationException:
        //     An attempt was made to set the System.Net.HttpListener.ExtendedProtectionPolicy
        //     property after the System.Net.HttpListener.Start method was already called.
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        //
        //   T:System.PlatformNotSupportedException:
        //     The System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy.PolicyEnforcement
        //     property was set to System.Security.Authentication.ExtendedProtection.PolicyEnforcement.Always
        //     on a platform that does not support extended protection.
        public ExtendedProtectionPolicy ExtendedProtectionPolicy { get { return listener.ExtendedProtectionPolicy; } set { listener.ExtendedProtectionPolicy = value; } }

        //
        // Summary:
        //     Gets or sets a System.Boolean value that specifies whether your application receives
        //     exceptions that occur when an System.Net.HttpListener sends the response to the
        //     client.
        //
        // Returns:
        //     true if this System.Net.HttpListener should not return exceptions that occur
        //     when sending the response to the client; otherwise false. The default value is
        //     false.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public bool IgnoreWriteExceptions { get { return listener.IgnoreWriteExceptions; } set { listener.IgnoreWriteExceptions = value; } }
        //
        // Summary:
        //     Gets a value that indicates whether System.Net.HttpListener has been started.
        //
        // Returns:
        //     true if the System.Net.HttpListener was started; otherwise, false.
        public bool IsListening { get { return listener.IsListening; } }
        //
        // Summary:
        //     Gets the Uniform Resource Identifier (URI) prefixes handled by this System.Net.HttpListener
        //     object.
        //
        // Returns:
        //     An System.Net.HttpListenerPrefixCollection that contains the URI prefixes that
        //     this System.Net.HttpListener object is configured to handle.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public HttpListenerPrefixCollection Prefixes { get { return listener.Prefixes; } }
        //
        // Summary:
        //     Gets or sets the realm, or resource partition, associated with this System.Net.HttpListener
        //     object.
        //
        // Returns:
        //     A System.String value that contains the name of the realm associated with the
        //     System.Net.HttpListener object.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public string Realm { get { return listener.Realm; } set { listener.Realm = value; } }
        //
        // Summary:
        //     The timeout manager for this System.Net.HttpListener instance.
        //
        // Returns:
        //     Returns System.Net.HttpListenerTimeoutManager.The timeout manager for this System.Net.HttpListener
        //     instance.
        public HttpListenerTimeoutManager TimeoutManager { get { return listener.TimeoutManager; } }
        //
        // Summary:
        //     Gets or sets a System.Boolean value that controls whether, when NTLM is used,
        //     additional requests using the same Transmission Control Protocol (TCP) connection
        //     are required to authenticate.
        //
        // Returns:
        //     true if the System.Security.Principal.IIdentity of the first request will be
        //     used for subsequent requests on the same connection; otherwise, false. The default
        //     value is false.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object has been closed.
        public bool UnsafeConnectionNtlmAuthentication { get { return listener.UnsafeConnectionNtlmAuthentication; } set { listener.IgnoreWriteExceptions = value; } }

        [Json.JsonIgnore]
        public Func<Context, dynamic> On404 { get; set; }

        #endregion

        static void SendValue(Context cnt, object obj)
        {
            dynamic value = obj;

            if (value == null) return;

            if (value is IResponse)
            {
                value.SetHeaders(cnt);

                if (value != null && cnt.Request.HttpMethod.ToLowerInvariant() != "head")
                {
                    value.SendResponse(cnt);
                }
            }
            else if (value is Stream)
            {
                value.CopyTo(cnt.Response.OutputStream);
            }
            else if (value.GetType().IsValueType) cnt.Writer.Write(value.ToString());
            else
            {
                cnt.Response.Headers.Set("Content-Type", "application/json");
                cnt.Writer.Write(JSON.Serialize(value));
            }
        }

        #region NETFLUID METHODS

        public void Start()
        {
            Logger.Info("Starting serving clients");

            listener.Start();

            while (IsListening)
            {
                var accept = listener.GetContext();
                Task.Factory.StartNew(() =>
                {
                    Logger.Debug("New client " + accept.Request.HttpMethod + " " + accept.Request.Url.LocalPath);

                    var c = new Context(accept);

                    try
                    {
                        Serve(c);
                    }
                    catch (Exception ex)
                    {
                        if (ex is TargetInvocationException) ex = ex.InnerException;

                        Logger.Error("Error " + ex.Message);
                        c.Response.StatusCode = StatusCode.InternalServerError;

                        if (OnException != null)
                        {
                            var value = OnException(c,ex);
                            SendValue(c,value);
                        }
                    }
                    finally
                    {
                        Logger.Debug("New client " + accept.Request.HttpMethod + " " + accept.Request.Url.LocalPath);
                        c.Close();
                    }
                });
            }
        }

        public Task StartAsync()
        {
            Logger.Info("Starting serving clients");

            listeningTask = Task.Factory.StartNew(() =>
            {
                listener.Start();

                while (IsListening)
                {
                    var accept = listener.GetContext();
                    Task.Factory.StartNew(() =>
                    {
                        Logger.Debug("New client "+accept.Request.HttpMethod+" "+accept.Request.Url.LocalPath);

                        var c = new Context(accept);

                        try
                        {

                            Serve(c);
                        }
                        catch(Exception ex)
                        {
                            while (ex is TargetInvocationException) ex = ex.InnerException;

                            Logger.Error("Error "+ex.Message);
                            c.Response.StatusCode = StatusCode.InternalServerError;

                            if (OnException != null)
                            {
                                var value = OnException(c, ex);
                                SendValue(c, value);
                            }
                        }
                        finally
                        {
                            Logger.Debug("New client " + accept.Request.HttpMethod + " " + accept.Request.Url.LocalPath);
                            c.Close();
                        }
                    });
                }
            });

            return listeningTask;
        }

        public void Stop()
        {
            Logger.Info("Stopped");
            listener.Stop();
        }

        /// <summary>
        /// The current virtual host serve the given context
        /// </summary>
        /// <param name="cnt"></param>
        void Serve(Context cnt)
        {
            cnt.Host = this;

            if (cnt.Request.HttpMethod.ToLowerInvariant() == "options")
            {
                #region options
                var origin = cnt.Request.Headers["Origin"] ?? "*";
                cnt.Response.Headers.Set("Access-Control-Allow-Origin", origin);

                var headers = cnt.Request.Headers["Access-Control-Request-Headers"] ?? "*";
                cnt.Response.Headers.Set("Access-Control-Allow-Headers", headers);
                cnt.Response.Headers.Set("Access-Control-Max-Age", "360000");
                cnt.Response.Headers.Set("Access-Control-Allow-Methods", "GET, HEAD, POST, TRACE, OPTIONS, PUT, DELETE");
                cnt.Response.Close();
                return;

                #endregion
            }

            foreach (var filter in Filters.Where(x => x.HttpMethod == cnt.Request.HttpMethod || x.HttpMethod == null))
            {
                var value = filter.Handle(cnt);
                if (value is bool && value == false) continue;

                if (value == null) return;
                
                if (value is IResponse)
                {
                    value.SetHeaders(cnt);

                    if (value != null && cnt.Request.HttpMethod.ToLowerInvariant() != "head")
                    {
                        value.SendResponse(cnt);
                    }
                }
                else if (value is Stream)
                {
                    value.CopyTo(cnt.Response.OutputStream);
                }
                else if (value.GetType().IsValueType) cnt.Writer.Write(value.ToString());
                else
                {
                    cnt.Response.Headers.Set("Content-Type", "application/json");
                    cnt.Writer.Write(JSON.Serialize(value));
                }

                return;
            }
            if (!cnt.IsOpen)
                return;

            foreach (var trigger in Triggers.Where(x => x.HttpMethod == cnt.Request.HttpMethod || x.HttpMethod == null))
            {
                Task.Factory.StartNew(()=>trigger.Handle(cnt));
            }

            foreach (var routes in Routes.Where(x => x.HttpMethod == cnt.Request.HttpMethod || x.HttpMethod == null))
            {
                var value = routes.Handle(cnt);

                if (value is bool && value == false) continue;

                if (value == null) return;

                if (value is IResponse)
                {
                    value.SetHeaders(cnt);

                    if (value != null && cnt.Request.HttpMethod.ToLowerInvariant() != "head")
                    {
                        value.SendResponse(cnt);
                    }
                }
                else if (value is Stream)
                {
                    value.CopyTo(cnt.Response.OutputStream);
                }
                else if (value.GetType().IsValueType) cnt.Writer.Write(value.ToString());
                else
                {
                    cnt.Response.Headers.Set("Content-Type", "application/json");
                    cnt.Writer.Write(JSON.Serialize(value));
                }
                return;
            }

            if (!cnt.IsOpen)
                return;

            for (int i = 0; i < PublicFolders.Count; i++)
            {
                if (PublicFolders[i].TryGetFile(cnt))
                {
                    return;
                }
            }

            cnt.Response.StatusCode = StatusCode.NotFound;

            if (On404 == null) return;

            dynamic r404 = On404.Invoke(cnt);

            SendValue(cnt, r404);
        }

        public void Map(Assembly assembly)
        {
            var types = assembly.GetTypes();
            Logger.Debug($"Mapping {assembly} found {types.Length} types");
            types.ForEach(Map);
        }

        public void Map(object obj)
        {
            Load(obj.GetType(), obj);
        }

        public void Map(IEnumerable<Type> types)
        {
            types.ForEach(x=>Load(x,null));
        }

        public void Map(Type type)
        {
            Load(type,null);
        }

        void Load(Type type, object instance)
        {
            //Logger.Debug("Mapping type "+type);

            if (instance == null && type.HasDefaultConstructor() && !type.IsGenericType && !type.IsAbstract)
            {
                try
                {
                    instance = type.CreateIstance();
                }
                catch (Exception)
                {
                    return;
                }
            }

            var prefixes = type.CustomAttribute<RouteAttribute>(true).Select(x=>x.Url);
            if (prefixes.Count() == 0)
                prefixes = new[] { string.Empty };

            foreach (var m in type.GetMethods(BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance|BindingFlags.Static))
            {
                if(m.HasAttribute<Handler404>())
                {
                    On404 = x => m.Invoke(instance,new[] { x });
                }

                foreach (var prefix in prefixes)
                {
                    foreach (var att in m.CustomAttribute<RouteAttribute>())
                    {
                        try
                        {
                            Logger.Debug("Setting route " + att.Url + " for method " + m.Name);
                            Routes.Add(new Route(m, m.IsStatic ? null : instance)
                            {
                                Url = prefix + att.Url,
                                HttpMethod = att.Method,
                                Index = att.Index,
                            });
                        }
                        catch (Exception ex)
                        {
                            Logger.Error("Failed to load filter " + att.Url + " for method " + m.Name + "." + ex.Message);
                        }
                    }

                    foreach (var att in m.CustomAttribute<FilterAttribute>())
                    {
                        try
                        {
                            Logger.Debug("Setting filter " + att.Url + " for method " + m.Name);
                            Filters.Add(new Route(m, m.IsStatic ? null : instance)
                            {
                                Url = prefix + att.Url,
                                HttpMethod = att.Method,
                                Index = att.Index
                            });
                        }
                        catch (Exception ex)
                        {
                            Logger.Error("Failed to load filter "+att.Url+" for method " + m.Name+"."+ex.Message);
                        }
                    }

                    foreach (var att in m.CustomAttribute<TriggerAttribute>())
                    {
                        try
                        {
                            Logger.Debug("Setting trigger " + att.Url + " for method " + m.Name);
                            Triggers.Add(new Route(m, m.IsStatic ? null : instance)
                            {
                                Url = prefix + att.Url,
                                HttpMethod = att.Method,
                                Index = att.Index
                            });
                        }
                        catch (Exception ex)
                        {
                            Logger.Error("Failed to load filter " + att.Url + " for method " + m.Name + "." + ex.Message);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
