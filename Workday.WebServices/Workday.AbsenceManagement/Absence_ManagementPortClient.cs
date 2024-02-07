using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Absence_ManagementPortClient : ClientBase<Absence_ManagementPort>, Absence_ManagementPort
	{
		public Absence_ManagementPortClient()
		{
		}

		public Absence_ManagementPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Absence_ManagementPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Absence_ManagementPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Absence_ManagementPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Adjust_Time_OffOutput Absence_ManagementPort.Adjust_Time_Off(Adjust_Time_OffInput request)
		{
			return base.Channel.Adjust_Time_Off(request);
		}

		public Time_Off_Event_ResponseType Adjust_Time_Off(Workday_Common_HeaderType Workday_Common_Header, Adjust_Time_Off_RequestType Adjust_Time_Off_Request)
		{
			return ((Absence_ManagementPort)this).Adjust_Time_Off(new Adjust_Time_OffInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Time_Off_Request = Adjust_Time_Off_Request
			}).Time_Off_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Adjust_Time_OffOutput> Absence_ManagementPort.Adjust_Time_OffAsync(Adjust_Time_OffInput request)
		{
			return base.Channel.Adjust_Time_OffAsync(request);
		}

		public Task<Adjust_Time_OffOutput> Adjust_Time_OffAsync(Workday_Common_HeaderType Workday_Common_Header, Adjust_Time_Off_RequestType Adjust_Time_Off_Request)
		{
			return ((Absence_ManagementPort)this).Adjust_Time_OffAsync(new Adjust_Time_OffInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Adjust_Time_Off_Request = Adjust_Time_Off_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Adjust_Time_OffOutput Absence_ManagementPort.Enter_Time_Off(Enter_Time_OffInput request)
		{
			return base.Channel.Enter_Time_Off(request);
		}

		public Time_Off_Event_ResponseType Enter_Time_Off(Workday_Common_HeaderType Workday_Common_Header, Enter_Time_Off_RequestType Enter_Time_Off_Request)
		{
			return ((Absence_ManagementPort)this).Enter_Time_Off(new Enter_Time_OffInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Enter_Time_Off_Request = Enter_Time_Off_Request
			}).Time_Off_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Adjust_Time_OffOutput> Absence_ManagementPort.Enter_Time_OffAsync(Enter_Time_OffInput request)
		{
			return base.Channel.Enter_Time_OffAsync(request);
		}

		public Task<Adjust_Time_OffOutput> Enter_Time_OffAsync(Workday_Common_HeaderType Workday_Common_Header, Enter_Time_Off_RequestType Enter_Time_Off_Request)
		{
			return ((Absence_ManagementPort)this).Enter_Time_OffAsync(new Enter_Time_OffInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Enter_Time_Off_Request = Enter_Time_Off_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Absence_InputOutput Absence_ManagementPort.Put_Absence_Input(Put_Absence_InputInput request)
		{
			return base.Channel.Put_Absence_Input(request);
		}

		public Put_Absence_Input_ResponseType Put_Absence_Input(Workday_Common_HeaderType Workday_Common_Header, Put_Absence_Input_RequestType Put_Absence_Input_Request)
		{
			return ((Absence_ManagementPort)this).Put_Absence_Input(new Put_Absence_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Absence_Input_Request = Put_Absence_Input_Request
			}).Put_Absence_Input_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Absence_InputOutput> Absence_ManagementPort.Put_Absence_InputAsync(Put_Absence_InputInput request)
		{
			return base.Channel.Put_Absence_InputAsync(request);
		}

		public Task<Put_Absence_InputOutput> Put_Absence_InputAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Absence_Input_RequestType Put_Absence_Input_Request)
		{
			return ((Absence_ManagementPort)this).Put_Absence_InputAsync(new Put_Absence_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Absence_Input_Request = Put_Absence_Input_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Absence_InputsOutput Absence_ManagementPort.Get_Absence_Inputs(Get_Absence_InputsInput request)
		{
			return base.Channel.Get_Absence_Inputs(request);
		}

		public Get_Absence_Inputs_ResponseType Get_Absence_Inputs(Workday_Common_HeaderType Workday_Common_Header, Get_Absence_Inputs_RequestType Get_Absence_Inputs_Request)
		{
			return ((Absence_ManagementPort)this).Get_Absence_Inputs(new Get_Absence_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Absence_Inputs_Request = Get_Absence_Inputs_Request
			}).Get_Absence_Inputs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Absence_InputsOutput> Absence_ManagementPort.Get_Absence_InputsAsync(Get_Absence_InputsInput request)
		{
			return base.Channel.Get_Absence_InputsAsync(request);
		}

		public Task<Get_Absence_InputsOutput> Get_Absence_InputsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Absence_Inputs_RequestType Get_Absence_Inputs_Request)
		{
			return ((Absence_ManagementPort)this).Get_Absence_InputsAsync(new Get_Absence_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Absence_Inputs_Request = Get_Absence_Inputs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Leave_of_AbsenceOutput Absence_ManagementPort.Request_Leave_of_Absence(Request_Leave_of_AbsenceInput request)
		{
			return base.Channel.Request_Leave_of_Absence(request);
		}

		public Request_Leave_of_Absence_ResponseType Request_Leave_of_Absence(Workday_Common_HeaderType Workday_Common_Header, Request_Leave_of_Absence_RequestType Request_Leave_of_Absence_Request)
		{
			return ((Absence_ManagementPort)this).Request_Leave_of_Absence(new Request_Leave_of_AbsenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Leave_of_Absence_Request = Request_Leave_of_Absence_Request
			}).Request_Leave_of_Absence_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Leave_of_AbsenceOutput> Absence_ManagementPort.Request_Leave_of_AbsenceAsync(Request_Leave_of_AbsenceInput request)
		{
			return base.Channel.Request_Leave_of_AbsenceAsync(request);
		}

		public Task<Request_Leave_of_AbsenceOutput> Request_Leave_of_AbsenceAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Leave_of_Absence_RequestType Request_Leave_of_Absence_Request)
		{
			return ((Absence_ManagementPort)this).Request_Leave_of_AbsenceAsync(new Request_Leave_of_AbsenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Leave_of_Absence_Request = Request_Leave_of_Absence_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Request_Return_from_Leave_of_AbsenceOutput Absence_ManagementPort.Request_Return_from_Leave_of_Absence(Request_Return_from_Leave_of_AbsenceInput request)
		{
			return base.Channel.Request_Return_from_Leave_of_Absence(request);
		}

		public Request_Return_from_Leave_of_Absence_ResponseType Request_Return_from_Leave_of_Absence(Workday_Common_HeaderType Workday_Common_Header, Request_Return_from_Leave_of_Absence_RequestType Request_Return_from_Leave_of_Absence_Request)
		{
			return ((Absence_ManagementPort)this).Request_Return_from_Leave_of_Absence(new Request_Return_from_Leave_of_AbsenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Return_from_Leave_of_Absence_Request = Request_Return_from_Leave_of_Absence_Request
			}).Request_Return_from_Leave_of_Absence_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Request_Return_from_Leave_of_AbsenceOutput> Absence_ManagementPort.Request_Return_from_Leave_of_AbsenceAsync(Request_Return_from_Leave_of_AbsenceInput request)
		{
			return base.Channel.Request_Return_from_Leave_of_AbsenceAsync(request);
		}

		public Task<Request_Return_from_Leave_of_AbsenceOutput> Request_Return_from_Leave_of_AbsenceAsync(Workday_Common_HeaderType Workday_Common_Header, Request_Return_from_Leave_of_Absence_RequestType Request_Return_from_Leave_of_Absence_Request)
		{
			return ((Absence_ManagementPort)this).Request_Return_from_Leave_of_AbsenceAsync(new Request_Return_from_Leave_of_AbsenceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Request_Return_from_Leave_of_Absence_Request = Request_Return_from_Leave_of_Absence_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Override_BalancesOutput Absence_ManagementPort.Get_Override_Balances(Get_Override_BalancesInput request)
		{
			return base.Channel.Get_Override_Balances(request);
		}

		public Get_Override_Balances_ResponseType Get_Override_Balances(Workday_Common_HeaderType Workday_Common_Header, Get_Override_Balances_RequestType Get_Override_Balances_Request)
		{
			return ((Absence_ManagementPort)this).Get_Override_Balances(new Get_Override_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Override_Balances_Request = Get_Override_Balances_Request
			}).Get_Override_Balances_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Override_BalancesOutput> Absence_ManagementPort.Get_Override_BalancesAsync(Get_Override_BalancesInput request)
		{
			return base.Channel.Get_Override_BalancesAsync(request);
		}

		public Task<Get_Override_BalancesOutput> Get_Override_BalancesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Override_Balances_RequestType Get_Override_Balances_Request)
		{
			return ((Absence_ManagementPort)this).Get_Override_BalancesAsync(new Get_Override_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Override_Balances_Request = Get_Override_Balances_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Override_BalanceOutput Absence_ManagementPort.Put_Override_Balance(Put_Override_BalanceInput request)
		{
			return base.Channel.Put_Override_Balance(request);
		}

		public Put_Override_Balance_ResponseType Put_Override_Balance(Workday_Common_HeaderType Workday_Common_Header, Put_Override_Balance_RequestType Put_Override_Balance_Request)
		{
			return ((Absence_ManagementPort)this).Put_Override_Balance(new Put_Override_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Override_Balance_Request = Put_Override_Balance_Request
			}).Put_Override_Balance_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Override_BalanceOutput> Absence_ManagementPort.Put_Override_BalanceAsync(Put_Override_BalanceInput request)
		{
			return base.Channel.Put_Override_BalanceAsync(request);
		}

		public Task<Put_Override_BalanceOutput> Put_Override_BalanceAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Override_Balance_RequestType Put_Override_Balance_Request)
		{
			return ((Absence_ManagementPort)this).Put_Override_BalanceAsync(new Put_Override_BalanceInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Override_Balance_Request = Put_Override_Balance_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Time_Off_Plan_BalancesOutput Absence_ManagementPort.Get_Time_Off_Plan_Balances(Get_Time_Off_Plan_BalancesInput request)
		{
			return base.Channel.Get_Time_Off_Plan_Balances(request);
		}

		public Get_Time_Off_Plan_Balances_ResponseType Get_Time_Off_Plan_Balances(Workday_Common_HeaderType Workday_Common_Header, Get_Time_Off_Plan_Balances_RequestType Get_Time_Off_Plan_Balances_Request)
		{
			return ((Absence_ManagementPort)this).Get_Time_Off_Plan_Balances(new Get_Time_Off_Plan_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Time_Off_Plan_Balances_Request = Get_Time_Off_Plan_Balances_Request
			}).Get_Time_Off_Plan_Balances_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Time_Off_Plan_BalancesOutput> Absence_ManagementPort.Get_Time_Off_Plan_BalancesAsync(Get_Time_Off_Plan_BalancesInput request)
		{
			return base.Channel.Get_Time_Off_Plan_BalancesAsync(request);
		}

		public Task<Get_Time_Off_Plan_BalancesOutput> Get_Time_Off_Plan_BalancesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Time_Off_Plan_Balances_RequestType Get_Time_Off_Plan_Balances_Request)
		{
			return ((Absence_ManagementPort)this).Get_Time_Off_Plan_BalancesAsync(new Get_Time_Off_Plan_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Time_Off_Plan_Balances_Request = Get_Time_Off_Plan_Balances_Request
			});
		}
	}
}
