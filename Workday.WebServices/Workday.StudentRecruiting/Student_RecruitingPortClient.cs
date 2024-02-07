using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Student_RecruitingPortClient : ClientBase<Student_RecruitingPort>, Student_RecruitingPort
	{
		public Student_RecruitingPortClient()
		{
		}

		public Student_RecruitingPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Student_RecruitingPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_RecruitingPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Student_RecruitingPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Recruiting_EventsOutput Student_RecruitingPort.Get_Student_Recruiting_Events(Get_Student_Recruiting_EventsInput request)
		{
			return base.Channel.Get_Student_Recruiting_Events(request);
		}

		public Get_Student_Recruiting_Events_ResponseType Get_Student_Recruiting_Events(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Events_RequestType Get_Student_Recruiting_Events_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_Events(new Get_Student_Recruiting_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Events_Request = Get_Student_Recruiting_Events_Request
			}).Get_Student_Recruiting_Events_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Recruiting_EventsOutput> Student_RecruitingPort.Get_Student_Recruiting_EventsAsync(Get_Student_Recruiting_EventsInput request)
		{
			return base.Channel.Get_Student_Recruiting_EventsAsync(request);
		}

		public Task<Get_Student_Recruiting_EventsOutput> Get_Student_Recruiting_EventsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Events_RequestType Get_Student_Recruiting_Events_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_EventsAsync(new Get_Student_Recruiting_EventsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Events_Request = Get_Student_Recruiting_Events_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_Recruiting_EventOutput Student_RecruitingPort.Submit_Student_Recruiting_Event(Submit_Student_Recruiting_EventInput request)
		{
			return base.Channel.Submit_Student_Recruiting_Event(request);
		}

		public Submit_Student_Recruiting_Event_ResponseType Submit_Student_Recruiting_Event(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiting_Event_RequestType Submit_Student_Recruiting_Event_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_Recruiting_Event(new Submit_Student_Recruiting_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiting_Event_Request = Submit_Student_Recruiting_Event_Request
			}).Submit_Student_Recruiting_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_Recruiting_EventOutput> Student_RecruitingPort.Submit_Student_Recruiting_EventAsync(Submit_Student_Recruiting_EventInput request)
		{
			return base.Channel.Submit_Student_Recruiting_EventAsync(request);
		}

		public Task<Submit_Student_Recruiting_EventOutput> Submit_Student_Recruiting_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiting_Event_RequestType Submit_Student_Recruiting_Event_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_Recruiting_EventAsync(new Submit_Student_Recruiting_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiting_Event_Request = Submit_Student_Recruiting_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Recruiting_CyclesOutput Student_RecruitingPort.Get_Student_Recruiting_Cycles(Get_Student_Recruiting_CyclesInput request)
		{
			return base.Channel.Get_Student_Recruiting_Cycles(request);
		}

		public Get_Student_Recruiting_Cycles_ResponseType Get_Student_Recruiting_Cycles(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Cycles_RequestType Get_Student_Recruiting_Cycles_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_Cycles(new Get_Student_Recruiting_CyclesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Cycles_Request = Get_Student_Recruiting_Cycles_Request
			}).Get_Student_Recruiting_Cycles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Recruiting_CyclesOutput> Student_RecruitingPort.Get_Student_Recruiting_CyclesAsync(Get_Student_Recruiting_CyclesInput request)
		{
			return base.Channel.Get_Student_Recruiting_CyclesAsync(request);
		}

		public Task<Get_Student_Recruiting_CyclesOutput> Get_Student_Recruiting_CyclesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Cycles_RequestType Get_Student_Recruiting_Cycles_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_CyclesAsync(new Get_Student_Recruiting_CyclesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Cycles_Request = Get_Student_Recruiting_Cycles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Recruiting_CycleOutput Student_RecruitingPort.Put_Student_Recruiting_Cycle(Put_Student_Recruiting_CycleInput request)
		{
			return base.Channel.Put_Student_Recruiting_Cycle(request);
		}

		public Put_Student_Recruiting_Cycle_ResponseType Put_Student_Recruiting_Cycle(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Cycle_RequestType Put_Student_Recruiting_Cycle_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_Cycle(new Put_Student_Recruiting_CycleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Cycle_Request = Put_Student_Recruiting_Cycle_Request
			}).Put_Student_Recruiting_Cycle_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Recruiting_CycleOutput> Student_RecruitingPort.Put_Student_Recruiting_CycleAsync(Put_Student_Recruiting_CycleInput request)
		{
			return base.Channel.Put_Student_Recruiting_CycleAsync(request);
		}

		public Task<Put_Student_Recruiting_CycleOutput> Put_Student_Recruiting_CycleAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Cycle_RequestType Put_Student_Recruiting_Cycle_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_CycleAsync(new Put_Student_Recruiting_CycleInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Cycle_Request = Put_Student_Recruiting_Cycle_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Recruiting_RegionsOutput Student_RecruitingPort.Get_Recruiting_Regions(Get_Recruiting_RegionsInput request)
		{
			return base.Channel.Get_Recruiting_Regions(request);
		}

		public Get_Recruiting_Regions_ResponseType Get_Recruiting_Regions(Workday_Common_HeaderType Workday_Common_Header, Get_Recruiting_Regions_RequestType Get_Recruiting_Regions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Recruiting_Regions(new Get_Recruiting_RegionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recruiting_Regions_Request = Get_Recruiting_Regions_Request
			}).Get_Recruiting_Regions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Recruiting_RegionsOutput> Student_RecruitingPort.Get_Recruiting_RegionsAsync(Get_Recruiting_RegionsInput request)
		{
			return base.Channel.Get_Recruiting_RegionsAsync(request);
		}

		public Task<Get_Recruiting_RegionsOutput> Get_Recruiting_RegionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Recruiting_Regions_RequestType Get_Recruiting_Regions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Recruiting_RegionsAsync(new Get_Recruiting_RegionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recruiting_Regions_Request = Get_Recruiting_Regions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Recruiting_RegionOutput Student_RecruitingPort.Put_Recruiting_Region(Put_Recruiting_RegionInput request)
		{
			return base.Channel.Put_Recruiting_Region(request);
		}

		public Put_Recruiting_Region_ResponseType Put_Recruiting_Region(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Region_RequestType Put_Recruiting_Region_Request)
		{
			return ((Student_RecruitingPort)this).Put_Recruiting_Region(new Put_Recruiting_RegionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recruiting_Region_Request = Put_Recruiting_Region_Request
			}).Put_Recruiting_Region_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Recruiting_RegionOutput> Student_RecruitingPort.Put_Recruiting_RegionAsync(Put_Recruiting_RegionInput request)
		{
			return base.Channel.Put_Recruiting_RegionAsync(request);
		}

		public Task<Put_Recruiting_RegionOutput> Put_Recruiting_RegionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Region_RequestType Put_Recruiting_Region_Request)
		{
			return ((Student_RecruitingPort)this).Put_Recruiting_RegionAsync(new Put_Recruiting_RegionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recruiting_Region_Request = Put_Recruiting_Region_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_RecruitersOutput Student_RecruitingPort.Get_Student_Recruiters(Get_Student_RecruitersInput request)
		{
			return base.Channel.Get_Student_Recruiters(request);
		}

		public Get_Student_Recruiters_ResponseType Get_Student_Recruiters(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiters_RequestType Get_Student_Recruiters_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiters(new Get_Student_RecruitersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiters_Request = Get_Student_Recruiters_Request
			}).Get_Student_Recruiters_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_RecruitersOutput> Student_RecruitingPort.Get_Student_RecruitersAsync(Get_Student_RecruitersInput request)
		{
			return base.Channel.Get_Student_RecruitersAsync(request);
		}

		public Task<Get_Student_RecruitersOutput> Get_Student_RecruitersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiters_RequestType Get_Student_Recruiters_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_RecruitersAsync(new Get_Student_RecruitersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiters_Request = Get_Student_Recruiters_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_RecruiterOutput Student_RecruitingPort.Submit_Student_Recruiter(Submit_Student_RecruiterInput request)
		{
			return base.Channel.Submit_Student_Recruiter(request);
		}

		public Submit_Student_Recruiter_ResponseType Submit_Student_Recruiter(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiter_RequestType Submit_Student_Recruiter_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_Recruiter(new Submit_Student_RecruiterInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiter_Request = Submit_Student_Recruiter_Request
			}).Submit_Student_Recruiter_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_RecruiterOutput> Student_RecruitingPort.Submit_Student_RecruiterAsync(Submit_Student_RecruiterInput request)
		{
			return base.Channel.Submit_Student_RecruiterAsync(request);
		}

		public Task<Submit_Student_RecruiterOutput> Submit_Student_RecruiterAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiter_RequestType Submit_Student_Recruiter_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_RecruiterAsync(new Submit_Student_RecruiterInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiter_Request = Submit_Student_Recruiter_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Recruiting_CampaignsOutput Student_RecruitingPort.Get_Student_Recruiting_Campaigns(Get_Student_Recruiting_CampaignsInput request)
		{
			return base.Channel.Get_Student_Recruiting_Campaigns(request);
		}

		public Get_Student_Recruiting_Campaigns_ResponseType Get_Student_Recruiting_Campaigns(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Campaigns_RequestType Get_Student_Recruiting_Campaigns_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_Campaigns(new Get_Student_Recruiting_CampaignsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Campaigns_Request = Get_Student_Recruiting_Campaigns_Request
			}).Get_Student_Recruiting_Campaigns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Recruiting_CampaignsOutput> Student_RecruitingPort.Get_Student_Recruiting_CampaignsAsync(Get_Student_Recruiting_CampaignsInput request)
		{
			return base.Channel.Get_Student_Recruiting_CampaignsAsync(request);
		}

		public Task<Get_Student_Recruiting_CampaignsOutput> Get_Student_Recruiting_CampaignsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Campaigns_RequestType Get_Student_Recruiting_Campaigns_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_CampaignsAsync(new Get_Student_Recruiting_CampaignsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Campaigns_Request = Get_Student_Recruiting_Campaigns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Student_Recruiting_CampaignOutput Student_RecruitingPort.Submit_Student_Recruiting_Campaign(Submit_Student_Recruiting_CampaignInput request)
		{
			return base.Channel.Submit_Student_Recruiting_Campaign(request);
		}

		public Submit_Student_Recruiting_Campaign_ResponseType Submit_Student_Recruiting_Campaign(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiting_Campaign_RequestType Submit_Student_Recruiting_Campaign_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_Recruiting_Campaign(new Submit_Student_Recruiting_CampaignInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiting_Campaign_Request = Submit_Student_Recruiting_Campaign_Request
			}).Submit_Student_Recruiting_Campaign_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Student_Recruiting_CampaignOutput> Student_RecruitingPort.Submit_Student_Recruiting_CampaignAsync(Submit_Student_Recruiting_CampaignInput request)
		{
			return base.Channel.Submit_Student_Recruiting_CampaignAsync(request);
		}

		public Task<Submit_Student_Recruiting_CampaignOutput> Submit_Student_Recruiting_CampaignAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Student_Recruiting_Campaign_RequestType Submit_Student_Recruiting_Campaign_Request)
		{
			return ((Student_RecruitingPort)this).Submit_Student_Recruiting_CampaignAsync(new Submit_Student_Recruiting_CampaignInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Student_Recruiting_Campaign_Request = Submit_Student_Recruiting_Campaign_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Ad_Hoc_LocationsOutput Student_RecruitingPort.Get_Ad_Hoc_Locations(Get_Ad_Hoc_LocationsInput request)
		{
			return base.Channel.Get_Ad_Hoc_Locations(request);
		}

		public Get_Ad_Hoc_Locations_ResponseType Get_Ad_Hoc_Locations(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Locations_RequestType Get_Ad_Hoc_Locations_Request)
		{
			return ((Student_RecruitingPort)this).Get_Ad_Hoc_Locations(new Get_Ad_Hoc_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Locations_Request = Get_Ad_Hoc_Locations_Request
			}).Get_Ad_Hoc_Locations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Ad_Hoc_LocationsOutput> Student_RecruitingPort.Get_Ad_Hoc_LocationsAsync(Get_Ad_Hoc_LocationsInput request)
		{
			return base.Channel.Get_Ad_Hoc_LocationsAsync(request);
		}

		public Task<Get_Ad_Hoc_LocationsOutput> Get_Ad_Hoc_LocationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ad_Hoc_Locations_RequestType Get_Ad_Hoc_Locations_Request)
		{
			return ((Student_RecruitingPort)this).Get_Ad_Hoc_LocationsAsync(new Get_Ad_Hoc_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ad_Hoc_Locations_Request = Get_Ad_Hoc_Locations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Ad_Hoc_LocationOutput Student_RecruitingPort.Put_Ad_Hoc_Location(Put_Ad_Hoc_LocationInput request)
		{
			return base.Channel.Put_Ad_Hoc_Location(request);
		}

		public Put_Ad_Hoc_Location_ResponseType Put_Ad_Hoc_Location(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Location_RequestType Put_Ad_Hoc_Location_Request)
		{
			return ((Student_RecruitingPort)this).Put_Ad_Hoc_Location(new Put_Ad_Hoc_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Location_Request = Put_Ad_Hoc_Location_Request
			}).Put_Ad_Hoc_Location_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Ad_Hoc_LocationOutput> Student_RecruitingPort.Put_Ad_Hoc_LocationAsync(Put_Ad_Hoc_LocationInput request)
		{
			return base.Channel.Put_Ad_Hoc_LocationAsync(request);
		}

		public Task<Put_Ad_Hoc_LocationOutput> Put_Ad_Hoc_LocationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Location_RequestType Put_Ad_Hoc_Location_Request)
		{
			return ((Student_RecruitingPort)this).Put_Ad_Hoc_LocationAsync(new Put_Ad_Hoc_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ad_Hoc_Location_Request = Put_Ad_Hoc_Location_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Search_Service_DefinitionsOutput Student_RecruitingPort.Get_Search_Service_Definitions(Get_Search_Service_DefinitionsInput request)
		{
			return base.Channel.Get_Search_Service_Definitions(request);
		}

		public Get_Search_Service_Definitions_ResponseType Get_Search_Service_Definitions(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Service_Definitions_RequestType Get_Search_Service_Definitions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Search_Service_Definitions(new Get_Search_Service_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Service_Definitions_Request = Get_Search_Service_Definitions_Request
			}).Get_Search_Service_Definitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Search_Service_DefinitionsOutput> Student_RecruitingPort.Get_Search_Service_DefinitionsAsync(Get_Search_Service_DefinitionsInput request)
		{
			return base.Channel.Get_Search_Service_DefinitionsAsync(request);
		}

		public Task<Get_Search_Service_DefinitionsOutput> Get_Search_Service_DefinitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Service_Definitions_RequestType Get_Search_Service_Definitions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Search_Service_DefinitionsAsync(new Get_Search_Service_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Service_Definitions_Request = Get_Search_Service_Definitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Search_Service_DefinitionOutput Student_RecruitingPort.Put_Search_Service_Definition(Put_Search_Service_DefinitionInput request)
		{
			return base.Channel.Put_Search_Service_Definition(request);
		}

		public Put_Search_Service_Definition_ResponseType Put_Search_Service_Definition(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Service_Definition_RequestType Put_Search_Service_Definition_Request)
		{
			return ((Student_RecruitingPort)this).Put_Search_Service_Definition(new Put_Search_Service_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Service_Definition_Request = Put_Search_Service_Definition_Request
			}).Put_Search_Service_Definition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Search_Service_DefinitionOutput> Student_RecruitingPort.Put_Search_Service_DefinitionAsync(Put_Search_Service_DefinitionInput request)
		{
			return base.Channel.Put_Search_Service_DefinitionAsync(request);
		}

		public Task<Put_Search_Service_DefinitionOutput> Put_Search_Service_DefinitionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Service_Definition_RequestType Put_Search_Service_Definition_Request)
		{
			return ((Student_RecruitingPort)this).Put_Search_Service_DefinitionAsync(new Put_Search_Service_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Service_Definition_Request = Put_Search_Service_Definition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Recruiting_Event_Registration_RecordOutput Student_RecruitingPort.Put_Student_Recruiting_Event_Registration_Record(Put_Student_Recruiting_Event_Registration_RecordInput request)
		{
			return base.Channel.Put_Student_Recruiting_Event_Registration_Record(request);
		}

		public Put_Student_Recruiting_Event_Registration_Record_ResponseType Put_Student_Recruiting_Event_Registration_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Event_Registration_Record_RequestType Put_Student_Recruiting_Event_Registration_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_Event_Registration_Record(new Put_Student_Recruiting_Event_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Event_Registration_Record_Request = Put_Student_Recruiting_Event_Registration_Record_Request
			}).Put_Student_Recruiting_Event_Registration_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Recruiting_Event_Registration_RecordOutput> Student_RecruitingPort.Put_Student_Recruiting_Event_Registration_RecordAsync(Put_Student_Recruiting_Event_Registration_RecordInput request)
		{
			return base.Channel.Put_Student_Recruiting_Event_Registration_RecordAsync(request);
		}

		public Task<Put_Student_Recruiting_Event_Registration_RecordOutput> Put_Student_Recruiting_Event_Registration_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Event_Registration_Record_RequestType Put_Student_Recruiting_Event_Registration_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_Event_Registration_RecordAsync(new Put_Student_Recruiting_Event_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Event_Registration_Record_Request = Put_Student_Recruiting_Event_Registration_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Marketing_Activity_DefinitionsOutput Student_RecruitingPort.Get_Marketing_Activity_Definitions(Get_Marketing_Activity_DefinitionsInput request)
		{
			return base.Channel.Get_Marketing_Activity_Definitions(request);
		}

		public Get_Marketing_Activity_Definitions_ResponseType Get_Marketing_Activity_Definitions(Workday_Common_HeaderType Workday_Common_Header, Get_Marketing_Activity_Definitions_RequestType Get_Marketing_Activity_Definitions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Marketing_Activity_Definitions(new Get_Marketing_Activity_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Marketing_Activity_Definitions_Request = Get_Marketing_Activity_Definitions_Request
			}).Get_Marketing_Activity_Definitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Marketing_Activity_DefinitionsOutput> Student_RecruitingPort.Get_Marketing_Activity_DefinitionsAsync(Get_Marketing_Activity_DefinitionsInput request)
		{
			return base.Channel.Get_Marketing_Activity_DefinitionsAsync(request);
		}

		public Task<Get_Marketing_Activity_DefinitionsOutput> Get_Marketing_Activity_DefinitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Marketing_Activity_Definitions_RequestType Get_Marketing_Activity_Definitions_Request)
		{
			return ((Student_RecruitingPort)this).Get_Marketing_Activity_DefinitionsAsync(new Get_Marketing_Activity_DefinitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Marketing_Activity_Definitions_Request = Get_Marketing_Activity_Definitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Marketing_Activity_DefinitionOutput Student_RecruitingPort.Put_Marketing_Activity_Definition(Put_Marketing_Activity_DefinitionInput request)
		{
			return base.Channel.Put_Marketing_Activity_Definition(request);
		}

		public Put_Marketing_Activity_Definition_ResponseType Put_Marketing_Activity_Definition(Workday_Common_HeaderType Workday_Common_Header, Put_Marketing_Activity_Definition_RequestType Put_Marketing_Activity_Definition_Request)
		{
			return ((Student_RecruitingPort)this).Put_Marketing_Activity_Definition(new Put_Marketing_Activity_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Marketing_Activity_Definition_Request = Put_Marketing_Activity_Definition_Request
			}).Put_Marketing_Activity_Definition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Marketing_Activity_DefinitionOutput> Student_RecruitingPort.Put_Marketing_Activity_DefinitionAsync(Put_Marketing_Activity_DefinitionInput request)
		{
			return base.Channel.Put_Marketing_Activity_DefinitionAsync(request);
		}

		public Task<Put_Marketing_Activity_DefinitionOutput> Put_Marketing_Activity_DefinitionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Marketing_Activity_Definition_RequestType Put_Marketing_Activity_Definition_Request)
		{
			return ((Student_RecruitingPort)this).Put_Marketing_Activity_DefinitionAsync(new Put_Marketing_Activity_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Marketing_Activity_Definition_Request = Put_Marketing_Activity_Definition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_RecruitmentsOutput Student_RecruitingPort.Get_Student_Recruitments(Get_Student_RecruitmentsInput request)
		{
			return base.Channel.Get_Student_Recruitments(request);
		}

		public Get_Student_Recruitments_ResponseType Get_Student_Recruitments(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruitments_RequestType Get_Student_Recruitments_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruitments(new Get_Student_RecruitmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruitments_Request = Get_Student_Recruitments_Request
			}).Get_Student_Recruitments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_RecruitmentsOutput> Student_RecruitingPort.Get_Student_RecruitmentsAsync(Get_Student_RecruitmentsInput request)
		{
			return base.Channel.Get_Student_RecruitmentsAsync(request);
		}

		public Task<Get_Student_RecruitmentsOutput> Get_Student_RecruitmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruitments_RequestType Get_Student_Recruitments_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_RecruitmentsAsync(new Get_Student_RecruitmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruitments_Request = Get_Student_Recruitments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_RecruitmentOutput Student_RecruitingPort.Put_Student_Recruitment(Put_Student_RecruitmentInput request)
		{
			return base.Channel.Put_Student_Recruitment(request);
		}

		public Put_Student_Recruitment_ResponseType Put_Student_Recruitment(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruitment_RequestType Put_Student_Recruitment_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruitment(new Put_Student_RecruitmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruitment_Request = Put_Student_Recruitment_Request
			}).Put_Student_Recruitment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_RecruitmentOutput> Student_RecruitingPort.Put_Student_RecruitmentAsync(Put_Student_RecruitmentInput request)
		{
			return base.Channel.Put_Student_RecruitmentAsync(request);
		}

		public Task<Put_Student_RecruitmentOutput> Put_Student_RecruitmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruitment_RequestType Put_Student_Recruitment_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_RecruitmentAsync(new Put_Student_RecruitmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruitment_Request = Put_Student_Recruitment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Recruiting_Event_Registration_RecordsOutput Student_RecruitingPort.Get_Student_Recruiting_Event_Registration_Records(Get_Student_Recruiting_Event_Registration_RecordsInput request)
		{
			return base.Channel.Get_Student_Recruiting_Event_Registration_Records(request);
		}

		public Get_Student_Recruiting_Event_Registration_Records_ResponseType Get_Student_Recruiting_Event_Registration_Records(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Event_Registration_Records_RequestType Get_Student_Recruiting_Event_Registration_Records_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_Event_Registration_Records(new Get_Student_Recruiting_Event_Registration_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Event_Registration_Records_Request = Get_Student_Recruiting_Event_Registration_Records_Request
			}).Get_Student_Recruiting_Event_Registration_Records_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Recruiting_Event_Registration_RecordsOutput> Student_RecruitingPort.Get_Student_Recruiting_Event_Registration_RecordsAsync(Get_Student_Recruiting_Event_Registration_RecordsInput request)
		{
			return base.Channel.Get_Student_Recruiting_Event_Registration_RecordsAsync(request);
		}

		public Task<Get_Student_Recruiting_Event_Registration_RecordsOutput> Get_Student_Recruiting_Event_Registration_RecordsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Recruiting_Event_Registration_Records_RequestType Get_Student_Recruiting_Event_Registration_Records_Request)
		{
			return ((Student_RecruitingPort)this).Get_Student_Recruiting_Event_Registration_RecordsAsync(new Get_Student_Recruiting_Event_Registration_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Recruiting_Event_Registration_Records_Request = Get_Student_Recruiting_Event_Registration_Records_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Unregister_Student_Recruiting_Registration_RecordOutput Student_RecruitingPort.Put_Unregister_Student_Recruiting_Registration_Record(Put_Unregister_Student_Recruiting_Registration_RecordInput request)
		{
			return base.Channel.Put_Unregister_Student_Recruiting_Registration_Record(request);
		}

		public Put_Unregister_Student_Recruiting_Registration_Record_ResponseType Put_Unregister_Student_Recruiting_Registration_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Unregister_Student_Recruiting_Registration_Record_RequestType Put_Unregister_Student_Recruiting_Registration_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Unregister_Student_Recruiting_Registration_Record(new Put_Unregister_Student_Recruiting_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Unregister_Student_Recruiting_Registration_Record_Request = Put_Unregister_Student_Recruiting_Registration_Record_Request
			}).Put_Unregister_Student_Recruiting_Registration_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Unregister_Student_Recruiting_Registration_RecordOutput> Student_RecruitingPort.Put_Unregister_Student_Recruiting_Registration_RecordAsync(Put_Unregister_Student_Recruiting_Registration_RecordInput request)
		{
			return base.Channel.Put_Unregister_Student_Recruiting_Registration_RecordAsync(request);
		}

		public Task<Put_Unregister_Student_Recruiting_Registration_RecordOutput> Put_Unregister_Student_Recruiting_Registration_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Unregister_Student_Recruiting_Registration_Record_RequestType Put_Unregister_Student_Recruiting_Registration_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Unregister_Student_Recruiting_Registration_RecordAsync(new Put_Unregister_Student_Recruiting_Registration_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Unregister_Student_Recruiting_Registration_Record_Request = Put_Unregister_Student_Recruiting_Registration_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Recruiting_Event_Attendance_RecordOutput Student_RecruitingPort.Put_Student_Recruiting_Event_Attendance_Record(Put_Student_Recruiting_Event_Attendance_RecordInput request)
		{
			return base.Channel.Put_Student_Recruiting_Event_Attendance_Record(request);
		}

		public Put_Student_Recruiting_Event_Attendance_Record_ResponseType Put_Student_Recruiting_Event_Attendance_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Event_Attendance_Record_RequestType Put_Student_Recruiting_Event_Attendance_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_Event_Attendance_Record(new Put_Student_Recruiting_Event_Attendance_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Event_Attendance_Record_Request = Put_Student_Recruiting_Event_Attendance_Record_Request
			}).Put_Student_Recruiting_Event_Attendance_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Recruiting_Event_Attendance_RecordOutput> Student_RecruitingPort.Put_Student_Recruiting_Event_Attendance_RecordAsync(Put_Student_Recruiting_Event_Attendance_RecordInput request)
		{
			return base.Channel.Put_Student_Recruiting_Event_Attendance_RecordAsync(request);
		}

		public Task<Put_Student_Recruiting_Event_Attendance_RecordOutput> Put_Student_Recruiting_Event_Attendance_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Recruiting_Event_Attendance_Record_RequestType Put_Student_Recruiting_Event_Attendance_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Student_Recruiting_Event_Attendance_RecordAsync(new Put_Student_Recruiting_Event_Attendance_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Recruiting_Event_Attendance_Record_Request = Put_Student_Recruiting_Event_Attendance_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput Student_RecruitingPort.Put_Remove_Student_Recruiting_Event_Attendance_Record(Put_Remove_Student_Recruiting_Event_Attendance_RecordInput request)
		{
			return base.Channel.Put_Remove_Student_Recruiting_Event_Attendance_Record(request);
		}

		public Put_Remove_Student_Recruiting_Event_Attendance_Record_ResponseType Put_Remove_Student_Recruiting_Event_Attendance_Record(Workday_Common_HeaderType Workday_Common_Header, Put_Remove_Student_Recruiting_Event_Attendance_Record_RequestType Put_Remove_Student_Recruiting_Event_Attendance_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Remove_Student_Recruiting_Event_Attendance_Record(new Put_Remove_Student_Recruiting_Event_Attendance_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Remove_Student_Recruiting_Event_Attendance_Record_Request = Put_Remove_Student_Recruiting_Event_Attendance_Record_Request
			}).Put_Remove_Student_Recruiting_Event_Attendance_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput> Student_RecruitingPort.Put_Remove_Student_Recruiting_Event_Attendance_RecordAsync(Put_Remove_Student_Recruiting_Event_Attendance_RecordInput request)
		{
			return base.Channel.Put_Remove_Student_Recruiting_Event_Attendance_RecordAsync(request);
		}

		public Task<Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput> Put_Remove_Student_Recruiting_Event_Attendance_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Remove_Student_Recruiting_Event_Attendance_Record_RequestType Put_Remove_Student_Recruiting_Event_Attendance_Record_Request)
		{
			return ((Student_RecruitingPort)this).Put_Remove_Student_Recruiting_Event_Attendance_RecordAsync(new Put_Remove_Student_Recruiting_Event_Attendance_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Remove_Student_Recruiting_Event_Attendance_Record_Request = Put_Remove_Student_Recruiting_Event_Attendance_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Student_RecruitmentsOutput Student_RecruitingPort.Import_Student_Recruitments(Import_Student_RecruitmentsInput request)
		{
			return base.Channel.Import_Student_Recruitments(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Recruitments(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Recruitment_RequestType Import_Student_Recruitment_Request)
		{
			return ((Student_RecruitingPort)this).Import_Student_Recruitments(new Import_Student_RecruitmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Recruitment_Request = Import_Student_Recruitment_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Student_RecruitmentsOutput> Student_RecruitingPort.Import_Student_RecruitmentsAsync(Import_Student_RecruitmentsInput request)
		{
			return base.Channel.Import_Student_RecruitmentsAsync(request);
		}

		public Task<Import_Student_RecruitmentsOutput> Import_Student_RecruitmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Recruitment_RequestType Import_Student_Recruitment_Request)
		{
			return ((Student_RecruitingPort)this).Import_Student_RecruitmentsAsync(new Import_Student_RecruitmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Recruitment_Request = Import_Student_Recruitment_Request
			});
		}
	}
}
