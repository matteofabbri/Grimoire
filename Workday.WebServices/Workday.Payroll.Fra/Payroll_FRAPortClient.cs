using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Payroll.Fra
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Payroll_FRAPortClient : ClientBase<Payroll_FRAPort>, Payroll_FRAPort
	{
		public Payroll_FRAPortClient()
		{
		}

		public Payroll_FRAPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Payroll_FRAPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_FRAPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_FRAPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_DSN_DataOutput Payroll_FRAPort.Get_DSN_Data(Get_DSN_DataInput request)
		{
			return base.Channel.Get_DSN_Data(request);
		}

		public Get_DSN_Data_ResponseType Get_DSN_Data(Workday_Common_HeaderType Workday_Common_Header, Get_DSN_Data_RequestType Get_DSN_Data_Request)
		{
			return ((Payroll_FRAPort)this).Get_DSN_Data(new Get_DSN_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_DSN_Data_Request = Get_DSN_Data_Request
			}).Get_DSN_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_DSN_DataOutput> Payroll_FRAPort.Get_DSN_DataAsync(Get_DSN_DataInput request)
		{
			return base.Channel.Get_DSN_DataAsync(request);
		}

		public Task<Get_DSN_DataOutput> Get_DSN_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_DSN_Data_RequestType Get_DSN_Data_Request)
		{
			return ((Payroll_FRAPort)this).Get_DSN_DataAsync(new Get_DSN_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_DSN_Data_Request = Get_DSN_Data_Request
			});
		}
	}
}
