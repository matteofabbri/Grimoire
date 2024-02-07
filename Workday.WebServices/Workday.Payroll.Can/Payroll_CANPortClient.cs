using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Payroll_CANPortClient : ClientBase<Payroll_CANPort>, Payroll_CANPort
	{
		public Payroll_CANPortClient()
		{
		}

		public Payroll_CANPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Payroll_CANPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_CANPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_CANPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_CAN_Year_End_FormsOutput Payroll_CANPort.Get_Payroll_CAN_Year_End_Forms(Get_Payroll_CAN_Year_End_FormsInput request)
		{
			return base.Channel.Get_Payroll_CAN_Year_End_Forms(request);
		}

		public Get_Payroll_CAN_Year_End_Forms_ResponseType Get_Payroll_CAN_Year_End_Forms(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_CAN_Year_End_Forms_RequestType Get_Payroll_CAN_Year_End_Forms_Request)
		{
			return ((Payroll_CANPort)this).Get_Payroll_CAN_Year_End_Forms(new Get_Payroll_CAN_Year_End_FormsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_CAN_Year_End_Forms_Request = Get_Payroll_CAN_Year_End_Forms_Request
			}).Get_Payroll_CAN_Year_End_Forms_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_CAN_Year_End_FormsOutput> Payroll_CANPort.Get_Payroll_CAN_Year_End_FormsAsync(Get_Payroll_CAN_Year_End_FormsInput request)
		{
			return base.Channel.Get_Payroll_CAN_Year_End_FormsAsync(request);
		}

		public Task<Get_Payroll_CAN_Year_End_FormsOutput> Get_Payroll_CAN_Year_End_FormsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_CAN_Year_End_Forms_RequestType Get_Payroll_CAN_Year_End_Forms_Request)
		{
			return ((Payroll_CANPort)this).Get_Payroll_CAN_Year_End_FormsAsync(new Get_Payroll_CAN_Year_End_FormsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_CAN_Year_End_Forms_Request = Get_Payroll_CAN_Year_End_Forms_Request
			});
		}
	}
}
