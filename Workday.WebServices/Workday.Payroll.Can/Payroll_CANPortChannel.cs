using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public interface Payroll_CANPortChannel : Payroll_CANPort, IClientChannel, IContextChannel, IChannel, ICommunicationObject, IExtensibleObject<IContextChannel>, IDisposable
	{
	}
}
