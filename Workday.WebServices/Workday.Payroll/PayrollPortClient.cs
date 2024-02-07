using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class PayrollPortClient : ClientBase<PayrollPort>, PayrollPort
	{
		public PayrollPortClient()
		{
		}

		public PayrollPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public PayrollPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public PayrollPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public PayrollPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_ResultsOutput PayrollPort.Get_Payroll_Results(Get_Payroll_ResultsInput request)
		{
			return base.Channel.Get_Payroll_Results(request);
		}

		public Get_Payroll_Results_ResponseType Get_Payroll_Results(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Results_RequestType Get_Payroll_Results_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Results(new Get_Payroll_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Results_Request = Get_Payroll_Results_Request
			}).Get_Payroll_Results_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_ResultsOutput> PayrollPort.Get_Payroll_ResultsAsync(Get_Payroll_ResultsInput request)
		{
			return base.Channel.Get_Payroll_ResultsAsync(request);
		}

		public Task<Get_Payroll_ResultsOutput> Get_Payroll_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Results_RequestType Get_Payroll_Results_Request)
		{
			return ((PayrollPort)this).Get_Payroll_ResultsAsync(new Get_Payroll_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Results_Request = Get_Payroll_Results_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_BalancesOutput PayrollPort.Get_Payroll_Balances(Get_Payroll_BalancesInput request)
		{
			return base.Channel.Get_Payroll_Balances(request);
		}

		public Get_Payroll_Balances_ResponseType Get_Payroll_Balances(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Balances_RequestType Get_Payroll_Balances_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Balances(new Get_Payroll_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Balances_Request = Get_Payroll_Balances_Request
			}).Get_Payroll_Balances_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_BalancesOutput> PayrollPort.Get_Payroll_BalancesAsync(Get_Payroll_BalancesInput request)
		{
			return base.Channel.Get_Payroll_BalancesAsync(request);
		}

		public Task<Get_Payroll_BalancesOutput> Get_Payroll_BalancesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Balances_RequestType Get_Payroll_Balances_Request)
		{
			return ((PayrollPort)this).Get_Payroll_BalancesAsync(new Get_Payroll_BalancesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Balances_Request = Get_Payroll_Balances_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Offcycle_PaymentOutput PayrollPort.Put_Payroll_Offcycle_Payment(Put_Payroll_Offcycle_PaymentInput request)
		{
			return base.Channel.Put_Payroll_Offcycle_Payment(request);
		}

		public Put_Payroll_Offcycle_Payment_ResponseType Put_Payroll_Offcycle_Payment(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Offcycle_Payment_RequestType Put_Payroll_Offcycle_Payment_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Offcycle_Payment(new Put_Payroll_Offcycle_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Offcycle_Payment_Request = Put_Payroll_Offcycle_Payment_Request
			}).Put_Payroll_Offcycle_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Offcycle_PaymentOutput> PayrollPort.Put_Payroll_Offcycle_PaymentAsync(Put_Payroll_Offcycle_PaymentInput request)
		{
			return base.Channel.Put_Payroll_Offcycle_PaymentAsync(request);
		}

		public Task<Put_Payroll_Offcycle_PaymentOutput> Put_Payroll_Offcycle_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Offcycle_Payment_RequestType Put_Payroll_Offcycle_Payment_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Offcycle_PaymentAsync(new Put_Payroll_Offcycle_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Offcycle_Payment_Request = Put_Payroll_Offcycle_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_History_PaymentOutput PayrollPort.Put_Payroll_History_Payment(Put_Payroll_History_PaymentInput request)
		{
			return base.Channel.Put_Payroll_History_Payment(request);
		}

		public Put_Payroll_History_Payment_ResponseType Put_Payroll_History_Payment(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_History_Payment_RequestType Put_Payroll_History_Payment_Request)
		{
			return ((PayrollPort)this).Put_Payroll_History_Payment(new Put_Payroll_History_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_History_Payment_Request = Put_Payroll_History_Payment_Request
			}).Put_Payroll_History_Payment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_History_PaymentOutput> PayrollPort.Put_Payroll_History_PaymentAsync(Put_Payroll_History_PaymentInput request)
		{
			return base.Channel.Put_Payroll_History_PaymentAsync(request);
		}

		public Task<Put_Payroll_History_PaymentOutput> Put_Payroll_History_PaymentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_History_Payment_RequestType Put_Payroll_History_Payment_Request)
		{
			return ((PayrollPort)this).Put_Payroll_History_PaymentAsync(new Put_Payroll_History_PaymentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_History_Payment_Request = Put_Payroll_History_Payment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Payroll_InputOutput PayrollPort.Submit_Payroll_Input(Submit_Payroll_InputInput request)
		{
			return base.Channel.Submit_Payroll_Input(request);
		}

		public Submit_Payroll_Input_ResponseType Submit_Payroll_Input(Workday_Common_HeaderType Workday_Common_Header, Submit_Payroll_Input_RequestType Submit_Payroll_Input_Request)
		{
			return ((PayrollPort)this).Submit_Payroll_Input(new Submit_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Payroll_Input_Request = Submit_Payroll_Input_Request
			}).Submit_Payroll_Input_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Payroll_InputOutput> PayrollPort.Submit_Payroll_InputAsync(Submit_Payroll_InputInput request)
		{
			return base.Channel.Submit_Payroll_InputAsync(request);
		}

		public Task<Submit_Payroll_InputOutput> Submit_Payroll_InputAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Payroll_Input_RequestType Submit_Payroll_Input_Request)
		{
			return ((PayrollPort)this).Submit_Payroll_InputAsync(new Submit_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Payroll_Input_Request = Submit_Payroll_Input_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_History_PaymentsOutput PayrollPort.Get_Payroll_History_Payments(Get_Payroll_History_PaymentsInput request)
		{
			return base.Channel.Get_Payroll_History_Payments(request);
		}

		public Get_Payroll_History_Payments_ResponseType Get_Payroll_History_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_History_Payments_RequestType Get_Payroll_History_Payments_Request)
		{
			return ((PayrollPort)this).Get_Payroll_History_Payments(new Get_Payroll_History_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_History_Payments_Request = Get_Payroll_History_Payments_Request
			}).Get_Payroll_History_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_History_PaymentsOutput> PayrollPort.Get_Payroll_History_PaymentsAsync(Get_Payroll_History_PaymentsInput request)
		{
			return base.Channel.Get_Payroll_History_PaymentsAsync(request);
		}

		public Task<Get_Payroll_History_PaymentsOutput> Get_Payroll_History_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_History_Payments_RequestType Get_Payroll_History_Payments_Request)
		{
			return ((PayrollPort)this).Get_Payroll_History_PaymentsAsync(new Get_Payroll_History_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_History_Payments_Request = Get_Payroll_History_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Period_SchedulesOutput PayrollPort.Get_Period_Schedules(Get_Period_SchedulesInput request)
		{
			return base.Channel.Get_Period_Schedules(request);
		}

		public Get_Period_Schedules_ResponseType Get_Period_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Schedules_RequestType Get_Period_Schedules_Request)
		{
			return ((PayrollPort)this).Get_Period_Schedules(new Get_Period_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Schedules_Request = Get_Period_Schedules_Request
			}).Get_Period_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Period_SchedulesOutput> PayrollPort.Get_Period_SchedulesAsync(Get_Period_SchedulesInput request)
		{
			return base.Channel.Get_Period_SchedulesAsync(request);
		}

		public Task<Get_Period_SchedulesOutput> Get_Period_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Schedules_RequestType Get_Period_Schedules_Request)
		{
			return ((PayrollPort)this).Get_Period_SchedulesAsync(new Get_Period_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Schedules_Request = Get_Period_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Period_ScheduleOutput PayrollPort.Put_Period_Schedule(Put_Period_ScheduleInput request)
		{
			return base.Channel.Put_Period_Schedule(request);
		}

		public Put_Period_Schedule_ResponseType Put_Period_Schedule(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Schedule_RequestType Put_Period_Schedule_Request)
		{
			return ((PayrollPort)this).Put_Period_Schedule(new Put_Period_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Schedule_Request = Put_Period_Schedule_Request
			}).Put_Period_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Period_ScheduleOutput> PayrollPort.Put_Period_ScheduleAsync(Put_Period_ScheduleInput request)
		{
			return base.Channel.Put_Period_ScheduleAsync(request);
		}

		public Task<Put_Period_ScheduleOutput> Put_Period_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Schedule_RequestType Put_Period_Schedule_Request)
		{
			return ((PayrollPort)this).Put_Period_ScheduleAsync(new Put_Period_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Schedule_Request = Put_Period_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Submit_Payroll_InputsOutput PayrollPort.Get_Submit_Payroll_Inputs(Get_Submit_Payroll_InputsInput request)
		{
			return base.Channel.Get_Submit_Payroll_Inputs(request);
		}

		public Get_Submit_Payroll_Inputs_ResponseType Get_Submit_Payroll_Inputs(Workday_Common_HeaderType Workday_Common_Header, Get_Submit_Payroll_Inputs_RequestType Get_Submit_Payroll_Inputs_Request)
		{
			return ((PayrollPort)this).Get_Submit_Payroll_Inputs(new Get_Submit_Payroll_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Submit_Payroll_Inputs_Request = Get_Submit_Payroll_Inputs_Request
			}).Get_Submit_Payroll_Inputs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Submit_Payroll_InputsOutput> PayrollPort.Get_Submit_Payroll_InputsAsync(Get_Submit_Payroll_InputsInput request)
		{
			return base.Channel.Get_Submit_Payroll_InputsAsync(request);
		}

		public Task<Get_Submit_Payroll_InputsOutput> Get_Submit_Payroll_InputsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Submit_Payroll_Inputs_RequestType Get_Submit_Payroll_Inputs_Request)
		{
			return ((PayrollPort)this).Get_Submit_Payroll_InputsAsync(new Get_Submit_Payroll_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Submit_Payroll_Inputs_Request = Get_Submit_Payroll_Inputs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Costing_AllocationOutput PayrollPort.Assign_Costing_Allocation(Assign_Costing_AllocationInput request)
		{
			return base.Channel.Assign_Costing_Allocation(request);
		}

		public Assign_Costing_Allocation_ResponseType Assign_Costing_Allocation(Workday_Common_HeaderType Workday_Common_Header, Assign_Costing_Allocation_RequestType Assign_Costing_Allocation_Request)
		{
			return ((PayrollPort)this).Assign_Costing_Allocation(new Assign_Costing_AllocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Costing_Allocation_Request = Assign_Costing_Allocation_Request
			}).Assign_Costing_Allocation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Costing_AllocationOutput> PayrollPort.Assign_Costing_AllocationAsync(Assign_Costing_AllocationInput request)
		{
			return base.Channel.Assign_Costing_AllocationAsync(request);
		}

		public Task<Assign_Costing_AllocationOutput> Assign_Costing_AllocationAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Costing_Allocation_RequestType Assign_Costing_Allocation_Request)
		{
			return ((PayrollPort)this).Assign_Costing_AllocationAsync(new Assign_Costing_AllocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Costing_Allocation_Request = Assign_Costing_Allocation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_PayslipsOutput PayrollPort.Get_Payroll_Payslips(Get_Payroll_PayslipsInput request)
		{
			return base.Channel.Get_Payroll_Payslips(request);
		}

		public Get_Payroll_Payslips_ResponseType Get_Payroll_Payslips(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payslips_RequestType Get_Payroll_Payslips_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payslips(new Get_Payroll_PayslipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payslips_Request = Get_Payroll_Payslips_Request
			}).Get_Payroll_Payslips_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_PayslipsOutput> PayrollPort.Get_Payroll_PayslipsAsync(Get_Payroll_PayslipsInput request)
		{
			return base.Channel.Get_Payroll_PayslipsAsync(request);
		}

		public Task<Get_Payroll_PayslipsOutput> Get_Payroll_PayslipsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payslips_RequestType Get_Payroll_Payslips_Request)
		{
			return ((PayrollPort)this).Get_Payroll_PayslipsAsync(new Get_Payroll_PayslipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payslips_Request = Get_Payroll_Payslips_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Quarterly_Worker_Tax_Filing_DataOutput PayrollPort.Get_Quarterly_Worker_Tax_Filing_Data(Get_Quarterly_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Quarterly_Worker_Tax_Filing_Data(request);
		}

		public Get_Quarterly_Worker_Tax_Data_ResponseType Get_Quarterly_Worker_Tax_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Quarterly_Worker_Tax_Data_RequestType Get_Quarterly_Worker_Tax_Data_Request)
		{
			return ((PayrollPort)this).Get_Quarterly_Worker_Tax_Filing_Data(new Get_Quarterly_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Quarterly_Worker_Tax_Data_Request = Get_Quarterly_Worker_Tax_Data_Request
			}).Get_Quarterly_Worker_Tax_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Quarterly_Worker_Tax_Filing_DataOutput> PayrollPort.Get_Quarterly_Worker_Tax_Filing_DataAsync(Get_Quarterly_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Quarterly_Worker_Tax_Filing_DataAsync(request);
		}

		public Task<Get_Quarterly_Worker_Tax_Filing_DataOutput> Get_Quarterly_Worker_Tax_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Quarterly_Worker_Tax_Data_RequestType Get_Quarterly_Worker_Tax_Data_Request)
		{
			return ((PayrollPort)this).Get_Quarterly_Worker_Tax_Filing_DataAsync(new Get_Quarterly_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Quarterly_Worker_Tax_Data_Request = Get_Quarterly_Worker_Tax_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_FICAOutput PayrollPort.Put_Payroll_Payee_FICA(Put_Payroll_Payee_FICAInput request)
		{
			return base.Channel.Put_Payroll_Payee_FICA(request);
		}

		public Put_Payroll_Payee_FICA_ResponseType Put_Payroll_Payee_FICA(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_FICA_RequestType Put_Payroll_Payee_FICA_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_FICA(new Put_Payroll_Payee_FICAInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_FICA_Request = Put_Payroll_Payee_FICA_Request
			}).Put_Payroll_Payee_FICA_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_FICAOutput> PayrollPort.Put_Payroll_Payee_FICAAsync(Put_Payroll_Payee_FICAInput request)
		{
			return base.Channel.Put_Payroll_Payee_FICAAsync(request);
		}

		public Task<Put_Payroll_Payee_FICAOutput> Put_Payroll_Payee_FICAAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_FICA_RequestType Put_Payroll_Payee_FICA_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_FICAAsync(new Put_Payroll_Payee_FICAInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_FICA_Request = Put_Payroll_Payee_FICA_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Periodic_Worker_Tax_Filing_DataOutput PayrollPort.Get_Periodic_Worker_Tax_Filing_Data(Get_Periodic_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Periodic_Worker_Tax_Filing_Data(request);
		}

		public Get_Periodic_Worker_Tax_Filing_Data_ResponseType Get_Periodic_Worker_Tax_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Worker_Tax_Filing_Data_RequestType Get_Periodic_Worker_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Worker_Tax_Filing_Data(new Get_Periodic_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Worker_Tax_Filing_Data_Request = Get_Periodic_Worker_Tax_Filing_Data_Request
			}).Get_Periodic_Worker_Tax_Filing_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Periodic_Worker_Tax_Filing_DataOutput> PayrollPort.Get_Periodic_Worker_Tax_Filing_DataAsync(Get_Periodic_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Periodic_Worker_Tax_Filing_DataAsync(request);
		}

		public Task<Get_Periodic_Worker_Tax_Filing_DataOutput> Get_Periodic_Worker_Tax_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Worker_Tax_Filing_Data_RequestType Get_Periodic_Worker_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Worker_Tax_Filing_DataAsync(new Get_Periodic_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Worker_Tax_Filing_Data_Request = Get_Periodic_Worker_Tax_Filing_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Periodic_Company_Tax_Filing_DataOutput PayrollPort.Get_Periodic_Company_Tax_Filing_Data(Get_Periodic_Company_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Periodic_Company_Tax_Filing_Data(request);
		}

		public Get_Periodic_Company_Tax_Filing_Data_ResponseType Get_Periodic_Company_Tax_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Company_Tax_Filing_Data_RequestType Get_Periodic_Company_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Company_Tax_Filing_Data(new Get_Periodic_Company_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Company_Tax_Filing_Data_Request = Get_Periodic_Company_Tax_Filing_Data_Request
			}).Get_Periodic_Company_Tax_Filing_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Periodic_Company_Tax_Filing_DataOutput> PayrollPort.Get_Periodic_Company_Tax_Filing_DataAsync(Get_Periodic_Company_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Periodic_Company_Tax_Filing_DataAsync(request);
		}

		public Task<Get_Periodic_Company_Tax_Filing_DataOutput> Get_Periodic_Company_Tax_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Company_Tax_Filing_Data_RequestType Get_Periodic_Company_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Company_Tax_Filing_DataAsync(new Get_Periodic_Company_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Company_Tax_Filing_Data_Request = Get_Periodic_Company_Tax_Filing_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_PT1sOutput PayrollPort.Get_Payroll_Payee_PT1s(Get_Payroll_Payee_PT1sInput request)
		{
			return base.Channel.Get_Payroll_Payee_PT1s(request);
		}

		public Get_Payroll_Payee_PT1s_ResponseType Get_Payroll_Payee_PT1s(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_PT1s_RequestType Get_Payroll_Payee_PT1s_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_PT1s(new Get_Payroll_Payee_PT1sInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_PT1s_Request = Get_Payroll_Payee_PT1s_Request
			}).Get_Payroll_Payee_PT1s_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_PT1sOutput> PayrollPort.Get_Payroll_Payee_PT1sAsync(Get_Payroll_Payee_PT1sInput request)
		{
			return base.Channel.Get_Payroll_Payee_PT1sAsync(request);
		}

		public Task<Get_Payroll_Payee_PT1sOutput> Get_Payroll_Payee_PT1sAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_PT1s_RequestType Get_Payroll_Payee_PT1s_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_PT1sAsync(new Get_Payroll_Payee_PT1sInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_PT1s_Request = Get_Payroll_Payee_PT1s_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_PT1Output PayrollPort.Put_Payroll_Payee_PT1(Put_Payroll_Payee_PT1Input request)
		{
			return base.Channel.Put_Payroll_Payee_PT1(request);
		}

		public Put_Payroll_Payee_PT1_ResponseType Put_Payroll_Payee_PT1(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_PT1_RequestType Put_Payroll_Payee_PT1_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_PT1(new Put_Payroll_Payee_PT1Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_PT1_Request = Put_Payroll_Payee_PT1_Request
			}).Put_Payroll_Payee_PT1_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_PT1Output> PayrollPort.Put_Payroll_Payee_PT1Async(Put_Payroll_Payee_PT1Input request)
		{
			return base.Channel.Put_Payroll_Payee_PT1Async(request);
		}

		public Task<Put_Payroll_Payee_PT1Output> Put_Payroll_Payee_PT1Async(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_PT1_RequestType Put_Payroll_Payee_PT1_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_PT1Async(new Put_Payroll_Payee_PT1Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_PT1_Request = Put_Payroll_Payee_PT1_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_FICAsOutput PayrollPort.Get_Payroll_Payee_FICAs(Get_Payroll_Payee_FICAsInput request)
		{
			return base.Channel.Get_Payroll_Payee_FICAs(request);
		}

		public Get_Payroll_Payee_FICAs_ResponseType Get_Payroll_Payee_FICAs(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_FICAs_RequestType Get_Payroll_Payee_FICAs_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_FICAs(new Get_Payroll_Payee_FICAsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_FICAs_Request = Get_Payroll_Payee_FICAs_Request
			}).Get_Payroll_Payee_FICAs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_FICAsOutput> PayrollPort.Get_Payroll_Payee_FICAsAsync(Get_Payroll_Payee_FICAsInput request)
		{
			return base.Channel.Get_Payroll_Payee_FICAsAsync(request);
		}

		public Task<Get_Payroll_Payee_FICAsOutput> Get_Payroll_Payee_FICAsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_FICAs_RequestType Get_Payroll_Payee_FICAs_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_FICAsAsync(new Get_Payroll_Payee_FICAsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_FICAs_Request = Get_Payroll_Payee_FICAs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Offcycle_PaymentsOutput PayrollPort.Get_Payroll_Offcycle_Payments(Get_Payroll_Offcycle_PaymentsInput request)
		{
			return base.Channel.Get_Payroll_Offcycle_Payments(request);
		}

		public Get_Payroll_Offcycle_Payments_ResponseType Get_Payroll_Offcycle_Payments(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Offcycle_Payments_RequestType Get_Payroll_Offcycle_Payments_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Offcycle_Payments(new Get_Payroll_Offcycle_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Offcycle_Payments_Request = Get_Payroll_Offcycle_Payments_Request
			}).Get_Payroll_Offcycle_Payments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Offcycle_PaymentsOutput> PayrollPort.Get_Payroll_Offcycle_PaymentsAsync(Get_Payroll_Offcycle_PaymentsInput request)
		{
			return base.Channel.Get_Payroll_Offcycle_PaymentsAsync(request);
		}

		public Task<Get_Payroll_Offcycle_PaymentsOutput> Get_Payroll_Offcycle_PaymentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Offcycle_Payments_RequestType Get_Payroll_Offcycle_Payments_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Offcycle_PaymentsAsync(new Get_Payroll_Offcycle_PaymentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Offcycle_Payments_Request = Get_Payroll_Offcycle_Payments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Company_Payment_DatesOutput PayrollPort.Get_Company_Payment_Dates(Get_Company_Payment_DatesInput request)
		{
			return base.Channel.Get_Company_Payment_Dates(request);
		}

		public Get_Company_Payment_Dates_ResponseType Get_Company_Payment_Dates(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Payment_Dates_RequestType Get_Company_Payment_Dates_Request)
		{
			return ((PayrollPort)this).Get_Company_Payment_Dates(new Get_Company_Payment_DatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Payment_Dates_Request = Get_Company_Payment_Dates_Request
			}).Get_Company_Payment_Dates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Company_Payment_DatesOutput> PayrollPort.Get_Company_Payment_DatesAsync(Get_Company_Payment_DatesInput request)
		{
			return base.Channel.Get_Company_Payment_DatesAsync(request);
		}

		public Task<Get_Company_Payment_DatesOutput> Get_Company_Payment_DatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Payment_Dates_RequestType Get_Company_Payment_Dates_Request)
		{
			return ((PayrollPort)this).Get_Company_Payment_DatesAsync(new Get_Company_Payment_DatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Payment_Dates_Request = Get_Company_Payment_Dates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_TD1sOutput PayrollPort.Get_Payroll_Payee_TD1s(Get_Payroll_Payee_TD1sInput request)
		{
			return base.Channel.Get_Payroll_Payee_TD1s(request);
		}

		public Get_Payroll_Payee_TD1s_ResponseType Get_Payroll_Payee_TD1s(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_TD1s_RequestType Get_Payroll_Payee_TD1s_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_TD1s(new Get_Payroll_Payee_TD1sInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_TD1s_Request = Get_Payroll_Payee_TD1s_Request
			}).Get_Payroll_Payee_TD1s_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_TD1sOutput> PayrollPort.Get_Payroll_Payee_TD1sAsync(Get_Payroll_Payee_TD1sInput request)
		{
			return base.Channel.Get_Payroll_Payee_TD1sAsync(request);
		}

		public Task<Get_Payroll_Payee_TD1sOutput> Get_Payroll_Payee_TD1sAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_TD1s_RequestType Get_Payroll_Payee_TD1s_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_TD1sAsync(new Get_Payroll_Payee_TD1sInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_TD1s_Request = Get_Payroll_Payee_TD1s_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_TD1Output PayrollPort.Put_Payroll_Payee_TD1(Put_Payroll_Payee_TD1Input request)
		{
			return base.Channel.Put_Payroll_Payee_TD1(request);
		}

		public Put_Payroll_Payee_T1_ResponseType Put_Payroll_Payee_TD1(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_TD1_RequestType Put_Payroll_Payee_TD1_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_TD1(new Put_Payroll_Payee_TD1Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_TD1_Request = Put_Payroll_Payee_TD1_Request
			}).Put_Payroll_Payee_T1_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_TD1Output> PayrollPort.Put_Payroll_Payee_TD1Async(Put_Payroll_Payee_TD1Input request)
		{
			return base.Channel.Put_Payroll_Payee_TD1Async(request);
		}

		public Task<Put_Payroll_Payee_TD1Output> Put_Payroll_Payee_TD1Async(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_TD1_RequestType Put_Payroll_Payee_TD1_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_TD1Async(new Put_Payroll_Payee_TD1Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_TD1_Request = Put_Payroll_Payee_TD1_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Canadian_Record_of_Employment_DataOutput PayrollPort.Get_Canadian_Record_of_Employment_Data(Get_Canadian_Record_of_Employment_DataInput request)
		{
			return base.Channel.Get_Canadian_Record_of_Employment_Data(request);
		}

		public Get_Canadian_Record_of_Employment_Data_ResponseType Get_Canadian_Record_of_Employment_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Canadian_Record_of_Employment_Data_RequestType Get_Canadian_Record_of_Employment_Data_Request)
		{
			return ((PayrollPort)this).Get_Canadian_Record_of_Employment_Data(new Get_Canadian_Record_of_Employment_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Canadian_Record_of_Employment_Data_Request = Get_Canadian_Record_of_Employment_Data_Request
			}).Get_Canadian_Record_of_Employment_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Canadian_Record_of_Employment_DataOutput> PayrollPort.Get_Canadian_Record_of_Employment_DataAsync(Get_Canadian_Record_of_Employment_DataInput request)
		{
			return base.Channel.Get_Canadian_Record_of_Employment_DataAsync(request);
		}

		public Task<Get_Canadian_Record_of_Employment_DataOutput> Get_Canadian_Record_of_Employment_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Canadian_Record_of_Employment_Data_RequestType Get_Canadian_Record_of_Employment_Data_Request)
		{
			return ((PayrollPort)this).Get_Canadian_Record_of_Employment_DataAsync(new Get_Canadian_Record_of_Employment_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Canadian_Record_of_Employment_Data_Request = Get_Canadian_Record_of_Employment_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ROE_History_DataOutput PayrollPort.Put_ROE_History_Data(Put_ROE_History_DataInput request)
		{
			return base.Channel.Put_ROE_History_Data(request);
		}

		public Put_ROE_History_Data_ResponseType Put_ROE_History_Data(Workday_Common_HeaderType Workday_Common_Header, Put_ROE_History_Data_RequestType Put_ROE_History_Data_Request)
		{
			return ((PayrollPort)this).Put_ROE_History_Data(new Put_ROE_History_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_ROE_History_Data_Request = Put_ROE_History_Data_Request
			}).Put_ROE_History_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ROE_History_DataOutput> PayrollPort.Put_ROE_History_DataAsync(Put_ROE_History_DataInput request)
		{
			return base.Channel.Put_ROE_History_DataAsync(request);
		}

		public Task<Put_ROE_History_DataOutput> Put_ROE_History_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Put_ROE_History_Data_RequestType Put_ROE_History_Data_Request)
		{
			return ((PayrollPort)this).Put_ROE_History_DataAsync(new Put_ROE_History_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_ROE_History_Data_Request = Put_ROE_History_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ROE_History_DataOutput PayrollPort.Get_ROE_History_Data(Get_ROE_History_DataInput request)
		{
			return base.Channel.Get_ROE_History_Data(request);
		}

		public Get_ROE_History_Data_ResponseType Get_ROE_History_Data(Workday_Common_HeaderType Workday_Common_Header, Get_ROE_History_Data_RequestType Get_ROE_History_Data_Request)
		{
			return ((PayrollPort)this).Get_ROE_History_Data(new Get_ROE_History_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ROE_History_Data_Request = Get_ROE_History_Data_Request
			}).Get_ROE_History_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ROE_History_DataOutput> PayrollPort.Get_ROE_History_DataAsync(Get_ROE_History_DataInput request)
		{
			return base.Channel.Get_ROE_History_DataAsync(request);
		}

		public Task<Get_ROE_History_DataOutput> Get_ROE_History_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_ROE_History_Data_RequestType Get_ROE_History_Data_Request)
		{
			return ((PayrollPort)this).Get_ROE_History_DataAsync(new Get_ROE_History_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_ROE_History_Data_Request = Get_ROE_History_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Canadian_Record_of_Employment_DataOutput PayrollPort.Put_Canadian_Record_of_Employment_Data(Put_Canadian_Record_of_Employment_DataInput request)
		{
			return base.Channel.Put_Canadian_Record_of_Employment_Data(request);
		}

		public Put_Canadian_Record_of_Employment_Data_ResponseType Put_Canadian_Record_of_Employment_Data(Workday_Common_HeaderType Workday_Common_Header, Put_Canadian_Record_of_Employment_Data_RequestType Put_Canadian_Record_of_Employment_Data_Request)
		{
			return ((PayrollPort)this).Put_Canadian_Record_of_Employment_Data(new Put_Canadian_Record_of_Employment_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Canadian_Record_of_Employment_Data_Request = Put_Canadian_Record_of_Employment_Data_Request
			}).Put_Canadian_Record_of_Employment_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Canadian_Record_of_Employment_DataOutput> PayrollPort.Put_Canadian_Record_of_Employment_DataAsync(Put_Canadian_Record_of_Employment_DataInput request)
		{
			return base.Channel.Put_Canadian_Record_of_Employment_DataAsync(request);
		}

		public Task<Put_Canadian_Record_of_Employment_DataOutput> Put_Canadian_Record_of_Employment_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Canadian_Record_of_Employment_Data_RequestType Put_Canadian_Record_of_Employment_Data_Request)
		{
			return ((PayrollPort)this).Put_Canadian_Record_of_Employment_DataAsync(new Put_Canadian_Record_of_Employment_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Canadian_Record_of_Employment_Data_Request = Put_Canadian_Record_of_Employment_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Federal_W4_Tax_ElectionOutput PayrollPort.Get_Payroll_Federal_W4_Tax_Election(Get_Payroll_Federal_W4_Tax_ElectionInput request)
		{
			return base.Channel.Get_Payroll_Federal_W4_Tax_Election(request);
		}

		public Get_Payroll_Federal_W4_Tax_Elections_ResponseType Get_Payroll_Federal_W4_Tax_Election(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Federal_W4_Tax_Elections_RequestType Get_Payroll_Federal_W4_Tax_Elections_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Federal_W4_Tax_Election(new Get_Payroll_Federal_W4_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Federal_W4_Tax_Elections_Request = Get_Payroll_Federal_W4_Tax_Elections_Request
			}).Get_Payroll_Federal_W4_Tax_Elections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Federal_W4_Tax_ElectionOutput> PayrollPort.Get_Payroll_Federal_W4_Tax_ElectionAsync(Get_Payroll_Federal_W4_Tax_ElectionInput request)
		{
			return base.Channel.Get_Payroll_Federal_W4_Tax_ElectionAsync(request);
		}

		public Task<Get_Payroll_Federal_W4_Tax_ElectionOutput> Get_Payroll_Federal_W4_Tax_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Federal_W4_Tax_Elections_RequestType Get_Payroll_Federal_W4_Tax_Elections_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Federal_W4_Tax_ElectionAsync(new Get_Payroll_Federal_W4_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Federal_W4_Tax_Elections_Request = Get_Payroll_Federal_W4_Tax_Elections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Federal_W4_Tax_ElectionOutput PayrollPort.Put_Payroll_Federal_W4_Tax_Election(Put_Payroll_Federal_W4_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_Federal_W4_Tax_Election(request);
		}

		public Put_Payroll_Federal_W4_Tax_Election_ResponseType Put_Payroll_Federal_W4_Tax_Election(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Federal_W4_Tax_Election_RequestType Put_Payroll_Federal_W4_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Federal_W4_Tax_Election(new Put_Payroll_Federal_W4_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Federal_W4_Tax_Election_Request = Put_Payroll_Federal_W4_Tax_Election_Request
			}).Put_Payroll_Federal_W4_Tax_Election_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Federal_W4_Tax_ElectionOutput> PayrollPort.Put_Payroll_Federal_W4_Tax_ElectionAsync(Put_Payroll_Federal_W4_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_Federal_W4_Tax_ElectionAsync(request);
		}

		public Task<Put_Payroll_Federal_W4_Tax_ElectionOutput> Put_Payroll_Federal_W4_Tax_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Federal_W4_Tax_Election_RequestType Put_Payroll_Federal_W4_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Federal_W4_Tax_ElectionAsync(new Put_Payroll_Federal_W4_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Federal_W4_Tax_Election_Request = Put_Payroll_Federal_W4_Tax_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Worker_Tax_TreatyOutput PayrollPort.Put_Payroll_Worker_Tax_Treaty(Put_Payroll_Worker_Tax_TreatyInput request)
		{
			return base.Channel.Put_Payroll_Worker_Tax_Treaty(request);
		}

		public Put_Worker_Tax_Treaty_ResponseType Put_Payroll_Worker_Tax_Treaty(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Worker_Tax_Treaty_RequestType Put_Payroll_Worker_Tax_Treaty_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Worker_Tax_Treaty(new Put_Payroll_Worker_Tax_TreatyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Worker_Tax_Treaty_Request = Put_Payroll_Worker_Tax_Treaty_Request
			}).Put_Worker_Tax_Treaty_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Worker_Tax_TreatyOutput> PayrollPort.Put_Payroll_Worker_Tax_TreatyAsync(Put_Payroll_Worker_Tax_TreatyInput request)
		{
			return base.Channel.Put_Payroll_Worker_Tax_TreatyAsync(request);
		}

		public Task<Put_Payroll_Worker_Tax_TreatyOutput> Put_Payroll_Worker_Tax_TreatyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Worker_Tax_Treaty_RequestType Put_Payroll_Worker_Tax_Treaty_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Worker_Tax_TreatyAsync(new Put_Payroll_Worker_Tax_TreatyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Worker_Tax_Treaty_Request = Put_Payroll_Worker_Tax_Treaty_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Worker_Tax_TreatiesOutput PayrollPort.Get_Payroll_Worker_Tax_Treaties(Get_Payroll_Worker_Tax_TreatiesInput request)
		{
			return base.Channel.Get_Payroll_Worker_Tax_Treaties(request);
		}

		public Get_Worker_Tax_Treaties_ResponseType Get_Payroll_Worker_Tax_Treaties(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Worker_Tax_Treaties_RequestType Get_Payroll_Worker_Tax_Treaties_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Worker_Tax_Treaties(new Get_Payroll_Worker_Tax_TreatiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Worker_Tax_Treaties_Request = Get_Payroll_Worker_Tax_Treaties_Request
			}).Get_Worker_Tax_Treaties_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Worker_Tax_TreatiesOutput> PayrollPort.Get_Payroll_Worker_Tax_TreatiesAsync(Get_Payroll_Worker_Tax_TreatiesInput request)
		{
			return base.Channel.Get_Payroll_Worker_Tax_TreatiesAsync(request);
		}

		public Task<Get_Payroll_Worker_Tax_TreatiesOutput> Get_Payroll_Worker_Tax_TreatiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Worker_Tax_Treaties_RequestType Get_Payroll_Worker_Tax_Treaties_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Worker_Tax_TreatiesAsync(new Get_Payroll_Worker_Tax_TreatiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Worker_Tax_Treaties_Request = Get_Payroll_Worker_Tax_Treaties_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Involuntary_Withholding_OrdersOutput PayrollPort.Get_Payroll_Involuntary_Withholding_Orders(Get_Payroll_Involuntary_Withholding_OrdersInput request)
		{
			return base.Channel.Get_Payroll_Involuntary_Withholding_Orders(request);
		}

		public Get_Payroll_Involuntary_Withholding_Orders_ResponseType Get_Payroll_Involuntary_Withholding_Orders(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Involuntary_Withholding_Orders_RequestType Get_Payroll_Involuntary_Withholding_Orders_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Involuntary_Withholding_Orders(new Get_Payroll_Involuntary_Withholding_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Involuntary_Withholding_Orders_Request = Get_Payroll_Involuntary_Withholding_Orders_Request
			}).Get_Payroll_Involuntary_Withholding_Orders_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Involuntary_Withholding_OrdersOutput> PayrollPort.Get_Payroll_Involuntary_Withholding_OrdersAsync(Get_Payroll_Involuntary_Withholding_OrdersInput request)
		{
			return base.Channel.Get_Payroll_Involuntary_Withholding_OrdersAsync(request);
		}

		public Task<Get_Payroll_Involuntary_Withholding_OrdersOutput> Get_Payroll_Involuntary_Withholding_OrdersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Involuntary_Withholding_Orders_RequestType Get_Payroll_Involuntary_Withholding_Orders_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Involuntary_Withholding_OrdersAsync(new Get_Payroll_Involuntary_Withholding_OrdersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Involuntary_Withholding_Orders_Request = Get_Payroll_Involuntary_Withholding_Orders_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Involuntary_Withholding_OrderOutput PayrollPort.Put_Payroll_Involuntary_Withholding_Order(Put_Payroll_Involuntary_Withholding_OrderInput request)
		{
			return base.Channel.Put_Payroll_Involuntary_Withholding_Order(request);
		}

		public Put_Payroll_Involuntary_Withholding_Order_ResponseType Put_Payroll_Involuntary_Withholding_Order(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Involuntary_Withholding_Order_RequestType Put_Payroll_Involuntary_Withholding_Order_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Involuntary_Withholding_Order(new Put_Payroll_Involuntary_Withholding_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Involuntary_Withholding_Order_Request = Put_Payroll_Involuntary_Withholding_Order_Request
			}).Put_Payroll_Involuntary_Withholding_Order_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Involuntary_Withholding_OrderOutput> PayrollPort.Put_Payroll_Involuntary_Withholding_OrderAsync(Put_Payroll_Involuntary_Withholding_OrderInput request)
		{
			return base.Channel.Put_Payroll_Involuntary_Withholding_OrderAsync(request);
		}

		public Task<Put_Payroll_Involuntary_Withholding_OrderOutput> Put_Payroll_Involuntary_Withholding_OrderAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Involuntary_Withholding_Order_RequestType Put_Payroll_Involuntary_Withholding_Order_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Involuntary_Withholding_OrderAsync(new Put_Payroll_Involuntary_Withholding_OrderInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Involuntary_Withholding_Order_Request = Put_Payroll_Involuntary_Withholding_Order_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_No_Retro_Processing_Prior_ToOutput PayrollPort.Change_No_Retro_Processing_Prior_To(Change_No_Retro_Processing_Prior_ToInput request)
		{
			return base.Channel.Change_No_Retro_Processing_Prior_To(request);
		}

		public Change_No_Retro_Processing_Prior_To_ResponseType Change_No_Retro_Processing_Prior_To(Workday_Common_HeaderType Workday_Common_Header, Change_No_Retro_Processing_Prior_To_RequestType Change_No_Retro_Processing_Prior_To_Request)
		{
			return ((PayrollPort)this).Change_No_Retro_Processing_Prior_To(new Change_No_Retro_Processing_Prior_ToInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_No_Retro_Processing_Prior_To_Request = Change_No_Retro_Processing_Prior_To_Request
			}).Change_No_Retro_Processing_Prior_To_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_No_Retro_Processing_Prior_ToOutput> PayrollPort.Change_No_Retro_Processing_Prior_ToAsync(Change_No_Retro_Processing_Prior_ToInput request)
		{
			return base.Channel.Change_No_Retro_Processing_Prior_ToAsync(request);
		}

		public Task<Change_No_Retro_Processing_Prior_ToOutput> Change_No_Retro_Processing_Prior_ToAsync(Workday_Common_HeaderType Workday_Common_Header, Change_No_Retro_Processing_Prior_To_RequestType Change_No_Retro_Processing_Prior_To_Request)
		{
			return ((PayrollPort)this).Change_No_Retro_Processing_Prior_ToAsync(new Change_No_Retro_Processing_Prior_ToInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_No_Retro_Processing_Prior_To_Request = Change_No_Retro_Processing_Prior_To_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Multiple_Worksite_ReportOutput PayrollPort.Get_Multiple_Worksite_Report(Get_Multiple_Worksite_ReportInput request)
		{
			return base.Channel.Get_Multiple_Worksite_Report(request);
		}

		public Get_Multiple_Worksite_Report_ResponseType Get_Multiple_Worksite_Report(Workday_Common_HeaderType Workday_Common_Header, Get_Multiple_Worksite_Report_RequestType Get_Multiple_Worksite_Report_Request)
		{
			return ((PayrollPort)this).Get_Multiple_Worksite_Report(new Get_Multiple_Worksite_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Multiple_Worksite_Report_Request = Get_Multiple_Worksite_Report_Request
			}).Get_Multiple_Worksite_Report_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Multiple_Worksite_ReportOutput> PayrollPort.Get_Multiple_Worksite_ReportAsync(Get_Multiple_Worksite_ReportInput request)
		{
			return base.Channel.Get_Multiple_Worksite_ReportAsync(request);
		}

		public Task<Get_Multiple_Worksite_ReportOutput> Get_Multiple_Worksite_ReportAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Multiple_Worksite_Report_RequestType Get_Multiple_Worksite_Report_Request)
		{
			return ((PayrollPort)this).Get_Multiple_Worksite_ReportAsync(new Get_Multiple_Worksite_ReportInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Multiple_Worksite_Report_Request = Get_Multiple_Worksite_Report_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Limit_OverridesOutput PayrollPort.Get_Payroll_Limit_Overrides(Get_Payroll_Limit_OverridesInput request)
		{
			return base.Channel.Get_Payroll_Limit_Overrides(request);
		}

		public Get_Payroll_Limit_Overrides_ResponseType Get_Payroll_Limit_Overrides(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Limit_Overrides_RequestType Get_Payroll_Limit_Overrides_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Limit_Overrides(new Get_Payroll_Limit_OverridesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Limit_Overrides_Request = Get_Payroll_Limit_Overrides_Request
			}).Get_Payroll_Limit_Overrides_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Limit_OverridesOutput> PayrollPort.Get_Payroll_Limit_OverridesAsync(Get_Payroll_Limit_OverridesInput request)
		{
			return base.Channel.Get_Payroll_Limit_OverridesAsync(request);
		}

		public Task<Get_Payroll_Limit_OverridesOutput> Get_Payroll_Limit_OverridesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Limit_Overrides_RequestType Get_Payroll_Limit_Overrides_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Limit_OverridesAsync(new Get_Payroll_Limit_OverridesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Limit_Overrides_Request = Get_Payroll_Limit_Overrides_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Limit_OverrideOutput PayrollPort.Put_Payroll_Limit_Override(Put_Payroll_Limit_OverrideInput request)
		{
			return base.Channel.Put_Payroll_Limit_Override(request);
		}

		public Put_Payroll_Limit_Override_ResponseType Put_Payroll_Limit_Override(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Limit_Override_RequestType Put_Payroll_Limit_Override_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Limit_Override(new Put_Payroll_Limit_OverrideInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Limit_Override_Request = Put_Payroll_Limit_Override_Request
			}).Put_Payroll_Limit_Override_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Limit_OverrideOutput> PayrollPort.Put_Payroll_Limit_OverrideAsync(Put_Payroll_Limit_OverrideInput request)
		{
			return base.Channel.Put_Payroll_Limit_OverrideAsync(request);
		}

		public Task<Put_Payroll_Limit_OverrideOutput> Put_Payroll_Limit_OverrideAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Limit_Override_RequestType Put_Payroll_Limit_Override_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Limit_OverrideAsync(new Put_Payroll_Limit_OverrideInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Limit_Override_Request = Put_Payroll_Limit_Override_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_Costing_AllocationsOutput PayrollPort.Get_Worker_Costing_Allocations(Get_Worker_Costing_AllocationsInput request)
		{
			return base.Channel.Get_Worker_Costing_Allocations(request);
		}

		public Get_Worker_Costing_Allocations_ResponseType Get_Worker_Costing_Allocations(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request)
		{
			return ((PayrollPort)this).Get_Worker_Costing_Allocations(new Get_Worker_Costing_AllocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Costing_Allocations_Request = Get_Worker_Costing_Allocations_Request
			}).Get_Worker_Costing_Allocations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_Costing_AllocationsOutput> PayrollPort.Get_Worker_Costing_AllocationsAsync(Get_Worker_Costing_AllocationsInput request)
		{
			return base.Channel.Get_Worker_Costing_AllocationsAsync(request);
		}

		public Task<Get_Worker_Costing_AllocationsOutput> Get_Worker_Costing_AllocationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request)
		{
			return ((PayrollPort)this).Get_Worker_Costing_AllocationsAsync(new Get_Worker_Costing_AllocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Costing_Allocations_Request = Get_Worker_Costing_Allocations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput PayrollPort.Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers(Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput request)
		{
			return base.Channel.Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers(request);
		}

		public Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_ResponseType Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_RequestType Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers(new Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request = Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request
			}).Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput> PayrollPort.Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersAsync(Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput request)
		{
			return base.Channel.Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersAsync(request);
		}

		public Task<Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput> Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_RequestType Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersAsync(new Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request = Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput PayrollPort.Put_Payroll_Payee_RPP_or_DPSP_Registration_Number(Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput request)
		{
			return base.Channel.Put_Payroll_Payee_RPP_or_DPSP_Registration_Number(request);
		}

		public Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_ResponseType Put_Payroll_Payee_RPP_or_DPSP_Registration_Number(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_RequestType Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_RPP_or_DPSP_Registration_Number(new Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request = Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request
			}).Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput> PayrollPort.Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberAsync(Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput request)
		{
			return base.Channel.Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberAsync(request);
		}

		public Task<Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput> Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_RequestType Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberAsync(new Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request = Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput PayrollPort.Get_Payroll_USA_State_and_Local_Tax_Elections(Get_Payroll_USA_State_and_Local_Tax_ElectionsInput request)
		{
			return base.Channel.Get_Payroll_USA_State_and_Local_Tax_Elections(request);
		}

		public Get_Payroll_USA_State_and_Local_Tax_Elections_ResponseType Get_Payroll_USA_State_and_Local_Tax_Elections(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_USA_State_and_Local_Tax_Elections_RequestType Get_Payroll_USA_State_and_Local_Tax_Elections_Request)
		{
			return ((PayrollPort)this).Get_Payroll_USA_State_and_Local_Tax_Elections(new Get_Payroll_USA_State_and_Local_Tax_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_USA_State_and_Local_Tax_Elections_Request = Get_Payroll_USA_State_and_Local_Tax_Elections_Request
			}).Get_Payroll_USA_State_and_Local_Tax_Elections_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput> PayrollPort.Get_Payroll_USA_State_and_Local_Tax_ElectionsAsync(Get_Payroll_USA_State_and_Local_Tax_ElectionsInput request)
		{
			return base.Channel.Get_Payroll_USA_State_and_Local_Tax_ElectionsAsync(request);
		}

		public Task<Get_Payroll_USA_State_and_Local_Tax_ElectionsOutput> Get_Payroll_USA_State_and_Local_Tax_ElectionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_USA_State_and_Local_Tax_Elections_RequestType Get_Payroll_USA_State_and_Local_Tax_Elections_Request)
		{
			return ((PayrollPort)this).Get_Payroll_USA_State_and_Local_Tax_ElectionsAsync(new Get_Payroll_USA_State_and_Local_Tax_ElectionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_USA_State_and_Local_Tax_Elections_Request = Get_Payroll_USA_State_and_Local_Tax_Elections_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_USA_State_and_Local_Tax_ElectionOutput PayrollPort.Put_Payroll_USA_State_and_Local_Tax_Election(Put_Payroll_USA_State_and_Local_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_USA_State_and_Local_Tax_Election(request);
		}

		public Put_Payroll_USA_State_and_Local_Tax_Election_ResponseType Put_Payroll_USA_State_and_Local_Tax_Election(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_USA_State_and_Local_Tax_Election_RequestType Put_Payroll_USA_State_and_Local_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_USA_State_and_Local_Tax_Election(new Put_Payroll_USA_State_and_Local_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_USA_State_and_Local_Tax_Election_Request = Put_Payroll_USA_State_and_Local_Tax_Election_Request
			}).Put_Payroll_USA_State_and_Local_Tax_Election_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_USA_State_and_Local_Tax_ElectionOutput> PayrollPort.Put_Payroll_USA_State_and_Local_Tax_ElectionAsync(Put_Payroll_USA_State_and_Local_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_USA_State_and_Local_Tax_ElectionAsync(request);
		}

		public Task<Put_Payroll_USA_State_and_Local_Tax_ElectionOutput> Put_Payroll_USA_State_and_Local_Tax_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_USA_State_and_Local_Tax_Election_RequestType Put_Payroll_USA_State_and_Local_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_USA_State_and_Local_Tax_ElectionAsync(new Put_Payroll_USA_State_and_Local_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_USA_State_and_Local_Tax_Election_Request = Put_Payroll_USA_State_and_Local_Tax_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput PayrollPort.Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request)
		{
			return base.Channel.Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(request);
		}

		public Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_RequestType Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(new Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request = Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request
			}).Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> PayrollPort.Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request)
		{
			return base.Channel.Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(request);
		}

		public Task<Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_RequestType Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(new Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request = Get_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput PayrollPort.Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(request);
		}

		public Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_ResponseType Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_RequestType Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election(new Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request = Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request
			}).Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> PayrollPort.Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput request)
		{
			return base.Channel.Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(request);
		}

		public Task<Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionOutput> Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_RequestType Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionAsync(new Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request = Put_Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Monthly_Worker_Tax_Filing_DataOutput PayrollPort.Get_Monthly_Worker_Tax_Filing_Data(Get_Monthly_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Monthly_Worker_Tax_Filing_Data(request);
		}

		public Get_Monthly_Worker_Tax_Filing_Data_ResponseType Get_Monthly_Worker_Tax_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Monthly_Worker_Tax_Filing_Data_RequestType Get_Monthly_Worker_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Monthly_Worker_Tax_Filing_Data(new Get_Monthly_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Monthly_Worker_Tax_Filing_Data_Request = Get_Monthly_Worker_Tax_Filing_Data_Request
			}).Get_Monthly_Worker_Tax_Filing_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Monthly_Worker_Tax_Filing_DataOutput> PayrollPort.Get_Monthly_Worker_Tax_Filing_DataAsync(Get_Monthly_Worker_Tax_Filing_DataInput request)
		{
			return base.Channel.Get_Monthly_Worker_Tax_Filing_DataAsync(request);
		}

		public Task<Get_Monthly_Worker_Tax_Filing_DataOutput> Get_Monthly_Worker_Tax_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Monthly_Worker_Tax_Filing_Data_RequestType Get_Monthly_Worker_Tax_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_Monthly_Worker_Tax_Filing_DataAsync(new Get_Monthly_Worker_Tax_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Monthly_Worker_Tax_Filing_Data_Request = Get_Monthly_Worker_Tax_Filing_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Successor_EmployersOutput PayrollPort.Get_Successor_Employers(Get_Successor_EmployersInput request)
		{
			return base.Channel.Get_Successor_Employers(request);
		}

		public Get_Successor_Employers_ResponseType Get_Successor_Employers(Workday_Common_HeaderType Workday_Common_Header, Get_Successor_Employers_RequestType Get_Successor_Employers_Request)
		{
			return ((PayrollPort)this).Get_Successor_Employers(new Get_Successor_EmployersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Successor_Employers_Request = Get_Successor_Employers_Request
			}).Get_Successor_Employers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Successor_EmployersOutput> PayrollPort.Get_Successor_EmployersAsync(Get_Successor_EmployersInput request)
		{
			return base.Channel.Get_Successor_EmployersAsync(request);
		}

		public Task<Get_Successor_EmployersOutput> Get_Successor_EmployersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Successor_Employers_RequestType Get_Successor_Employers_Request)
		{
			return ((PayrollPort)this).Get_Successor_EmployersAsync(new Get_Successor_EmployersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Successor_Employers_Request = Get_Successor_Employers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Successor_EmployerOutput PayrollPort.Put_Successor_Employer(Put_Successor_EmployerInput request)
		{
			return base.Channel.Put_Successor_Employer(request);
		}

		public Put_Successor_Employer_ResponseType Put_Successor_Employer(Workday_Common_HeaderType Workday_Common_Header, Put_Successor_Employer_RequestType Put_Successor_Employer_Request)
		{
			return ((PayrollPort)this).Put_Successor_Employer(new Put_Successor_EmployerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Successor_Employer_Request = Put_Successor_Employer_Request
			}).Put_Successor_Employer_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Successor_EmployerOutput> PayrollPort.Put_Successor_EmployerAsync(Put_Successor_EmployerInput request)
		{
			return base.Channel.Put_Successor_EmployerAsync(request);
		}

		public Task<Put_Successor_EmployerOutput> Put_Successor_EmployerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Successor_Employer_RequestType Put_Successor_Employer_Request)
		{
			return ((PayrollPort)this).Put_Successor_EmployerAsync(new Put_Successor_EmployerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Successor_Employer_Request = Put_Successor_Employer_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_ROE_Prior_Period_History_ResultsOutput PayrollPort.Put_Payroll_ROE_Prior_Period_History_Results(Put_Payroll_ROE_Prior_Period_History_ResultsInput request)
		{
			return base.Channel.Put_Payroll_ROE_Prior_Period_History_Results(request);
		}

		public Put_Payroll_ROE_Prior_Period_History_Results_ResponseType Put_Payroll_ROE_Prior_Period_History_Results(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_ROE_Prior_Period_History_Results_RequestType Put_Payroll_ROE_Prior_Period_History_Results_Request)
		{
			return ((PayrollPort)this).Put_Payroll_ROE_Prior_Period_History_Results(new Put_Payroll_ROE_Prior_Period_History_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_ROE_Prior_Period_History_Results_Request = Put_Payroll_ROE_Prior_Period_History_Results_Request
			}).Put_Payroll_ROE_Prior_Period_History_Results_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_ROE_Prior_Period_History_ResultsOutput> PayrollPort.Put_Payroll_ROE_Prior_Period_History_ResultsAsync(Put_Payroll_ROE_Prior_Period_History_ResultsInput request)
		{
			return base.Channel.Put_Payroll_ROE_Prior_Period_History_ResultsAsync(request);
		}

		public Task<Put_Payroll_ROE_Prior_Period_History_ResultsOutput> Put_Payroll_ROE_Prior_Period_History_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_ROE_Prior_Period_History_Results_RequestType Put_Payroll_ROE_Prior_Period_History_Results_Request)
		{
			return ((PayrollPort)this).Put_Payroll_ROE_Prior_Period_History_ResultsAsync(new Put_Payroll_ROE_Prior_Period_History_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_ROE_Prior_Period_History_Results_Request = Put_Payroll_ROE_Prior_Period_History_Results_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_FUTAOutput PayrollPort.Put_Payroll_Payee_FUTA(Put_Payroll_Payee_FUTAInput request)
		{
			return base.Channel.Put_Payroll_Payee_FUTA(request);
		}

		public Put_Payroll_Payee_FUTA_ResponseType Put_Payroll_Payee_FUTA(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_FUTA_RequestType Put_Payroll_Payee_FUTA_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_FUTA(new Put_Payroll_Payee_FUTAInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_FUTA_Request = Put_Payroll_Payee_FUTA_Request
			}).Put_Payroll_Payee_FUTA_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_FUTAOutput> PayrollPort.Put_Payroll_Payee_FUTAAsync(Put_Payroll_Payee_FUTAInput request)
		{
			return base.Channel.Put_Payroll_Payee_FUTAAsync(request);
		}

		public Task<Put_Payroll_Payee_FUTAOutput> Put_Payroll_Payee_FUTAAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_FUTA_RequestType Put_Payroll_Payee_FUTA_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_FUTAAsync(new Put_Payroll_Payee_FUTAInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_FUTA_Request = Put_Payroll_Payee_FUTA_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_FUTAsOutput PayrollPort.Get_Payroll_Payee_FUTAs(Get_Payroll_Payee_FUTAsInput request)
		{
			return base.Channel.Get_Payroll_Payee_FUTAs(request);
		}

		public Get_Payroll_Payee_FUTAs_ResponseType Get_Payroll_Payee_FUTAs(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_FUTAs_RequestType Get_Payroll_Payee_FUTAs_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_FUTAs(new Get_Payroll_Payee_FUTAsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_FUTAs_Request = Get_Payroll_Payee_FUTAs_Request
			}).Get_Payroll_Payee_FUTAs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_FUTAsOutput> PayrollPort.Get_Payroll_Payee_FUTAsAsync(Get_Payroll_Payee_FUTAsInput request)
		{
			return base.Channel.Get_Payroll_Payee_FUTAsAsync(request);
		}

		public Task<Get_Payroll_Payee_FUTAsOutput> Get_Payroll_Payee_FUTAsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_FUTAs_RequestType Get_Payroll_Payee_FUTAs_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_FUTAsAsync(new Get_Payroll_Payee_FUTAsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_FUTAs_Request = Get_Payroll_Payee_FUTAs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Deduction_RecipientsOutput PayrollPort.Get_Payroll_Deduction_Recipients(Get_Payroll_Deduction_RecipientsInput request)
		{
			return base.Channel.Get_Payroll_Deduction_Recipients(request);
		}

		public Get_Payroll_Deduction_Recipients_ResponseType Get_Payroll_Deduction_Recipients(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Deduction_Recipients_RequestType Get_Payroll_Deduction_Recipients_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Deduction_Recipients(new Get_Payroll_Deduction_RecipientsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Deduction_Recipients_Request = Get_Payroll_Deduction_Recipients_Request
			}).Get_Payroll_Deduction_Recipients_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Deduction_RecipientsOutput> PayrollPort.Get_Payroll_Deduction_RecipientsAsync(Get_Payroll_Deduction_RecipientsInput request)
		{
			return base.Channel.Get_Payroll_Deduction_RecipientsAsync(request);
		}

		public Task<Get_Payroll_Deduction_RecipientsOutput> Get_Payroll_Deduction_RecipientsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Deduction_Recipients_RequestType Get_Payroll_Deduction_Recipients_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Deduction_RecipientsAsync(new Get_Payroll_Deduction_RecipientsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Deduction_Recipients_Request = Get_Payroll_Deduction_Recipients_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Deduction_RecipientOutput PayrollPort.Put_Payroll_Deduction_Recipient(Put_Payroll_Deduction_RecipientInput request)
		{
			return base.Channel.Put_Payroll_Deduction_Recipient(request);
		}

		public Put_Payroll_Deduction_Recipient_ResponseType Put_Payroll_Deduction_Recipient(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Deduction_Recipient_RequestType Put_Payroll_Deduction_Recipient_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Deduction_Recipient(new Put_Payroll_Deduction_RecipientInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Deduction_Recipient_Request = Put_Payroll_Deduction_Recipient_Request
			}).Put_Payroll_Deduction_Recipient_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Deduction_RecipientOutput> PayrollPort.Put_Payroll_Deduction_RecipientAsync(Put_Payroll_Deduction_RecipientInput request)
		{
			return base.Channel.Put_Payroll_Deduction_RecipientAsync(request);
		}

		public Task<Put_Payroll_Deduction_RecipientOutput> Put_Payroll_Deduction_RecipientAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Deduction_Recipient_RequestType Put_Payroll_Deduction_Recipient_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Deduction_RecipientAsync(new Put_Payroll_Deduction_RecipientInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Deduction_Recipient_Request = Put_Payroll_Deduction_Recipient_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Paycheck_DeliveriesOutput PayrollPort.Get_Paycheck_Deliveries(Get_Paycheck_DeliveriesInput request)
		{
			return base.Channel.Get_Paycheck_Deliveries(request);
		}

		public Get_Paycheck_Deliveries_ResponseType Get_Paycheck_Deliveries(Workday_Common_HeaderType Workday_Common_Header, Get_Paycheck_Deliveries_RequestType Get_Paycheck_Deliveries_Request)
		{
			return ((PayrollPort)this).Get_Paycheck_Deliveries(new Get_Paycheck_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Paycheck_Deliveries_Request = Get_Paycheck_Deliveries_Request
			}).Get_Paycheck_Deliveries_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Paycheck_DeliveriesOutput> PayrollPort.Get_Paycheck_DeliveriesAsync(Get_Paycheck_DeliveriesInput request)
		{
			return base.Channel.Get_Paycheck_DeliveriesAsync(request);
		}

		public Task<Get_Paycheck_DeliveriesOutput> Get_Paycheck_DeliveriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Paycheck_Deliveries_RequestType Get_Paycheck_Deliveries_Request)
		{
			return ((PayrollPort)this).Get_Paycheck_DeliveriesAsync(new Get_Paycheck_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Paycheck_Deliveries_Request = Get_Paycheck_Deliveries_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Paycheck_Delivery__Public_Output PayrollPort.Put_Paycheck_Delivery__Public_(Put_Paycheck_Delivery__Public_Input request)
		{
			return base.Channel.Put_Paycheck_Delivery__Public_(request);
		}

		public Put_Paycheck_Delivery__Public__ResponseType Put_Paycheck_Delivery__Public_(Workday_Common_HeaderType Workday_Common_Header, Put_Paycheck_Delivery__Public__RequestType Put_Paycheck_Delivery__Public__Request)
		{
			return ((PayrollPort)this).Put_Paycheck_Delivery__Public_(new Put_Paycheck_Delivery__Public_Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Paycheck_Delivery__Public__Request = Put_Paycheck_Delivery__Public__Request
			}).Put_Paycheck_Delivery__Public__Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Paycheck_Delivery__Public_Output> PayrollPort.Put_Paycheck_Delivery__Public_Async(Put_Paycheck_Delivery__Public_Input request)
		{
			return base.Channel.Put_Paycheck_Delivery__Public_Async(request);
		}

		public Task<Put_Paycheck_Delivery__Public_Output> Put_Paycheck_Delivery__Public_Async(Workday_Common_HeaderType Workday_Common_Header, Put_Paycheck_Delivery__Public__RequestType Put_Paycheck_Delivery__Public__Request)
		{
			return ((PayrollPort)this).Put_Paycheck_Delivery__Public_Async(new Put_Paycheck_Delivery__Public_Input
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Paycheck_Delivery__Public__Request = Put_Paycheck_Delivery__Public__Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Single_Legal_EntityOutput PayrollPort.Put_Single_Legal_Entity(Put_Single_Legal_EntityInput request)
		{
			return base.Channel.Put_Single_Legal_Entity(request);
		}

		public Put_Single_Legal_Entity_ResponseType Put_Single_Legal_Entity(Workday_Common_HeaderType Workday_Common_Header, Put_Single_Legal_Entity_RequestType Put_Single_Legal_Entity_Request)
		{
			return ((PayrollPort)this).Put_Single_Legal_Entity(new Put_Single_Legal_EntityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Single_Legal_Entity_Request = Put_Single_Legal_Entity_Request
			}).Put_Single_Legal_Entity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Single_Legal_EntityOutput> PayrollPort.Put_Single_Legal_EntityAsync(Put_Single_Legal_EntityInput request)
		{
			return base.Channel.Put_Single_Legal_EntityAsync(request);
		}

		public Task<Put_Single_Legal_EntityOutput> Put_Single_Legal_EntityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Single_Legal_Entity_RequestType Put_Single_Legal_Entity_Request)
		{
			return ((PayrollPort)this).Put_Single_Legal_EntityAsync(new Put_Single_Legal_EntityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Single_Legal_Entity_Request = Put_Single_Legal_Entity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Single_Legal_EntitiesOutput PayrollPort.Get_Single_Legal_Entities(Get_Single_Legal_EntitiesInput request)
		{
			return base.Channel.Get_Single_Legal_Entities(request);
		}

		public Get_Single_Legal_Entities_ResponseType Get_Single_Legal_Entities(Workday_Common_HeaderType Workday_Common_Header, Get_Single_Legal_Entities_RequestType Get_Single_Legal_Entities_Request)
		{
			return ((PayrollPort)this).Get_Single_Legal_Entities(new Get_Single_Legal_EntitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Single_Legal_Entities_Request = Get_Single_Legal_Entities_Request
			}).Get_Single_Legal_Entities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Single_Legal_EntitiesOutput> PayrollPort.Get_Single_Legal_EntitiesAsync(Get_Single_Legal_EntitiesInput request)
		{
			return base.Channel.Get_Single_Legal_EntitiesAsync(request);
		}

		public Task<Get_Single_Legal_EntitiesOutput> Get_Single_Legal_EntitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Single_Legal_Entities_RequestType Get_Single_Legal_Entities_Request)
		{
			return ((PayrollPort)this).Get_Single_Legal_EntitiesAsync(new Get_Single_Legal_EntitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Single_Legal_Entities_Request = Get_Single_Legal_Entities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_W2_W2C_Printing_ElectionOutput PayrollPort.Get_W2_W2C_Printing_Election(Get_W2_W2C_Printing_ElectionInput request)
		{
			return base.Channel.Get_W2_W2C_Printing_Election(request);
		}

		public Get_W2_W2C_Printing_Election_ResponseType Get_W2_W2C_Printing_Election(Workday_Common_HeaderType Workday_Common_Header, Get_W2_W2C_Printing_Election_RequestType Get_W2_W2C_Printing_Election_Request)
		{
			return ((PayrollPort)this).Get_W2_W2C_Printing_Election(new Get_W2_W2C_Printing_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_W2_W2C_Printing_Election_Request = Get_W2_W2C_Printing_Election_Request
			}).Get_W2_W2C_Printing_Election_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_W2_W2C_Printing_ElectionOutput> PayrollPort.Get_W2_W2C_Printing_ElectionAsync(Get_W2_W2C_Printing_ElectionInput request)
		{
			return base.Channel.Get_W2_W2C_Printing_ElectionAsync(request);
		}

		public Task<Get_W2_W2C_Printing_ElectionOutput> Get_W2_W2C_Printing_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Get_W2_W2C_Printing_Election_RequestType Get_W2_W2C_Printing_Election_Request)
		{
			return ((PayrollPort)this).Get_W2_W2C_Printing_ElectionAsync(new Get_W2_W2C_Printing_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_W2_W2C_Printing_Election_Request = Get_W2_W2C_Printing_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_W2_W2C_Printing_ElectionOutput PayrollPort.Put_W2_W2C_Printing_Election(Put_W2_W2C_Printing_ElectionInput request)
		{
			return base.Channel.Put_W2_W2C_Printing_Election(request);
		}

		public Put_W2_W2C_Printing_Election_for_Worker_ResponseType Put_W2_W2C_Printing_Election(Workday_Common_HeaderType Workday_Common_Header, Put_W2_W2C_Printing_Election_RequestType Put_W2_W2C_Printing_Election_Request)
		{
			return ((PayrollPort)this).Put_W2_W2C_Printing_Election(new Put_W2_W2C_Printing_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_W2_W2C_Printing_Election_Request = Put_W2_W2C_Printing_Election_Request
			}).Put_W2_W2C_Printing_Election_for_Worker_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_W2_W2C_Printing_ElectionOutput> PayrollPort.Put_W2_W2C_Printing_ElectionAsync(Put_W2_W2C_Printing_ElectionInput request)
		{
			return base.Channel.Put_W2_W2C_Printing_ElectionAsync(request);
		}

		public Task<Put_W2_W2C_Printing_ElectionOutput> Put_W2_W2C_Printing_ElectionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_W2_W2C_Printing_Election_RequestType Put_W2_W2C_Printing_Election_Request)
		{
			return ((PayrollPort)this).Put_W2_W2C_Printing_ElectionAsync(new Put_W2_W2C_Printing_ElectionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_W2_W2C_Printing_Election_Request = Put_W2_W2C_Printing_Election_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_Levy_Deduction_RestrictionsOutput PayrollPort.Get_Tax_Levy_Deduction_Restrictions(Get_Tax_Levy_Deduction_RestrictionsInput request)
		{
			return base.Channel.Get_Tax_Levy_Deduction_Restrictions(request);
		}

		public Get_Tax_Levy_Deduction_Restrictions_ResponseType Get_Tax_Levy_Deduction_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Levy_Deduction_Restrictions_RequestType Get_Tax_Levy_Deduction_Restrictions_Request)
		{
			return ((PayrollPort)this).Get_Tax_Levy_Deduction_Restrictions(new Get_Tax_Levy_Deduction_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Levy_Deduction_Restrictions_Request = Get_Tax_Levy_Deduction_Restrictions_Request
			}).Get_Tax_Levy_Deduction_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_Levy_Deduction_RestrictionsOutput> PayrollPort.Get_Tax_Levy_Deduction_RestrictionsAsync(Get_Tax_Levy_Deduction_RestrictionsInput request)
		{
			return base.Channel.Get_Tax_Levy_Deduction_RestrictionsAsync(request);
		}

		public Task<Get_Tax_Levy_Deduction_RestrictionsOutput> Get_Tax_Levy_Deduction_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Levy_Deduction_Restrictions_RequestType Get_Tax_Levy_Deduction_Restrictions_Request)
		{
			return ((PayrollPort)this).Get_Tax_Levy_Deduction_RestrictionsAsync(new Get_Tax_Levy_Deduction_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Levy_Deduction_Restrictions_Request = Get_Tax_Levy_Deduction_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_Levy_Deduction_RestrictionOutput PayrollPort.Put_Tax_Levy_Deduction_Restriction(Put_Tax_Levy_Deduction_RestrictionInput request)
		{
			return base.Channel.Put_Tax_Levy_Deduction_Restriction(request);
		}

		public Put_Tax_Levy_Deduction_Restriction_ResponseType Put_Tax_Levy_Deduction_Restriction(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Levy_Deduction_Restriction_RequestType Put_Tax_Levy_Deduction_Restriction_Request)
		{
			return ((PayrollPort)this).Put_Tax_Levy_Deduction_Restriction(new Put_Tax_Levy_Deduction_RestrictionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Levy_Deduction_Restriction_Request = Put_Tax_Levy_Deduction_Restriction_Request
			}).Put_Tax_Levy_Deduction_Restriction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_Levy_Deduction_RestrictionOutput> PayrollPort.Put_Tax_Levy_Deduction_RestrictionAsync(Put_Tax_Levy_Deduction_RestrictionInput request)
		{
			return base.Channel.Put_Tax_Levy_Deduction_RestrictionAsync(request);
		}

		public Task<Put_Tax_Levy_Deduction_RestrictionOutput> Put_Tax_Levy_Deduction_RestrictionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Levy_Deduction_Restriction_RequestType Put_Tax_Levy_Deduction_Restriction_Request)
		{
			return ((PayrollPort)this).Put_Tax_Levy_Deduction_RestrictionAsync(new Put_Tax_Levy_Deduction_RestrictionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Levy_Deduction_Restriction_Request = Put_Tax_Levy_Deduction_Restriction_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Tax_Document_DeliveryOutput PayrollPort.Put_Tax_Document_Delivery(Put_Tax_Document_DeliveryInput request)
		{
			return base.Channel.Put_Tax_Document_Delivery(request);
		}

		public Put_Tax_Document_Delivery_ResponseType Put_Tax_Document_Delivery(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Document_Delivery_RequestType Put_Tax_Document_Delivery_Request)
		{
			return ((PayrollPort)this).Put_Tax_Document_Delivery(new Put_Tax_Document_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Document_Delivery_Request = Put_Tax_Document_Delivery_Request
			}).Put_Tax_Document_Delivery_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Tax_Document_DeliveryOutput> PayrollPort.Put_Tax_Document_DeliveryAsync(Put_Tax_Document_DeliveryInput request)
		{
			return base.Channel.Put_Tax_Document_DeliveryAsync(request);
		}

		public Task<Put_Tax_Document_DeliveryOutput> Put_Tax_Document_DeliveryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Document_Delivery_RequestType Put_Tax_Document_Delivery_Request)
		{
			return ((PayrollPort)this).Put_Tax_Document_DeliveryAsync(new Put_Tax_Document_DeliveryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Tax_Document_Delivery_Request = Put_Tax_Document_Delivery_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Tax_Document_DeliveriesOutput PayrollPort.Get_Tax_Document_Deliveries(Get_Tax_Document_DeliveriesInput request)
		{
			return base.Channel.Get_Tax_Document_Deliveries(request);
		}

		public Get_Tax_Document_Deliveries_ResponseType Get_Tax_Document_Deliveries(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Document_Deliveries_RequestType Get_Tax_Document_Deliveries_Request)
		{
			return ((PayrollPort)this).Get_Tax_Document_Deliveries(new Get_Tax_Document_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Document_Deliveries_Request = Get_Tax_Document_Deliveries_Request
			}).Get_Tax_Document_Deliveries_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Tax_Document_DeliveriesOutput> PayrollPort.Get_Tax_Document_DeliveriesAsync(Get_Tax_Document_DeliveriesInput request)
		{
			return base.Channel.Get_Tax_Document_DeliveriesAsync(request);
		}

		public Task<Get_Tax_Document_DeliveriesOutput> Get_Tax_Document_DeliveriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Document_Deliveries_RequestType Get_Tax_Document_Deliveries_Request)
		{
			return ((PayrollPort)this).Get_Tax_Document_DeliveriesAsync(new Get_Tax_Document_DeliveriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Tax_Document_Deliveries_Request = Get_Tax_Document_Deliveries_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Periodic_Company_CAN_Tax_Remittance_DataOutput PayrollPort.Get_Periodic_Company_CAN_Tax_Remittance_Data(Get_Periodic_Company_CAN_Tax_Remittance_DataInput request)
		{
			return base.Channel.Get_Periodic_Company_CAN_Tax_Remittance_Data(request);
		}

		public Get_Periodic_Company_CAN_Tax_Remittance_Data_ResponseType Get_Periodic_Company_CAN_Tax_Remittance_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Company_CAN_Tax_Remittance_Data_RequestType Get_Periodic_Company_CAN_Tax_Remittance_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Company_CAN_Tax_Remittance_Data(new Get_Periodic_Company_CAN_Tax_Remittance_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Company_CAN_Tax_Remittance_Data_Request = Get_Periodic_Company_CAN_Tax_Remittance_Data_Request
			}).Get_Periodic_Company_CAN_Tax_Remittance_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Periodic_Company_CAN_Tax_Remittance_DataOutput> PayrollPort.Get_Periodic_Company_CAN_Tax_Remittance_DataAsync(Get_Periodic_Company_CAN_Tax_Remittance_DataInput request)
		{
			return base.Channel.Get_Periodic_Company_CAN_Tax_Remittance_DataAsync(request);
		}

		public Task<Get_Periodic_Company_CAN_Tax_Remittance_DataOutput> Get_Periodic_Company_CAN_Tax_Remittance_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Periodic_Company_CAN_Tax_Remittance_Data_RequestType Get_Periodic_Company_CAN_Tax_Remittance_Data_Request)
		{
			return ((PayrollPort)this).Get_Periodic_Company_CAN_Tax_Remittance_DataAsync(new Get_Periodic_Company_CAN_Tax_Remittance_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Periodic_Company_CAN_Tax_Remittance_Data_Request = Get_Periodic_Company_CAN_Tax_Remittance_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Withholding_Order_Local_Minimum_Wage_RateOutput PayrollPort.Put_Withholding_Order_Local_Minimum_Wage_Rate(Put_Withholding_Order_Local_Minimum_Wage_RateInput request)
		{
			return base.Channel.Put_Withholding_Order_Local_Minimum_Wage_Rate(request);
		}

		public Put_Withholding_Order_Local_Minimum_Wage_Rate_ResponseType Put_Withholding_Order_Local_Minimum_Wage_Rate(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Put_Withholding_Order_Local_Minimum_Wage_Rate_Request)
		{
			return ((PayrollPort)this).Put_Withholding_Order_Local_Minimum_Wage_Rate(new Put_Withholding_Order_Local_Minimum_Wage_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Order_Local_Minimum_Wage_Rate_Request = Put_Withholding_Order_Local_Minimum_Wage_Rate_Request
			}).Put_Withholding_Order_Local_Minimum_Wage_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Withholding_Order_Local_Minimum_Wage_RateOutput> PayrollPort.Put_Withholding_Order_Local_Minimum_Wage_RateAsync(Put_Withholding_Order_Local_Minimum_Wage_RateInput request)
		{
			return base.Channel.Put_Withholding_Order_Local_Minimum_Wage_RateAsync(request);
		}

		public Task<Put_Withholding_Order_Local_Minimum_Wage_RateOutput> Put_Withholding_Order_Local_Minimum_Wage_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Put_Withholding_Order_Local_Minimum_Wage_Rate_Request)
		{
			return ((PayrollPort)this).Put_Withholding_Order_Local_Minimum_Wage_RateAsync(new Put_Withholding_Order_Local_Minimum_Wage_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Withholding_Order_Local_Minimum_Wage_Rate_Request = Put_Withholding_Order_Local_Minimum_Wage_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Withholding_Order_Local_Minimum_Wage_RateOutput PayrollPort.Get_Withholding_Order_Local_Minimum_Wage_Rate(Get_Withholding_Order_Local_Minimum_Wage_RateInput request)
		{
			return base.Channel.Get_Withholding_Order_Local_Minimum_Wage_Rate(request);
		}

		public Get_Withholding_Order_Local_Minimum_Wage_Rate_ResponseType Get_Withholding_Order_Local_Minimum_Wage_Rate(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Get_Withholding_Order_Local_Minimum_Wage_Rate_Request)
		{
			return ((PayrollPort)this).Get_Withholding_Order_Local_Minimum_Wage_Rate(new Get_Withholding_Order_Local_Minimum_Wage_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Order_Local_Minimum_Wage_Rate_Request = Get_Withholding_Order_Local_Minimum_Wage_Rate_Request
			}).Get_Withholding_Order_Local_Minimum_Wage_Rate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Withholding_Order_Local_Minimum_Wage_RateOutput> PayrollPort.Get_Withholding_Order_Local_Minimum_Wage_RateAsync(Get_Withholding_Order_Local_Minimum_Wage_RateInput request)
		{
			return base.Channel.Get_Withholding_Order_Local_Minimum_Wage_RateAsync(request);
		}

		public Task<Get_Withholding_Order_Local_Minimum_Wage_RateOutput> Get_Withholding_Order_Local_Minimum_Wage_RateAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Get_Withholding_Order_Local_Minimum_Wage_Rate_Request)
		{
			return ((PayrollPort)this).Get_Withholding_Order_Local_Minimum_Wage_RateAsync(new Get_Withholding_Order_Local_Minimum_Wage_RateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Withholding_Order_Local_Minimum_Wage_Rate_Request = Get_Withholding_Order_Local_Minimum_Wage_Rate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Tax_Mappings_on_LocationOutput PayrollPort.Get_Payroll_Tax_Mappings_on_Location(Get_Payroll_Tax_Mappings_on_LocationInput request)
		{
			return base.Channel.Get_Payroll_Tax_Mappings_on_Location(request);
		}

		public Get_Payroll_Tax_Mappings_on_Location_ResponseType Get_Payroll_Tax_Mappings_on_Location(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Tax_Mappings_on_Location_RequestType Get_Payroll_Tax_Mappings_on_Location_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Tax_Mappings_on_Location(new Get_Payroll_Tax_Mappings_on_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Tax_Mappings_on_Location_Request = Get_Payroll_Tax_Mappings_on_Location_Request
			}).Get_Payroll_Tax_Mappings_on_Location_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Tax_Mappings_on_LocationOutput> PayrollPort.Get_Payroll_Tax_Mappings_on_LocationAsync(Get_Payroll_Tax_Mappings_on_LocationInput request)
		{
			return base.Channel.Get_Payroll_Tax_Mappings_on_LocationAsync(request);
		}

		public Task<Get_Payroll_Tax_Mappings_on_LocationOutput> Get_Payroll_Tax_Mappings_on_LocationAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Tax_Mappings_on_Location_RequestType Get_Payroll_Tax_Mappings_on_Location_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Tax_Mappings_on_LocationAsync(new Get_Payroll_Tax_Mappings_on_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Tax_Mappings_on_Location_Request = Get_Payroll_Tax_Mappings_on_Location_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Tax_Mapping_on_LocationOutput PayrollPort.Put_Payroll_Tax_Mapping_on_Location(Put_Payroll_Tax_Mapping_on_LocationInput request)
		{
			return base.Channel.Put_Payroll_Tax_Mapping_on_Location(request);
		}

		public Put_Payroll_Tax_Mapping_on_Location_ResponseType Put_Payroll_Tax_Mapping_on_Location(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Tax_Mapping_on_Location_RequestType Put_Payroll_Tax_Mapping_on_Location_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Tax_Mapping_on_Location(new Put_Payroll_Tax_Mapping_on_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Tax_Mapping_on_Location_Request = Put_Payroll_Tax_Mapping_on_Location_Request
			}).Put_Payroll_Tax_Mapping_on_Location_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Tax_Mapping_on_LocationOutput> PayrollPort.Put_Payroll_Tax_Mapping_on_LocationAsync(Put_Payroll_Tax_Mapping_on_LocationInput request)
		{
			return base.Channel.Put_Payroll_Tax_Mapping_on_LocationAsync(request);
		}

		public Task<Put_Payroll_Tax_Mapping_on_LocationOutput> Put_Payroll_Tax_Mapping_on_LocationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Tax_Mapping_on_Location_RequestType Put_Payroll_Tax_Mapping_on_Location_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Tax_Mapping_on_LocationAsync(new Put_Payroll_Tax_Mapping_on_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Tax_Mapping_on_Location_Request = Put_Payroll_Tax_Mapping_on_Location_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Run_Pay_CalculationOutput PayrollPort.Put_Run_Pay_Calculation(Put_Run_Pay_CalculationInput request)
		{
			return base.Channel.Put_Run_Pay_Calculation(request);
		}

		public Put_Run_Pay_Calculation_ResponseType Put_Run_Pay_Calculation(Workday_Common_HeaderType Workday_Common_Header, Put_Run_Pay_Calculation_RequestType Put_Run_Pay_Calculation_Request)
		{
			return ((PayrollPort)this).Put_Run_Pay_Calculation(new Put_Run_Pay_CalculationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Run_Pay_Calculation_Request = Put_Run_Pay_Calculation_Request
			}).Put_Run_Pay_Calculation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Run_Pay_CalculationOutput> PayrollPort.Put_Run_Pay_CalculationAsync(Put_Run_Pay_CalculationInput request)
		{
			return base.Channel.Put_Run_Pay_CalculationAsync(request);
		}

		public Task<Put_Run_Pay_CalculationOutput> Put_Run_Pay_CalculationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Run_Pay_Calculation_RequestType Put_Run_Pay_Calculation_Request)
		{
			return ((PayrollPort)this).Put_Run_Pay_CalculationAsync(new Put_Run_Pay_CalculationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Run_Pay_Calculation_Request = Put_Run_Pay_Calculation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_EFW2_Year_End_Worker_Filing_DataOutput PayrollPort.Get_EFW2_Year_End_Worker_Filing_Data(Get_EFW2_Year_End_Worker_Filing_DataInput request)
		{
			return base.Channel.Get_EFW2_Year_End_Worker_Filing_Data(request);
		}

		public Get_EFW2_Year_End_Worker_Filing_Data_ResponseType Get_EFW2_Year_End_Worker_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_EFW2_Year_End_Worker_Filing_Data_RequestType Get_EFW2_Year_End_Worker_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_EFW2_Year_End_Worker_Filing_Data(new Get_EFW2_Year_End_Worker_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_EFW2_Year_End_Worker_Filing_Data_Request = Get_EFW2_Year_End_Worker_Filing_Data_Request
			}).Get_EFW2_Year_End_Worker_Filing_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_EFW2_Year_End_Worker_Filing_DataOutput> PayrollPort.Get_EFW2_Year_End_Worker_Filing_DataAsync(Get_EFW2_Year_End_Worker_Filing_DataInput request)
		{
			return base.Channel.Get_EFW2_Year_End_Worker_Filing_DataAsync(request);
		}

		public Task<Get_EFW2_Year_End_Worker_Filing_DataOutput> Get_EFW2_Year_End_Worker_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_EFW2_Year_End_Worker_Filing_Data_RequestType Get_EFW2_Year_End_Worker_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_EFW2_Year_End_Worker_Filing_DataAsync(new Get_EFW2_Year_End_Worker_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_EFW2_Year_End_Worker_Filing_Data_Request = Get_EFW2_Year_End_Worker_Filing_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_PrePrinted_PayslipsOutput PayrollPort.Get_Payroll_PrePrinted_Payslips(Get_Payroll_PrePrinted_PayslipsInput request)
		{
			return base.Channel.Get_Payroll_PrePrinted_Payslips(request);
		}

		public Get_Payroll_PrePrinted_Payslips_ResponseType Get_Payroll_PrePrinted_Payslips(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_PrePrinted_Payslips_RequestType Get_Payroll_PrePrinted_Payslips_Request)
		{
			return ((PayrollPort)this).Get_Payroll_PrePrinted_Payslips(new Get_Payroll_PrePrinted_PayslipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_PrePrinted_Payslips_Request = Get_Payroll_PrePrinted_Payslips_Request
			}).Get_Payroll_PrePrinted_Payslips_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_PrePrinted_PayslipsOutput> PayrollPort.Get_Payroll_PrePrinted_PayslipsAsync(Get_Payroll_PrePrinted_PayslipsInput request)
		{
			return base.Channel.Get_Payroll_PrePrinted_PayslipsAsync(request);
		}

		public Task<Get_Payroll_PrePrinted_PayslipsOutput> Get_Payroll_PrePrinted_PayslipsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_PrePrinted_Payslips_RequestType Get_Payroll_PrePrinted_Payslips_Request)
		{
			return ((PayrollPort)this).Get_Payroll_PrePrinted_PayslipsAsync(new Get_Payroll_PrePrinted_PayslipsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_PrePrinted_Payslips_Request = Get_Payroll_PrePrinted_Payslips_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_EFW2_Year_End_Employer_Filing_DataOutput PayrollPort.Get_EFW2_Year_End_Employer_Filing_Data(Get_EFW2_Year_End_Employer_Filing_DataInput request)
		{
			return base.Channel.Get_EFW2_Year_End_Employer_Filing_Data(request);
		}

		public Get_EFW2_Year_End_Employer_Filing_Data_ResponseType Get_EFW2_Year_End_Employer_Filing_Data(Workday_Common_HeaderType Workday_Common_Header, Get_EFW2_Year_End_Employer_Filing_Data_RequestType Get_EFW2_Year_End_Employer_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_EFW2_Year_End_Employer_Filing_Data(new Get_EFW2_Year_End_Employer_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_EFW2_Year_End_Employer_Filing_Data_Request = Get_EFW2_Year_End_Employer_Filing_Data_Request
			}).Get_EFW2_Year_End_Employer_Filing_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_EFW2_Year_End_Employer_Filing_DataOutput> PayrollPort.Get_EFW2_Year_End_Employer_Filing_DataAsync(Get_EFW2_Year_End_Employer_Filing_DataInput request)
		{
			return base.Channel.Get_EFW2_Year_End_Employer_Filing_DataAsync(request);
		}

		public Task<Get_EFW2_Year_End_Employer_Filing_DataOutput> Get_EFW2_Year_End_Employer_Filing_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_EFW2_Year_End_Employer_Filing_Data_RequestType Get_EFW2_Year_End_Employer_Filing_Data_Request)
		{
			return ((PayrollPort)this).Get_EFW2_Year_End_Employer_Filing_DataAsync(new Get_EFW2_Year_End_Employer_Filing_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_EFW2_Year_End_Employer_Filing_Data_Request = Get_EFW2_Year_End_Employer_Filing_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Run_Pay_CalculationOutput PayrollPort.Get_Run_Pay_Calculation(Get_Run_Pay_CalculationInput request)
		{
			return base.Channel.Get_Run_Pay_Calculation(request);
		}

		public Get_Run_Pay_Calculation_ResponseType Get_Run_Pay_Calculation(Workday_Common_HeaderType Workday_Common_Header, Get_Run_Pay_Calculation_RequestType Get_Run_Pay_Calculation_Request)
		{
			return ((PayrollPort)this).Get_Run_Pay_Calculation(new Get_Run_Pay_CalculationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Run_Pay_Calculation_Request = Get_Run_Pay_Calculation_Request
			}).Get_Run_Pay_Calculation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Run_Pay_CalculationOutput> PayrollPort.Get_Run_Pay_CalculationAsync(Get_Run_Pay_CalculationInput request)
		{
			return base.Channel.Get_Run_Pay_CalculationAsync(request);
		}

		public Task<Get_Run_Pay_CalculationOutput> Get_Run_Pay_CalculationAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Run_Pay_Calculation_RequestType Get_Run_Pay_Calculation_Request)
		{
			return ((PayrollPort)this).Get_Run_Pay_CalculationAsync(new Get_Run_Pay_CalculationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Run_Pay_Calculation_Request = Get_Run_Pay_Calculation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Payroll_Payee_Tax_Location_MappingsOutput PayrollPort.Get_Payroll_Payee_Tax_Location_Mappings(Get_Payroll_Payee_Tax_Location_MappingsInput request)
		{
			return base.Channel.Get_Payroll_Payee_Tax_Location_Mappings(request);
		}

		public Get_Payroll_Payee_Tax_Location_Mappings_ResponseType Get_Payroll_Payee_Tax_Location_Mappings(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Tax_Location_Mappings_RequestType Get_Payroll_Payee_Tax_Location_Mappings_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_Tax_Location_Mappings(new Get_Payroll_Payee_Tax_Location_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Tax_Location_Mappings_Request = Get_Payroll_Payee_Tax_Location_Mappings_Request
			}).Get_Payroll_Payee_Tax_Location_Mappings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Payroll_Payee_Tax_Location_MappingsOutput> PayrollPort.Get_Payroll_Payee_Tax_Location_MappingsAsync(Get_Payroll_Payee_Tax_Location_MappingsInput request)
		{
			return base.Channel.Get_Payroll_Payee_Tax_Location_MappingsAsync(request);
		}

		public Task<Get_Payroll_Payee_Tax_Location_MappingsOutput> Get_Payroll_Payee_Tax_Location_MappingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_Payee_Tax_Location_Mappings_RequestType Get_Payroll_Payee_Tax_Location_Mappings_Request)
		{
			return ((PayrollPort)this).Get_Payroll_Payee_Tax_Location_MappingsAsync(new Get_Payroll_Payee_Tax_Location_MappingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payroll_Payee_Tax_Location_Mappings_Request = Get_Payroll_Payee_Tax_Location_Mappings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Payroll_Payee_Tax_Location_MappingOutput PayrollPort.Put_Payroll_Payee_Tax_Location_Mapping(Put_Payroll_Payee_Tax_Location_MappingInput request)
		{
			return base.Channel.Put_Payroll_Payee_Tax_Location_Mapping(request);
		}

		public Put_Payroll_Payee_Tax_Location_Mapping_ResponseType Put_Payroll_Payee_Tax_Location_Mapping(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Tax_Location_Mapping_RequestType Put_Payroll_Payee_Tax_Location_Mapping_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_Tax_Location_Mapping(new Put_Payroll_Payee_Tax_Location_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Tax_Location_Mapping_Request = Put_Payroll_Payee_Tax_Location_Mapping_Request
			}).Put_Payroll_Payee_Tax_Location_Mapping_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Payroll_Payee_Tax_Location_MappingOutput> PayrollPort.Put_Payroll_Payee_Tax_Location_MappingAsync(Put_Payroll_Payee_Tax_Location_MappingInput request)
		{
			return base.Channel.Put_Payroll_Payee_Tax_Location_MappingAsync(request);
		}

		public Task<Put_Payroll_Payee_Tax_Location_MappingOutput> Put_Payroll_Payee_Tax_Location_MappingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Payroll_Payee_Tax_Location_Mapping_RequestType Put_Payroll_Payee_Tax_Location_Mapping_Request)
		{
			return ((PayrollPort)this).Put_Payroll_Payee_Tax_Location_MappingAsync(new Put_Payroll_Payee_Tax_Location_MappingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Payroll_Payee_Tax_Location_Mapping_Request = Put_Payroll_Payee_Tax_Location_Mapping_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Payroll_InputOutput PayrollPort.Import_Payroll_Input(Import_Payroll_InputInput request)
		{
			return base.Channel.Import_Payroll_Input(request);
		}

		public Put_Import_Process_ResponseType Import_Payroll_Input(Workday_Common_HeaderType Workday_Common_Header, Import_Payroll_Input_RequestType Import_Payroll_Input_Request)
		{
			return ((PayrollPort)this).Import_Payroll_Input(new Import_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Payroll_Input_Request = Import_Payroll_Input_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Payroll_InputOutput> PayrollPort.Import_Payroll_InputAsync(Import_Payroll_InputInput request)
		{
			return base.Channel.Import_Payroll_InputAsync(request);
		}

		public Task<Import_Payroll_InputOutput> Import_Payroll_InputAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Payroll_Input_RequestType Import_Payroll_Input_Request)
		{
			return ((PayrollPort)this).Import_Payroll_InputAsync(new Import_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Payroll_Input_Request = Import_Payroll_Input_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Payroll_InputOutput PayrollPort.Import_ROE_Prior_Period_History_Results(Import_ROE_Prior_Period_History_ResultsInput request)
		{
			return base.Channel.Import_ROE_Prior_Period_History_Results(request);
		}

		public Put_Import_Process_ResponseType Import_ROE_Prior_Period_History_Results(Workday_Common_HeaderType Workday_Common_Header, Import_ROE_Prior_Period_History_Results_RequestType Import_ROE_Prior_Period_History_Results_Request)
		{
			return ((PayrollPort)this).Import_ROE_Prior_Period_History_Results(new Import_ROE_Prior_Period_History_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ROE_Prior_Period_History_Results_Request = Import_ROE_Prior_Period_History_Results_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Payroll_InputOutput> PayrollPort.Import_ROE_Prior_Period_History_ResultsAsync(Import_ROE_Prior_Period_History_ResultsInput request)
		{
			return base.Channel.Import_ROE_Prior_Period_History_ResultsAsync(request);
		}

		public Task<Import_Payroll_InputOutput> Import_ROE_Prior_Period_History_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_ROE_Prior_Period_History_Results_RequestType Import_ROE_Prior_Period_History_Results_Request)
		{
			return ((PayrollPort)this).Import_ROE_Prior_Period_History_ResultsAsync(new Import_ROE_Prior_Period_History_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_ROE_Prior_Period_History_Results_Request = Import_ROE_Prior_Period_History_Results_Request
			});
		}
	}
}
