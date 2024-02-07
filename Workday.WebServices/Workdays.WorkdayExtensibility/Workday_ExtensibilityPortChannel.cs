using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public interface Workday_ExtensibilityPortChannel : Workday_ExtensibilityPort, IClientChannel, IContextChannel, IChannel, ICommunicationObject, IExtensibleObject<IContextChannel>, IDisposable
	{
	}
}
