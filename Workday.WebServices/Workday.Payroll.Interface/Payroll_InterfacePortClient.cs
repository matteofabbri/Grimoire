using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Payroll_InterfacePortClient : ClientBase<Payroll_InterfacePort>, Payroll_InterfacePort
	{
		public Payroll_InterfacePortClient()
		{
		}

		public Payroll_InterfacePortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Payroll_InterfacePortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_InterfacePortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Payroll_InterfacePortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PayeesOutput Payroll_InterfacePort.Get_Payees(Get_PayeesInput request)
		{
			return base.Channel.Get_Payees(request);
		}

		public Get_Payees_ResponseType Get_Payees(Workday_Common_HeaderType Workday_Common_Header, Get_Payees_RequestType Get_Payees_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Payees(new Get_PayeesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payees_Request = Get_Payees_Request
			}).Get_Payees_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PayeesOutput> Payroll_InterfacePort.Get_PayeesAsync(Get_PayeesInput request)
		{
			return base.Channel.Get_PayeesAsync(request);
		}

		public Task<Get_PayeesOutput> Get_PayeesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Payees_RequestType Get_Payees_Request)
		{
			return ((Payroll_InterfacePort)this).Get_PayeesAsync(new Get_PayeesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Payees_Request = Get_Payees_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Payroll_InputOutput Payroll_InterfacePort.Put_External_Payroll_Input(Put_External_Payroll_InputInput request)
		{
			return base.Channel.Put_External_Payroll_Input(request);
		}

		public Put_External_Payroll_Input_ResponseType Put_External_Payroll_Input(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Input_RequestType Put_External_Payroll_Input_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_Input(new Put_External_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Input_Request = Put_External_Payroll_Input_Request
			}).Put_External_Payroll_Input_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Payroll_InputOutput> Payroll_InterfacePort.Put_External_Payroll_InputAsync(Put_External_Payroll_InputInput request)
		{
			return base.Channel.Put_External_Payroll_InputAsync(request);
		}

		public Task<Put_External_Payroll_InputOutput> Put_External_Payroll_InputAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Input_RequestType Put_External_Payroll_Input_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_InputAsync(new Put_External_Payroll_InputInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Input_Request = Put_External_Payroll_Input_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_External_Pay_GroupsOutput Payroll_InterfacePort.Get_External_Pay_Groups(Get_External_Pay_GroupsInput request)
		{
			return base.Channel.Get_External_Pay_Groups(request);
		}

		public Get_External_Pay_Groups_ResponseType Get_External_Pay_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_External_Pay_Groups_RequestType Get_External_Pay_Groups_Request)
		{
			return ((Payroll_InterfacePort)this).Get_External_Pay_Groups(new Get_External_Pay_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Pay_Groups_Request = Get_External_Pay_Groups_Request
			}).Get_External_Pay_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_External_Pay_GroupsOutput> Payroll_InterfacePort.Get_External_Pay_GroupsAsync(Get_External_Pay_GroupsInput request)
		{
			return base.Channel.Get_External_Pay_GroupsAsync(request);
		}

		public Task<Get_External_Pay_GroupsOutput> Get_External_Pay_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_External_Pay_Groups_RequestType Get_External_Pay_Groups_Request)
		{
			return ((Payroll_InterfacePort)this).Get_External_Pay_GroupsAsync(new Get_External_Pay_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Pay_Groups_Request = Get_External_Pay_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_BatchesOutput Payroll_InterfacePort.Get_Batches(Get_BatchesInput request)
		{
			return base.Channel.Get_Batches(request);
		}

		public Get_Batches_ResponseType Get_Batches(Workday_Common_HeaderType Workday_Common_Header, Get_Batches_RequestType Get_Batches_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Batches(new Get_BatchesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Batches_Request = Get_Batches_Request
			}).Get_Batches_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_BatchesOutput> Payroll_InterfacePort.Get_BatchesAsync(Get_BatchesInput request)
		{
			return base.Channel.Get_BatchesAsync(request);
		}

		public Task<Get_BatchesOutput> Get_BatchesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Batches_RequestType Get_Batches_Request)
		{
			return ((Payroll_InterfacePort)this).Get_BatchesAsync(new Get_BatchesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Batches_Request = Get_Batches_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_BatchOutput Payroll_InterfacePort.Put_Batch(Put_BatchInput request)
		{
			return base.Channel.Put_Batch(request);
		}

		public Put_Batch_ResponseType Put_Batch(Workday_Common_HeaderType Workday_Common_Header, Put_Batch_RequestType Put_Batch_Request)
		{
			return ((Payroll_InterfacePort)this).Put_Batch(new Put_BatchInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Batch_Request = Put_Batch_Request
			}).Put_Batch_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_BatchOutput> Payroll_InterfacePort.Put_BatchAsync(Put_BatchInput request)
		{
			return base.Channel.Put_BatchAsync(request);
		}

		public Task<Put_BatchOutput> Put_BatchAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Batch_RequestType Put_Batch_Request)
		{
			return ((Payroll_InterfacePort)this).Put_BatchAsync(new Put_BatchInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Batch_Request = Put_Batch_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_External_Payroll_InputsOutput Payroll_InterfacePort.Get_External_Payroll_Inputs(Get_External_Payroll_InputsInput request)
		{
			return base.Channel.Get_External_Payroll_Inputs(request);
		}

		public Get_External_Payroll_Inputs_ResponseType Get_External_Payroll_Inputs(Workday_Common_HeaderType Workday_Common_Header, Get_External_Payroll_Inputs_RequestType Get_External_Payroll_Inputs_Request)
		{
			return ((Payroll_InterfacePort)this).Get_External_Payroll_Inputs(new Get_External_Payroll_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Payroll_Inputs_Request = Get_External_Payroll_Inputs_Request
			}).Get_External_Payroll_Inputs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_External_Payroll_InputsOutput> Payroll_InterfacePort.Get_External_Payroll_InputsAsync(Get_External_Payroll_InputsInput request)
		{
			return base.Channel.Get_External_Payroll_InputsAsync(request);
		}

		public Task<Get_External_Payroll_InputsOutput> Get_External_Payroll_InputsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_External_Payroll_Inputs_RequestType Get_External_Payroll_Inputs_Request)
		{
			return ((Payroll_InterfacePort)this).Get_External_Payroll_InputsAsync(new Get_External_Payroll_InputsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Payroll_Inputs_Request = Get_External_Payroll_Inputs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Payroll_ActualsOutput Payroll_InterfacePort.Put_External_Payroll_Actuals(Put_External_Payroll_ActualsInput request)
		{
			return base.Channel.Put_External_Payroll_Actuals(request);
		}

		public External_Pay_Actual_ResponseType Put_External_Payroll_Actuals(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Actuals_RequestType Put_External_Payroll_Actuals_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_Actuals(new Put_External_Payroll_ActualsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Actuals_Request = Put_External_Payroll_Actuals_Request
			}).External_Pay_Actual_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Payroll_ActualsOutput> Payroll_InterfacePort.Put_External_Payroll_ActualsAsync(Put_External_Payroll_ActualsInput request)
		{
			return base.Channel.Put_External_Payroll_ActualsAsync(request);
		}

		public Task<Put_External_Payroll_ActualsOutput> Put_External_Payroll_ActualsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Actuals_RequestType Put_External_Payroll_Actuals_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_ActualsAsync(new Put_External_Payroll_ActualsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Actuals_Request = Put_External_Payroll_Actuals_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Period_SchedulesOutput Payroll_InterfacePort.Get_Period_Schedules(Get_Period_SchedulesInput request)
		{
			return base.Channel.Get_Period_Schedules(request);
		}

		public Get_Period_Schedules_ResponseType Get_Period_Schedules(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Schedules_RequestType Get_Period_Schedules_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Period_Schedules(new Get_Period_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Schedules_Request = Get_Period_Schedules_Request
			}).Get_Period_Schedules_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Period_SchedulesOutput> Payroll_InterfacePort.Get_Period_SchedulesAsync(Get_Period_SchedulesInput request)
		{
			return base.Channel.Get_Period_SchedulesAsync(request);
		}

		public Task<Get_Period_SchedulesOutput> Get_Period_SchedulesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Schedules_RequestType Get_Period_Schedules_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Period_SchedulesAsync(new Get_Period_SchedulesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Schedules_Request = Get_Period_Schedules_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Period_ScheduleOutput Payroll_InterfacePort.Put_Period_Schedule(Put_Period_ScheduleInput request)
		{
			return base.Channel.Put_Period_Schedule(request);
		}

		public Put_Period_Schedule_ResponseType Put_Period_Schedule(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Schedule_RequestType Put_Period_Schedule_Request)
		{
			return ((Payroll_InterfacePort)this).Put_Period_Schedule(new Put_Period_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Schedule_Request = Put_Period_Schedule_Request
			}).Put_Period_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Period_ScheduleOutput> Payroll_InterfacePort.Put_Period_ScheduleAsync(Put_Period_ScheduleInput request)
		{
			return base.Channel.Put_Period_ScheduleAsync(request);
		}

		public Task<Put_Period_ScheduleOutput> Put_Period_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Schedule_RequestType Put_Period_Schedule_Request)
		{
			return ((Payroll_InterfacePort)this).Put_Period_ScheduleAsync(new Put_Period_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Schedule_Request = Put_Period_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Payroll_ResultsOutput Payroll_InterfacePort.Put_External_Payroll_Results(Put_External_Payroll_ResultsInput request)
		{
			return base.Channel.Put_External_Payroll_Results(request);
		}

		public Put_External_Payroll_Results_ResponseType Put_External_Payroll_Results(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Results_RequestType Put_External_Payroll_Results_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_Results(new Put_External_Payroll_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Results_Request = Put_External_Payroll_Results_Request
			}).Put_External_Payroll_Results_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Payroll_ResultsOutput> Payroll_InterfacePort.Put_External_Payroll_ResultsAsync(Put_External_Payroll_ResultsInput request)
		{
			return base.Channel.Put_External_Payroll_ResultsAsync(request);
		}

		public Task<Put_External_Payroll_ResultsOutput> Put_External_Payroll_ResultsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Payroll_Results_RequestType Put_External_Payroll_Results_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Payroll_ResultsAsync(new Put_External_Payroll_ResultsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Payroll_Results_Request = Put_External_Payroll_Results_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Pay_GroupOutput Payroll_InterfacePort.Put_External_Pay_Group(Put_External_Pay_GroupInput request)
		{
			return base.Channel.Put_External_Pay_Group(request);
		}

		public Put_External_Pay_Group_ResponseType Put_External_Pay_Group(Workday_Common_HeaderType Workday_Common_Header, Put_External_Pay_Group_RequestType Put_External_Pay_Group_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Pay_Group(new Put_External_Pay_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Pay_Group_Request = Put_External_Pay_Group_Request
			}).Put_External_Pay_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Pay_GroupOutput> Payroll_InterfacePort.Put_External_Pay_GroupAsync(Put_External_Pay_GroupInput request)
		{
			return base.Channel.Put_External_Pay_GroupAsync(request);
		}

		public Task<Put_External_Pay_GroupOutput> Put_External_Pay_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Pay_Group_RequestType Put_External_Pay_Group_Request)
		{
			return ((Payroll_InterfacePort)this).Put_External_Pay_GroupAsync(new Put_External_Pay_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Pay_Group_Request = Put_External_Pay_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_Costing_AllocationsOutput Payroll_InterfacePort.Get_Worker_Costing_Allocations(Get_Worker_Costing_AllocationsInput request)
		{
			return base.Channel.Get_Worker_Costing_Allocations(request);
		}

		public Get_Worker_Costing_Allocations_ResponseType Get_Worker_Costing_Allocations(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Worker_Costing_Allocations(new Get_Worker_Costing_AllocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Costing_Allocations_Request = Get_Worker_Costing_Allocations_Request
			}).Get_Worker_Costing_Allocations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_Costing_AllocationsOutput> Payroll_InterfacePort.Get_Worker_Costing_AllocationsAsync(Get_Worker_Costing_AllocationsInput request)
		{
			return base.Channel.Get_Worker_Costing_AllocationsAsync(request);
		}

		public Task<Get_Worker_Costing_AllocationsOutput> Get_Worker_Costing_AllocationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Costing_Allocations_RequestType Get_Worker_Costing_Allocations_Request)
		{
			return ((Payroll_InterfacePort)this).Get_Worker_Costing_AllocationsAsync(new Get_Worker_Costing_AllocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Costing_Allocations_Request = Get_Worker_Costing_Allocations_Request
			});
		}
	}
}
