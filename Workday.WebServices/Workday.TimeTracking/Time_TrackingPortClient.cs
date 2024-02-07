using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Time_TrackingPortClient : ClientBase<Time_TrackingPort>, Time_TrackingPort
	{
		public Time_TrackingPortClient()
		{
		}

		public Time_TrackingPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Time_TrackingPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Time_TrackingPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Time_TrackingPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Time_Clock_EventsOutput Time_TrackingPort.Put_Time_Clock_Events(Put_Time_Clock_EventsInput request)
		{
			return base.Channel.Put_Time_Clock_Events(request);
		}

		public Put_Time_Clock_Events_ResponseType Put_Time_Clock_Events(Workday_Common_HeaderType Workday_Common_Header, Put_Time_Clock_Events_RequestType Put_Time_Clock_Events_Request)
		{
			return ((Time_TrackingPort)this).Put_Time_Clock_Events(new Put_Time_Clock_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Time_Clock_Events_Request = Put_Time_Clock_Events_Request
			}).Put_Time_Clock_Events_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Time_Clock_EventsOutput> Time_TrackingPort.Put_Time_Clock_EventsAsync(Put_Time_Clock_EventsInput request)
		{
			return base.Channel.Put_Time_Clock_EventsAsync(request);
		}

		public Task<Put_Time_Clock_EventsOutput> Put_Time_Clock_EventsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Time_Clock_Events_RequestType Put_Time_Clock_Events_Request)
		{
			return ((Time_TrackingPort)this).Put_Time_Clock_EventsAsync(new Put_Time_Clock_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Time_Clock_Events_Request = Put_Time_Clock_Events_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Work_ScheduleOutput Time_TrackingPort.Assign_Work_Schedule(Assign_Work_ScheduleInput request)
		{
			return base.Channel.Assign_Work_Schedule(request);
		}

		public Assign_Work_Schedule_ResponseType Assign_Work_Schedule(Workday_Common_HeaderType Workday_Common_Header, Assign_Work_Schedule_RequestType Assign_Work_Schedule_Request)
		{
			return ((Time_TrackingPort)this).Assign_Work_Schedule(new Assign_Work_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Work_Schedule_Request = Assign_Work_Schedule_Request
			}).Assign_Work_Schedule_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Work_ScheduleOutput> Time_TrackingPort.Assign_Work_ScheduleAsync(Assign_Work_ScheduleInput request)
		{
			return base.Channel.Assign_Work_ScheduleAsync(request);
		}

		public Task<Assign_Work_ScheduleOutput> Assign_Work_ScheduleAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Work_Schedule_RequestType Assign_Work_Schedule_Request)
		{
			return ((Time_TrackingPort)this).Assign_Work_ScheduleAsync(new Assign_Work_ScheduleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Work_Schedule_Request = Assign_Work_Schedule_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Reported_Time_BlocksOutput Time_TrackingPort.Import_Reported_Time_Blocks(Import_Reported_Time_BlocksInput request)
		{
			return base.Channel.Import_Reported_Time_Blocks(request);
		}

		public Put_Import_Process_ResponseType Import_Reported_Time_Blocks(Workday_Common_HeaderType Workday_Common_Header, Import_Reported_Time_Blocks_RequestType Import_Reported_Time_Blocks_Request)
		{
			return ((Time_TrackingPort)this).Import_Reported_Time_Blocks(new Import_Reported_Time_BlocksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Reported_Time_Blocks_Request = Import_Reported_Time_Blocks_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Reported_Time_BlocksOutput> Time_TrackingPort.Import_Reported_Time_BlocksAsync(Import_Reported_Time_BlocksInput request)
		{
			return base.Channel.Import_Reported_Time_BlocksAsync(request);
		}

		public Task<Import_Reported_Time_BlocksOutput> Import_Reported_Time_BlocksAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Reported_Time_Blocks_RequestType Import_Reported_Time_Blocks_Request)
		{
			return ((Time_TrackingPort)this).Import_Reported_Time_BlocksAsync(new Import_Reported_Time_BlocksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Reported_Time_Blocks_Request = Import_Reported_Time_Blocks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Reported_Time_BlocksOutput Time_TrackingPort.Import_Time_Clock_Events(Import_Time_Clock_EventsInput request)
		{
			return base.Channel.Import_Time_Clock_Events(request);
		}

		public Put_Import_Process_ResponseType Import_Time_Clock_Events(Workday_Common_HeaderType Workday_Common_Header, Import_Time_Clock_Events_RequestType Import_Time_Clock_Events_Request)
		{
			return ((Time_TrackingPort)this).Import_Time_Clock_Events(new Import_Time_Clock_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Time_Clock_Events_Request = Import_Time_Clock_Events_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Reported_Time_BlocksOutput> Time_TrackingPort.Import_Time_Clock_EventsAsync(Import_Time_Clock_EventsInput request)
		{
			return base.Channel.Import_Time_Clock_EventsAsync(request);
		}

		public Task<Import_Reported_Time_BlocksOutput> Import_Time_Clock_EventsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Time_Clock_Events_RequestType Import_Time_Clock_Events_Request)
		{
			return ((Time_TrackingPort)this).Import_Time_Clock_EventsAsync(new Import_Time_Clock_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Time_Clock_Events_Request = Import_Time_Clock_Events_Request
			});
		}
	}
}
