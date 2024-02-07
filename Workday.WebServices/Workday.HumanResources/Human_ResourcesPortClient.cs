using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class Human_ResourcesPortClient : ClientBase<Human_ResourcesPort>, Human_ResourcesPort
	{
		public Human_ResourcesPortClient()
		{
		}

		public Human_ResourcesPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public Human_ResourcesPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Human_ResourcesPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public Human_ResourcesPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_LocationOutput Human_ResourcesPort.Put_Location(Put_LocationInput request)
		{
			return base.Channel.Put_Location(request);
		}

		public Put_Location_ResponseType Put_Location(Workday_Common_HeaderType Workday_Common_Header, Put_Location_RequestType Put_Location_Request)
		{
			return ((Human_ResourcesPort)this).Put_Location(new Put_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Request = Put_Location_Request
			}).Put_Location_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_LocationOutput> Human_ResourcesPort.Put_LocationAsync(Put_LocationInput request)
		{
			return base.Channel.Put_LocationAsync(request);
		}

		public Task<Put_LocationOutput> Put_LocationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Location_RequestType Put_Location_Request)
		{
			return ((Human_ResourcesPort)this).Put_LocationAsync(new Put_LocationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Request = Put_Location_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Find_Business_SiteOutput Human_ResourcesPort.Find_Business_Site(Find_Business_SiteInput request)
		{
			return base.Channel.Find_Business_Site(request);
		}

		public Business_Site_ReferencesRootType Find_Business_Site(Workday_Common_HeaderType Workday_Common_Header, Business_Site_FindType Business_Site_Find)
		{
			return ((Human_ResourcesPort)this).Find_Business_Site(new Find_Business_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Business_Site_Find = Business_Site_Find
			}).Business_Site_References;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Find_Business_SiteOutput> Human_ResourcesPort.Find_Business_SiteAsync(Find_Business_SiteInput request)
		{
			return base.Channel.Find_Business_SiteAsync(request);
		}

		public Task<Find_Business_SiteOutput> Find_Business_SiteAsync(Workday_Common_HeaderType Workday_Common_Header, Business_Site_FindType Business_Site_Find)
		{
			return ((Human_ResourcesPort)this).Find_Business_SiteAsync(new Find_Business_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Business_Site_Find = Business_Site_Find
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrganizationOutput Human_ResourcesPort.Get_Organization(Get_OrganizationInput request)
		{
			return base.Channel.Get_Organization(request);
		}

		public OrganizationType Get_Organization(Workday_Common_HeaderType Workday_Common_Header, Organization_GetType Organization_Get)
		{
			return ((Human_ResourcesPort)this).Get_Organization(new Get_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Get = Organization_Get
			}).Organization;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrganizationOutput> Human_ResourcesPort.Get_OrganizationAsync(Get_OrganizationInput request)
		{
			return base.Channel.Get_OrganizationAsync(request);
		}

		public Task<Get_OrganizationOutput> Get_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Organization_GetType Organization_Get)
		{
			return ((Human_ResourcesPort)this).Get_OrganizationAsync(new Get_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Get = Organization_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Update_OrganizationOutput Human_ResourcesPort.Add_Update_Organization(Add_Update_OrganizationInput request)
		{
			return base.Channel.Add_Update_Organization(request);
		}

		public Organization_ReferenceRootType Add_Update_Organization(Workday_Common_HeaderType Workday_Common_Header, Organization_Add_UpdateType Organization_Add_Update)
		{
			return ((Human_ResourcesPort)this).Add_Update_Organization(new Add_Update_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Add_Update = Organization_Add_Update
			}).Organization_Reference;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Update_OrganizationOutput> Human_ResourcesPort.Add_Update_OrganizationAsync(Add_Update_OrganizationInput request)
		{
			return base.Channel.Add_Update_OrganizationAsync(request);
		}

		public Task<Add_Update_OrganizationOutput> Add_Update_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Organization_Add_UpdateType Organization_Add_Update)
		{
			return ((Human_ResourcesPort)this).Add_Update_OrganizationAsync(new Add_Update_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Add_Update = Organization_Add_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_Personal_InfoOutput Human_ResourcesPort.Get_Employee_Personal_Info(Get_Employee_Personal_InfoInput request)
		{
			return base.Channel.Get_Employee_Personal_Info(request);
		}

		public Employee_Personal_InfoType Get_Employee_Personal_Info(Workday_Common_HeaderType Workday_Common_Header, Employee_Personal_Info_GetType Employee_Personal_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Personal_Info(new Get_Employee_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Personal_Info_Get = Employee_Personal_Info_Get
			}).Employee_Personal_Info;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_Personal_InfoOutput> Human_ResourcesPort.Get_Employee_Personal_InfoAsync(Get_Employee_Personal_InfoInput request)
		{
			return base.Channel.Get_Employee_Personal_InfoAsync(request);
		}

		public Task<Get_Employee_Personal_InfoOutput> Get_Employee_Personal_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Personal_Info_GetType Employee_Personal_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Personal_InfoAsync(new Get_Employee_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Personal_Info_Get = Employee_Personal_Info_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contingent_Worker_Contract_InfoOutput Human_ResourcesPort.Get_Contingent_Worker_Contract_Info(Get_Contingent_Worker_Contract_InfoInput request)
		{
			return base.Channel.Get_Contingent_Worker_Contract_Info(request);
		}

		public Contingent_Worker_Contract_InfoType Get_Contingent_Worker_Contract_Info(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Contract_Info_GetType Contingent_Worker_Contract_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_Worker_Contract_Info(new Get_Contingent_Worker_Contract_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Contract_Info_Get = Contingent_Worker_Contract_Info_Get
			}).Contingent_Worker_Contract_Info;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contingent_Worker_Contract_InfoOutput> Human_ResourcesPort.Get_Contingent_Worker_Contract_InfoAsync(Get_Contingent_Worker_Contract_InfoInput request)
		{
			return base.Channel.Get_Contingent_Worker_Contract_InfoAsync(request);
		}

		public Task<Get_Contingent_Worker_Contract_InfoOutput> Get_Contingent_Worker_Contract_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Contract_Info_GetType Contingent_Worker_Contract_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_Worker_Contract_InfoAsync(new Get_Contingent_Worker_Contract_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Contract_Info_Get = Contingent_Worker_Contract_Info_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_ProfileOutput Human_ResourcesPort.Get_Worker_Profile(Get_Worker_ProfileInput request)
		{
			return base.Channel.Get_Worker_Profile(request);
		}

		public Worker_ProfileType Get_Worker_Profile(Workday_Common_HeaderType Workday_Common_Header, Worker_Profile_GetType Worker_Profile_Get)
		{
			return ((Human_ResourcesPort)this).Get_Worker_Profile(new Get_Worker_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Profile_Get = Worker_Profile_Get
			}).Worker_Profile;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_ProfileOutput> Human_ResourcesPort.Get_Worker_ProfileAsync(Get_Worker_ProfileInput request)
		{
			return base.Channel.Get_Worker_ProfileAsync(request);
		}

		public Task<Get_Worker_ProfileOutput> Get_Worker_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Worker_Profile_GetType Worker_Profile_Get)
		{
			return ((Human_ResourcesPort)this).Get_Worker_ProfileAsync(new Get_Worker_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Profile_Get = Worker_Profile_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Previous_System_Job_HistoryOutput Human_ResourcesPort.Put_Previous_System_Job_History(Put_Previous_System_Job_HistoryInput request)
		{
			return base.Channel.Put_Previous_System_Job_History(request);
		}

		public Put_Previous_System_Job_History_ResponseType Put_Previous_System_Job_History(Workday_Common_HeaderType Workday_Common_Header, Put_Previous_System_Job_History_RequestType Put_Previous_System_Job_History_Request)
		{
			return ((Human_ResourcesPort)this).Put_Previous_System_Job_History(new Put_Previous_System_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Previous_System_Job_History_Request = Put_Previous_System_Job_History_Request
			}).Put_Previous_System_Job_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Previous_System_Job_HistoryOutput> Human_ResourcesPort.Put_Previous_System_Job_HistoryAsync(Put_Previous_System_Job_HistoryInput request)
		{
			return base.Channel.Put_Previous_System_Job_HistoryAsync(request);
		}

		public Task<Put_Previous_System_Job_HistoryOutput> Put_Previous_System_Job_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Previous_System_Job_History_RequestType Put_Previous_System_Job_History_Request)
		{
			return ((Human_ResourcesPort)this).Put_Previous_System_Job_HistoryAsync(new Put_Previous_System_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Previous_System_Job_History_Request = Put_Previous_System_Job_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Dissolve_Organization_StructureOutput Human_ResourcesPort.Dissolve_Organization_Structure(Dissolve_Organization_StructureInput request)
		{
			return base.Channel.Dissolve_Organization_Structure(request);
		}

		public void Dissolve_Organization_Structure(Workday_Common_HeaderType Workday_Common_Header, Organization_Structure_DissolveType Organization_Structure_Dissolve)
		{
			((Human_ResourcesPort)this).Dissolve_Organization_Structure(new Dissolve_Organization_StructureInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Structure_Dissolve = Organization_Structure_Dissolve
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Dissolve_Organization_StructureOutput> Human_ResourcesPort.Dissolve_Organization_StructureAsync(Dissolve_Organization_StructureInput request)
		{
			return base.Channel.Dissolve_Organization_StructureAsync(request);
		}

		public Task<Dissolve_Organization_StructureOutput> Dissolve_Organization_StructureAsync(Workday_Common_HeaderType Workday_Common_Header, Organization_Structure_DissolveType Organization_Structure_Dissolve)
		{
			return ((Human_ResourcesPort)this).Dissolve_Organization_StructureAsync(new Dissolve_Organization_StructureInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Structure_Dissolve = Organization_Structure_Dissolve
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Find_OrganizationOutput Human_ResourcesPort.Find_Organization(Find_OrganizationInput request)
		{
			return base.Channel.Find_Organization(request);
		}

		public Organization_ReferencesRootType Find_Organization(Workday_Common_HeaderType Workday_Common_Header, Organization_FindType Organization_Find)
		{
			return ((Human_ResourcesPort)this).Find_Organization(new Find_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Find = Organization_Find
			}).Organization_References;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Find_OrganizationOutput> Human_ResourcesPort.Find_OrganizationAsync(Find_OrganizationInput request)
		{
			return base.Channel.Find_OrganizationAsync(request);
		}

		public Task<Find_OrganizationOutput> Find_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Organization_FindType Organization_Find)
		{
			return ((Human_ResourcesPort)this).Find_OrganizationAsync(new Find_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Find = Organization_Find
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Employee_Personal_InfoOutput Human_ResourcesPort.Update_Employee_Personal_Info(Update_Employee_Personal_InfoInput request)
		{
			return base.Channel.Update_Employee_Personal_Info(request);
		}

		public void Update_Employee_Personal_Info(Workday_Common_HeaderType Workday_Common_Header, Employee_Personal_Info_UpdateType Employee_Personal_Info_Update)
		{
			((Human_ResourcesPort)this).Update_Employee_Personal_Info(new Update_Employee_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Personal_Info_Update = Employee_Personal_Info_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Employee_Personal_InfoOutput> Human_ResourcesPort.Update_Employee_Personal_InfoAsync(Update_Employee_Personal_InfoInput request)
		{
			return base.Channel.Update_Employee_Personal_InfoAsync(request);
		}

		public Task<Update_Employee_Personal_InfoOutput> Update_Employee_Personal_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Personal_Info_UpdateType Employee_Personal_Info_Update)
		{
			return ((Human_ResourcesPort)this).Update_Employee_Personal_InfoAsync(new Update_Employee_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Personal_Info_Update = Employee_Personal_Info_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Business_SiteOutput Human_ResourcesPort.Get_Business_Site(Get_Business_SiteInput request)
		{
			return base.Channel.Get_Business_Site(request);
		}

		public Business_SiteType Get_Business_Site(Workday_Common_HeaderType Workday_Common_Header, Business_Site_GetType Business_Site_Get)
		{
			return ((Human_ResourcesPort)this).Get_Business_Site(new Get_Business_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Business_Site_Get = Business_Site_Get
			}).Business_Site;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Business_SiteOutput> Human_ResourcesPort.Get_Business_SiteAsync(Get_Business_SiteInput request)
		{
			return base.Channel.Get_Business_SiteAsync(request);
		}

		public Task<Get_Business_SiteOutput> Get_Business_SiteAsync(Workday_Common_HeaderType Workday_Common_Header, Business_Site_GetType Business_Site_Get)
		{
			return ((Human_ResourcesPort)this).Get_Business_SiteAsync(new Get_Business_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Business_Site_Get = Business_Site_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_Employment_InfoOutput Human_ResourcesPort.Get_Employee_Employment_Info(Get_Employee_Employment_InfoInput request)
		{
			return base.Channel.Get_Employee_Employment_Info(request);
		}

		public Employee_Employment_InfoType Get_Employee_Employment_Info(Workday_Common_HeaderType Workday_Common_Header, Employee_Employment_Info_GetType Employee_Employment_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Employment_Info(new Get_Employee_Employment_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Employment_Info_Get = Employee_Employment_Info_Get
			}).Employee_Employment_Info;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_Employment_InfoOutput> Human_ResourcesPort.Get_Employee_Employment_InfoAsync(Get_Employee_Employment_InfoInput request)
		{
			return base.Channel.Get_Employee_Employment_InfoAsync(request);
		}

		public Task<Get_Employee_Employment_InfoOutput> Get_Employee_Employment_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Employment_Info_GetType Employee_Employment_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Employment_InfoAsync(new Get_Employee_Employment_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Employment_Info_Get = Employee_Employment_Info_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contingent_Worker_Personal_InfoOutput Human_ResourcesPort.Get_Contingent_Worker_Personal_Info(Get_Contingent_Worker_Personal_InfoInput request)
		{
			return base.Channel.Get_Contingent_Worker_Personal_Info(request);
		}

		public Contingent_Worker_Personal_InfoType Get_Contingent_Worker_Personal_Info(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Personal_Info_GetType Contingent_Worker_Personal_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_Worker_Personal_Info(new Get_Contingent_Worker_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Personal_Info_Get = Contingent_Worker_Personal_Info_Get
			}).Contingent_Worker_Personal_Info;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contingent_Worker_Personal_InfoOutput> Human_ResourcesPort.Get_Contingent_Worker_Personal_InfoAsync(Get_Contingent_Worker_Personal_InfoInput request)
		{
			return base.Channel.Get_Contingent_Worker_Personal_InfoAsync(request);
		}

		public Task<Get_Contingent_Worker_Personal_InfoOutput> Get_Contingent_Worker_Personal_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Personal_Info_GetType Contingent_Worker_Personal_Info_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_Worker_Personal_InfoAsync(new Get_Contingent_Worker_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Personal_Info_Get = Contingent_Worker_Personal_Info_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Contingent_Worker_Personal_InfoOutput Human_ResourcesPort.Update_Contingent_Worker_Personal_Info(Update_Contingent_Worker_Personal_InfoInput request)
		{
			return base.Channel.Update_Contingent_Worker_Personal_Info(request);
		}

		public void Update_Contingent_Worker_Personal_Info(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Personal_Info_UpdateType Contingent_Worker_Personal_Info_Update)
		{
			((Human_ResourcesPort)this).Update_Contingent_Worker_Personal_Info(new Update_Contingent_Worker_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Personal_Info_Update = Contingent_Worker_Personal_Info_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Contingent_Worker_Personal_InfoOutput> Human_ResourcesPort.Update_Contingent_Worker_Personal_InfoAsync(Update_Contingent_Worker_Personal_InfoInput request)
		{
			return base.Channel.Update_Contingent_Worker_Personal_InfoAsync(request);
		}

		public Task<Update_Contingent_Worker_Personal_InfoOutput> Update_Contingent_Worker_Personal_InfoAsync(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_Personal_Info_UpdateType Contingent_Worker_Personal_Info_Update)
		{
			return ((Human_ResourcesPort)this).Update_Contingent_Worker_Personal_InfoAsync(new Update_Contingent_Worker_Personal_InfoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Personal_Info_Update = Contingent_Worker_Personal_Info_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Inactivate_OrganizationOutput Human_ResourcesPort.Inactivate_Organization(Inactivate_OrganizationInput request)
		{
			return base.Channel.Inactivate_Organization(request);
		}

		public void Inactivate_Organization(Workday_Common_HeaderType Workday_Common_Header, Organization_InactivateType Organization_Inactivate)
		{
			((Human_ResourcesPort)this).Inactivate_Organization(new Inactivate_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Inactivate = Organization_Inactivate
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Inactivate_OrganizationOutput> Human_ResourcesPort.Inactivate_OrganizationAsync(Inactivate_OrganizationInput request)
		{
			return base.Channel.Inactivate_OrganizationAsync(request);
		}

		public Task<Inactivate_OrganizationOutput> Inactivate_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Organization_InactivateType Organization_Inactivate)
		{
			return ((Human_ResourcesPort)this).Inactivate_OrganizationAsync(new Inactivate_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Organization_Inactivate = Organization_Inactivate
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_Related_PersonsOutput Human_ResourcesPort.Get_Employee_Related_Persons(Get_Employee_Related_PersonsInput request)
		{
			return base.Channel.Get_Employee_Related_Persons(request);
		}

		public Employee_Related_PersonsType Get_Employee_Related_Persons(Workday_Common_HeaderType Workday_Common_Header, Employee_Related_Persons_GetType Employee_Related_Persons_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Related_Persons(new Get_Employee_Related_PersonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Related_Persons_Get = Employee_Related_Persons_Get
			}).Employee_Related_Persons;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_Related_PersonsOutput> Human_ResourcesPort.Get_Employee_Related_PersonsAsync(Get_Employee_Related_PersonsInput request)
		{
			return base.Channel.Get_Employee_Related_PersonsAsync(request);
		}

		public Task<Get_Employee_Related_PersonsOutput> Get_Employee_Related_PersonsAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Related_Persons_GetType Employee_Related_Persons_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Related_PersonsAsync(new Get_Employee_Related_PersonsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Related_Persons_Get = Employee_Related_Persons_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_LocationsOutput Human_ResourcesPort.Get_Locations(Get_LocationsInput request)
		{
			return base.Channel.Get_Locations(request);
		}

		public Get_Locations_ResponseType Get_Locations(Workday_Common_HeaderType Workday_Common_Header, Get_Locations_RequestType Get_Locations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Locations(new Get_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Locations_Request = Get_Locations_Request
			}).Get_Locations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_LocationsOutput> Human_ResourcesPort.Get_LocationsAsync(Get_LocationsInput request)
		{
			return base.Channel.Get_LocationsAsync(request);
		}

		public Task<Get_LocationsOutput> Get_LocationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Locations_RequestType Get_Locations_Request)
		{
			return ((Human_ResourcesPort)this).Get_LocationsAsync(new Get_LocationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Locations_Request = Get_Locations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Previous_System_Job_HistoryOutput Human_ResourcesPort.Get_Previous_System_Job_History(Get_Previous_System_Job_HistoryInput request)
		{
			return base.Channel.Get_Previous_System_Job_History(request);
		}

		public Get_Previous_System_Job_History_ResponseType Get_Previous_System_Job_History(Workday_Common_HeaderType Workday_Common_Header, Get_Previous_System_Job_History_RequestType Get_Previous_System_Job_History_Request)
		{
			return ((Human_ResourcesPort)this).Get_Previous_System_Job_History(new Get_Previous_System_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Previous_System_Job_History_Request = Get_Previous_System_Job_History_Request
			}).Get_Previous_System_Job_History_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Previous_System_Job_HistoryOutput> Human_ResourcesPort.Get_Previous_System_Job_HistoryAsync(Get_Previous_System_Job_HistoryInput request)
		{
			return base.Channel.Get_Previous_System_Job_HistoryAsync(request);
		}

		public Task<Get_Previous_System_Job_HistoryOutput> Get_Previous_System_Job_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Previous_System_Job_History_RequestType Get_Previous_System_Job_History_Request)
		{
			return ((Human_ResourcesPort)this).Get_Previous_System_Job_HistoryAsync(new Get_Previous_System_Job_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Previous_System_Job_History_Request = Get_Previous_System_Job_History_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Server_TimestampOutput Human_ResourcesPort.Get_Server_Timestamp(Get_Server_TimestampInput request)
		{
			return base.Channel.Get_Server_Timestamp(request);
		}

		public Server_TimestampType Get_Server_Timestamp(Workday_Common_HeaderType Workday_Common_Header, Server_Timestamp_GetType Server_Timestamp_Get)
		{
			return ((Human_ResourcesPort)this).Get_Server_Timestamp(new Get_Server_TimestampInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Server_Timestamp_Get = Server_Timestamp_Get
			}).Server_Timestamp;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Server_TimestampOutput> Human_ResourcesPort.Get_Server_TimestampAsync(Get_Server_TimestampInput request)
		{
			return base.Channel.Get_Server_TimestampAsync(request);
		}

		public Task<Get_Server_TimestampOutput> Get_Server_TimestampAsync(Workday_Common_HeaderType Workday_Common_Header, Server_Timestamp_GetType Server_Timestamp_Get)
		{
			return ((Human_ResourcesPort)this).Get_Server_TimestampAsync(new Get_Server_TimestampInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Server_Timestamp_Get = Server_Timestamp_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Employee_ImageOutput Human_ResourcesPort.Update_Employee_Image(Update_Employee_ImageInput request)
		{
			return base.Channel.Update_Employee_Image(request);
		}

		public void Update_Employee_Image(Workday_Common_HeaderType Workday_Common_Header, Employee_Image_UpdateType Employee_Image_Update)
		{
			((Human_ResourcesPort)this).Update_Employee_Image(new Update_Employee_ImageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Image_Update = Employee_Image_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Employee_ImageOutput> Human_ResourcesPort.Update_Employee_ImageAsync(Update_Employee_ImageInput request)
		{
			return base.Channel.Update_Employee_ImageAsync(request);
		}

		public Task<Update_Employee_ImageOutput> Update_Employee_ImageAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Image_UpdateType Employee_Image_Update)
		{
			return ((Human_ResourcesPort)this).Update_Employee_ImageAsync(new Update_Employee_ImageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Image_Update = Employee_Image_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_EmployeeOutput Human_ResourcesPort.Get_Employee(Get_EmployeeInput request)
		{
			return base.Channel.Get_Employee(request);
		}

		public EmployeeType Get_Employee(Workday_Common_HeaderType Workday_Common_Header, Employee_GetType Employee_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee(new Get_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Get = Employee_Get
			}).Employee;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_EmployeeOutput> Human_ResourcesPort.Get_EmployeeAsync(Get_EmployeeInput request)
		{
			return base.Channel.Get_EmployeeAsync(request);
		}

		public Task<Get_EmployeeOutput> Get_EmployeeAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_GetType Employee_Get)
		{
			return ((Human_ResourcesPort)this).Get_EmployeeAsync(new Get_EmployeeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Get = Employee_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Contingent_WorkerOutput Human_ResourcesPort.Get_Contingent_Worker(Get_Contingent_WorkerInput request)
		{
			return base.Channel.Get_Contingent_Worker(request);
		}

		public Contingent_WorkerType Get_Contingent_Worker(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_GetType Contingent_Worker_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_Worker(new Get_Contingent_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Get = Contingent_Worker_Get
			}).Contingent_Worker;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Contingent_WorkerOutput> Human_ResourcesPort.Get_Contingent_WorkerAsync(Get_Contingent_WorkerInput request)
		{
			return base.Channel.Get_Contingent_WorkerAsync(request);
		}

		public Task<Get_Contingent_WorkerOutput> Get_Contingent_WorkerAsync(Workday_Common_HeaderType Workday_Common_Header, Contingent_Worker_GetType Contingent_Worker_Get)
		{
			return ((Human_ResourcesPort)this).Get_Contingent_WorkerAsync(new Get_Contingent_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Contingent_Worker_Get = Contingent_Worker_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_Event_HistoryOutput Human_ResourcesPort.Get_Worker_Event_History(Get_Worker_Event_HistoryInput request)
		{
			return base.Channel.Get_Worker_Event_History(request);
		}

		public Worker_Event_HistoryType Get_Worker_Event_History(Workday_Common_HeaderType Workday_Common_Header, Worker_Event_History_GetType Worker_Event_History_Get)
		{
			return ((Human_ResourcesPort)this).Get_Worker_Event_History(new Get_Worker_Event_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Event_History_Get = Worker_Event_History_Get
			}).Worker_Event_History;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_Event_HistoryOutput> Human_ResourcesPort.Get_Worker_Event_HistoryAsync(Get_Worker_Event_HistoryInput request)
		{
			return base.Channel.Get_Worker_Event_HistoryAsync(request);
		}

		public Task<Get_Worker_Event_HistoryOutput> Get_Worker_Event_HistoryAsync(Workday_Common_HeaderType Workday_Common_Header, Worker_Event_History_GetType Worker_Event_History_Get)
		{
			return ((Human_ResourcesPort)this).Get_Worker_Event_HistoryAsync(new Get_Worker_Event_HistoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Worker_Event_History_Get = Worker_Event_History_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Workday_AccountOutput Human_ResourcesPort.Update_Workday_Account(Update_Workday_AccountInput request)
		{
			return base.Channel.Update_Workday_Account(request);
		}

		public void Update_Workday_Account(Workday_Common_HeaderType Workday_Common_Header, Workday_Account_for_Worker_UpdateType Workday_Account_for_Worker_Update)
		{
			((Human_ResourcesPort)this).Update_Workday_Account(new Update_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Workday_Account_for_Worker_Update = Workday_Account_for_Worker_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Workday_AccountOutput> Human_ResourcesPort.Update_Workday_AccountAsync(Update_Workday_AccountInput request)
		{
			return base.Channel.Update_Workday_AccountAsync(request);
		}

		public Task<Update_Workday_AccountOutput> Update_Workday_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Workday_Account_for_Worker_UpdateType Workday_Account_for_Worker_Update)
		{
			return ((Human_ResourcesPort)this).Update_Workday_AccountAsync(new Update_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Workday_Account_for_Worker_Update = Workday_Account_for_Worker_Update
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Add_Workday_AccountOutput Human_ResourcesPort.Add_Workday_Account(Add_Workday_AccountInput request)
		{
			return base.Channel.Add_Workday_Account(request);
		}

		public void Add_Workday_Account(Workday_Common_HeaderType Workday_Common_Header, Workday_Account_for_Worker_AddType Workday_Account_for_Worker_Add)
		{
			((Human_ResourcesPort)this).Add_Workday_Account(new Add_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Workday_Account_for_Worker_Add = Workday_Account_for_Worker_Add
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Add_Workday_AccountOutput> Human_ResourcesPort.Add_Workday_AccountAsync(Add_Workday_AccountInput request)
		{
			return base.Channel.Add_Workday_AccountAsync(request);
		}

		public Task<Add_Workday_AccountOutput> Add_Workday_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Workday_Account_for_Worker_AddType Workday_Account_for_Worker_Add)
		{
			return ((Human_ResourcesPort)this).Add_Workday_AccountAsync(new Add_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Workday_Account_for_Worker_Add = Workday_Account_for_Worker_Add
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Company_Insider_TypeOutput Human_ResourcesPort.Put_Company_Insider_Type(Put_Company_Insider_TypeInput request)
		{
			return base.Channel.Put_Company_Insider_Type(request);
		}

		public Put_Company_Insider_Type_ResponseType Put_Company_Insider_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Company_Insider_Type_RequestType Put_Company_Insider_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Company_Insider_Type(new Put_Company_Insider_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_Insider_Type_Request = Put_Company_Insider_Type_Request
			}).Put_Company_Insider_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Company_Insider_TypeOutput> Human_ResourcesPort.Put_Company_Insider_TypeAsync(Put_Company_Insider_TypeInput request)
		{
			return base.Channel.Put_Company_Insider_TypeAsync(request);
		}

		public Task<Put_Company_Insider_TypeOutput> Put_Company_Insider_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Company_Insider_Type_RequestType Put_Company_Insider_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Company_Insider_TypeAsync(new Put_Company_Insider_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Company_Insider_Type_Request = Put_Company_Insider_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Company_Insider_TypesOutput Human_ResourcesPort.Get_Company_Insider_Types(Get_Company_Insider_TypesInput request)
		{
			return base.Channel.Get_Company_Insider_Types(request);
		}

		public Get_Company_Insider_Types_ResponseType Get_Company_Insider_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Insider_Types_RequestType Get_Company_Insider_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Company_Insider_Types(new Get_Company_Insider_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Insider_Types_Request = Get_Company_Insider_Types_Request
			}).Get_Company_Insider_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Company_Insider_TypesOutput> Human_ResourcesPort.Get_Company_Insider_TypesAsync(Get_Company_Insider_TypesInput request)
		{
			return base.Channel.Get_Company_Insider_TypesAsync(request);
		}

		public Task<Get_Company_Insider_TypesOutput> Get_Company_Insider_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Insider_Types_RequestType Get_Company_Insider_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Company_Insider_TypesAsync(new Get_Company_Insider_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Company_Insider_Types_Request = Get_Company_Insider_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Employee_ImageOutput Human_ResourcesPort.Get_Employee_Image(Get_Employee_ImageInput request)
		{
			return base.Channel.Get_Employee_Image(request);
		}

		public Employee_ImageType Get_Employee_Image(Workday_Common_HeaderType Workday_Common_Header, Employee_Image_GetType Employee_Image_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_Image(new Get_Employee_ImageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Image_Get = Employee_Image_Get
			}).Employee_Image;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Employee_ImageOutput> Human_ResourcesPort.Get_Employee_ImageAsync(Get_Employee_ImageInput request)
		{
			return base.Channel.Get_Employee_ImageAsync(request);
		}

		public Task<Get_Employee_ImageOutput> Get_Employee_ImageAsync(Workday_Common_HeaderType Workday_Common_Header, Employee_Image_GetType Employee_Image_Get)
		{
			return ((Human_ResourcesPort)this).Get_Employee_ImageAsync(new Get_Employee_ImageInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Employee_Image_Get = Employee_Image_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Work_ShiftOutput Human_ResourcesPort.Put_Work_Shift(Put_Work_ShiftInput request)
		{
			return base.Channel.Put_Work_Shift(request);
		}

		public Put_Work_Shift_ResponseType Put_Work_Shift(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Shift_RequestType Put_Work_Shift_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_Shift(new Put_Work_ShiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Shift_Request = Put_Work_Shift_Request
			}).Put_Work_Shift_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Work_ShiftOutput> Human_ResourcesPort.Put_Work_ShiftAsync(Put_Work_ShiftInput request)
		{
			return base.Channel.Put_Work_ShiftAsync(request);
		}

		public Task<Put_Work_ShiftOutput> Put_Work_ShiftAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Shift_RequestType Put_Work_Shift_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_ShiftAsync(new Put_Work_ShiftInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Shift_Request = Put_Work_Shift_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Work_ShiftsOutput Human_ResourcesPort.Get_Work_Shifts(Get_Work_ShiftsInput request)
		{
			return base.Channel.Get_Work_Shifts(request);
		}

		public Get_Work_Shifts_ResponseType Get_Work_Shifts(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Shifts_RequestType Get_Work_Shifts_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_Shifts(new Get_Work_ShiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Shifts_Request = Get_Work_Shifts_Request
			}).Get_Work_Shifts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Work_ShiftsOutput> Human_ResourcesPort.Get_Work_ShiftsAsync(Get_Work_ShiftsInput request)
		{
			return base.Channel.Get_Work_ShiftsAsync(request);
		}

		public Task<Get_Work_ShiftsOutput> Get_Work_ShiftsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Shifts_RequestType Get_Work_Shifts_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_ShiftsAsync(new Get_Work_ShiftsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Shifts_Request = Get_Work_Shifts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_CategoryOutput Human_ResourcesPort.Put_Job_Category(Put_Job_CategoryInput request)
		{
			return base.Channel.Put_Job_Category(request);
		}

		public Put_Job_Category_ResponseType Put_Job_Category(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Category_RequestType Put_Job_Category_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Category(new Put_Job_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Category_Request = Put_Job_Category_Request
			}).Put_Job_Category_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_CategoryOutput> Human_ResourcesPort.Put_Job_CategoryAsync(Put_Job_CategoryInput request)
		{
			return base.Channel.Put_Job_CategoryAsync(request);
		}

		public Task<Put_Job_CategoryOutput> Put_Job_CategoryAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Category_RequestType Put_Job_Category_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_CategoryAsync(new Put_Job_CategoryInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Category_Request = Put_Job_Category_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_CategoriesOutput Human_ResourcesPort.Get_Job_Categories(Get_Job_CategoriesInput request)
		{
			return base.Channel.Get_Job_Categories(request);
		}

		public Get_Job_Categories_ResponseType Get_Job_Categories(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Categories_RequestType Get_Job_Categories_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Categories(new Get_Job_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Categories_Request = Get_Job_Categories_Request
			}).Get_Job_Categories_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_CategoriesOutput> Human_ResourcesPort.Get_Job_CategoriesAsync(Get_Job_CategoriesInput request)
		{
			return base.Channel.Get_Job_CategoriesAsync(request);
		}

		public Task<Get_Job_CategoriesOutput> Get_Job_CategoriesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Categories_RequestType Get_Job_Categories_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_CategoriesAsync(new Get_Job_CategoriesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Categories_Request = Get_Job_Categories_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_WorkersOutput Human_ResourcesPort.Get_Workers(Get_WorkersInput request)
		{
			return base.Channel.Get_Workers(request);
		}

		public Get_Workers_ResponseRootType Get_Workers(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_RequestType Get_Workers_Request)
		{
			return ((Human_ResourcesPort)this).Get_Workers(new Get_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Request = Get_Workers_Request
			}).Get_Workers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_WorkersOutput> Human_ResourcesPort.Get_WorkersAsync(Get_WorkersInput request)
		{
			return base.Channel.Get_WorkersAsync(request);
		}

		public Task<Get_WorkersOutput> Get_WorkersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_RequestType Get_Workers_Request)
		{
			return ((Human_ResourcesPort)this).Get_WorkersAsync(new Get_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Request = Get_Workers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DependentOutput Human_ResourcesPort.Put_Dependent(Put_DependentInput request)
		{
			return base.Channel.Put_Dependent(request);
		}

		public Put_Dependent_ResponseType Put_Dependent(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((Human_ResourcesPort)this).Put_Dependent(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			}).Put_Dependent_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DependentOutput> Human_ResourcesPort.Put_DependentAsync(Put_DependentInput request)
		{
			return base.Channel.Put_DependentAsync(request);
		}

		public Task<Put_DependentOutput> Put_DependentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Dependent_RequestType Put_Dependent_Request)
		{
			return ((Human_ResourcesPort)this).Put_DependentAsync(new Put_DependentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Dependent_Request = Put_Dependent_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrganizationsOutput Human_ResourcesPort.Get_Organizations(Get_OrganizationsInput request)
		{
			return base.Channel.Get_Organizations(request);
		}

		public Get_Organizations_ResponseType Get_Organizations(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Organizations(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			}).Get_Organizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrganizationsOutput> Human_ResourcesPort.Get_OrganizationsAsync(Get_OrganizationsInput request)
		{
			return base.Channel.Get_OrganizationsAsync(request);
		}

		public Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((Human_ResourcesPort)this).Get_OrganizationsAsync(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Workers_Compensation_CodeOutput Human_ResourcesPort.Put_Workers_Compensation_Code(Put_Workers_Compensation_CodeInput request)
		{
			return base.Channel.Put_Workers_Compensation_Code(request);
		}

		public Put_Workers_Compensation_Code_ResponseType Put_Workers_Compensation_Code(Workday_Common_HeaderType Workday_Common_Header, Put_Workers_Compensation_Code_RequestType Put_Workers_Compensation_Code_Request)
		{
			return ((Human_ResourcesPort)this).Put_Workers_Compensation_Code(new Put_Workers_Compensation_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Workers_Compensation_Code_Request = Put_Workers_Compensation_Code_Request
			}).Put_Workers_Compensation_Code_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Workers_Compensation_CodeOutput> Human_ResourcesPort.Put_Workers_Compensation_CodeAsync(Put_Workers_Compensation_CodeInput request)
		{
			return base.Channel.Put_Workers_Compensation_CodeAsync(request);
		}

		public Task<Put_Workers_Compensation_CodeOutput> Put_Workers_Compensation_CodeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Workers_Compensation_Code_RequestType Put_Workers_Compensation_Code_Request)
		{
			return ((Human_ResourcesPort)this).Put_Workers_Compensation_CodeAsync(new Put_Workers_Compensation_CodeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Workers_Compensation_Code_Request = Put_Workers_Compensation_Code_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workers_Compensation_CodesOutput Human_ResourcesPort.Get_Workers_Compensation_Codes(Get_Workers_Compensation_CodesInput request)
		{
			return base.Channel.Get_Workers_Compensation_Codes(request);
		}

		public Get_Workers_Compensation_Codes_ResponseType Get_Workers_Compensation_Codes(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_Compensation_Codes_RequestType Get_Workers_Compensation_Codes_Request)
		{
			return ((Human_ResourcesPort)this).Get_Workers_Compensation_Codes(new Get_Workers_Compensation_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Compensation_Codes_Request = Get_Workers_Compensation_Codes_Request
			}).Get_Workers_Compensation_Codes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workers_Compensation_CodesOutput> Human_ResourcesPort.Get_Workers_Compensation_CodesAsync(Get_Workers_Compensation_CodesInput request)
		{
			return base.Channel.Get_Workers_Compensation_CodesAsync(request);
		}

		public Task<Get_Workers_Compensation_CodesOutput> Get_Workers_Compensation_CodesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workers_Compensation_Codes_RequestType Get_Workers_Compensation_Codes_Request)
		{
			return ((Human_ResourcesPort)this).Get_Workers_Compensation_CodesAsync(new Get_Workers_Compensation_CodesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workers_Compensation_Codes_Request = Get_Workers_Compensation_Codes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Holiday_CalendarsOutput Human_ResourcesPort.Get_Holiday_Calendars(Get_Holiday_CalendarsInput request)
		{
			return base.Channel.Get_Holiday_Calendars(request);
		}

		public Get_Holiday_Calendars_ResponseType Get_Holiday_Calendars(Workday_Common_HeaderType Workday_Common_Header, Get_Holiday_Calendars_RequestType Get_Holiday_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Holiday_Calendars(new Get_Holiday_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Holiday_Calendars_Request = Get_Holiday_Calendars_Request
			}).Get_Holiday_Calendars_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Holiday_CalendarsOutput> Human_ResourcesPort.Get_Holiday_CalendarsAsync(Get_Holiday_CalendarsInput request)
		{
			return base.Channel.Get_Holiday_CalendarsAsync(request);
		}

		public Task<Get_Holiday_CalendarsOutput> Get_Holiday_CalendarsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Holiday_Calendars_RequestType Get_Holiday_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Holiday_CalendarsAsync(new Get_Holiday_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Holiday_Calendars_Request = Get_Holiday_Calendars_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Holiday_CalendarOutput Human_ResourcesPort.Put_Holiday_Calendar(Put_Holiday_CalendarInput request)
		{
			return base.Channel.Put_Holiday_Calendar(request);
		}

		public Put_Holiday_Calendar_ResponseType Put_Holiday_Calendar(Workday_Common_HeaderType Workday_Common_Header, Put_Holiday_Calendar_RequestType Put_Holiday_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Holiday_Calendar(new Put_Holiday_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Holiday_Calendar_Request = Put_Holiday_Calendar_Request
			}).Put_Holiday_Calendar_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Holiday_CalendarOutput> Human_ResourcesPort.Put_Holiday_CalendarAsync(Put_Holiday_CalendarInput request)
		{
			return base.Channel.Put_Holiday_CalendarAsync(request);
		}

		public Task<Put_Holiday_CalendarOutput> Put_Holiday_CalendarAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Holiday_Calendar_RequestType Put_Holiday_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Holiday_CalendarAsync(new Put_Holiday_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Holiday_Calendar_Request = Put_Holiday_Calendar_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Work_Schedule_CalendarsOutput Human_ResourcesPort.Get_Work_Schedule_Calendars(Get_Work_Schedule_CalendarsInput request)
		{
			return base.Channel.Get_Work_Schedule_Calendars(request);
		}

		public Get_Work_Schedule_Calendars_ResponseType Get_Work_Schedule_Calendars(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Schedule_Calendars_RequestType Get_Work_Schedule_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_Schedule_Calendars(new Get_Work_Schedule_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Schedule_Calendars_Request = Get_Work_Schedule_Calendars_Request
			}).Get_Work_Schedule_Calendars_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Work_Schedule_CalendarsOutput> Human_ResourcesPort.Get_Work_Schedule_CalendarsAsync(Get_Work_Schedule_CalendarsInput request)
		{
			return base.Channel.Get_Work_Schedule_CalendarsAsync(request);
		}

		public Task<Get_Work_Schedule_CalendarsOutput> Get_Work_Schedule_CalendarsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Schedule_Calendars_RequestType Get_Work_Schedule_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_Schedule_CalendarsAsync(new Get_Work_Schedule_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Schedule_Calendars_Request = Get_Work_Schedule_Calendars_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Work_Schedule_CalendarOutput Human_ResourcesPort.Put_Work_Schedule_Calendar(Put_Work_Schedule_CalendarInput request)
		{
			return base.Channel.Put_Work_Schedule_Calendar(request);
		}

		public Put_Work_Schedule_Calendar_ResponseType Put_Work_Schedule_Calendar(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Schedule_Calendar_RequestType Put_Work_Schedule_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_Schedule_Calendar(new Put_Work_Schedule_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Schedule_Calendar_Request = Put_Work_Schedule_Calendar_Request
			}).Put_Work_Schedule_Calendar_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Work_Schedule_CalendarOutput> Human_ResourcesPort.Put_Work_Schedule_CalendarAsync(Put_Work_Schedule_CalendarInput request)
		{
			return base.Channel.Put_Work_Schedule_CalendarAsync(request);
		}

		public Task<Put_Work_Schedule_CalendarOutput> Put_Work_Schedule_CalendarAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Schedule_Calendar_RequestType Put_Work_Schedule_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_Schedule_CalendarAsync(new Put_Work_Schedule_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Schedule_Calendar_Request = Put_Work_Schedule_Calendar_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Supervisory_Organization_Assignment_RestrictionsOutput Human_ResourcesPort.Get_Supervisory_Organization_Assignment_Restrictions(Get_Supervisory_Organization_Assignment_RestrictionsInput request)
		{
			return base.Channel.Get_Supervisory_Organization_Assignment_Restrictions(request);
		}

		public Get_Organization_Assignment_Restrictions_ResponseType Get_Supervisory_Organization_Assignment_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Assignment_Restrictions_RequestType Get_Organization_Assignment_Restrictions_Request)
		{
			return ((Human_ResourcesPort)this).Get_Supervisory_Organization_Assignment_Restrictions(new Get_Supervisory_Organization_Assignment_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organization_Assignment_Restrictions_Request = Get_Organization_Assignment_Restrictions_Request
			}).Get_Organization_Assignment_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Supervisory_Organization_Assignment_RestrictionsOutput> Human_ResourcesPort.Get_Supervisory_Organization_Assignment_RestrictionsAsync(Get_Supervisory_Organization_Assignment_RestrictionsInput request)
		{
			return base.Channel.Get_Supervisory_Organization_Assignment_RestrictionsAsync(request);
		}

		public Task<Get_Supervisory_Organization_Assignment_RestrictionsOutput> Get_Supervisory_Organization_Assignment_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Assignment_Restrictions_RequestType Get_Organization_Assignment_Restrictions_Request)
		{
			return ((Human_ResourcesPort)this).Get_Supervisory_Organization_Assignment_RestrictionsAsync(new Get_Supervisory_Organization_Assignment_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organization_Assignment_Restrictions_Request = Get_Organization_Assignment_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Supervisory_Organization_Assignment_RestrictionsOutput Human_ResourcesPort.Put_Supervisory_Organization_Assignment_Restrictions(Put_Supervisory_Organization_Assignment_RestrictionsInput request)
		{
			return base.Channel.Put_Supervisory_Organization_Assignment_Restrictions(request);
		}

		public Put_Organization_Assignment_Restrictions_ResponseType Put_Supervisory_Organization_Assignment_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Assignment_Restrictions_RequestType Put_Organization_Assignment_Restrictions_Request)
		{
			return ((Human_ResourcesPort)this).Put_Supervisory_Organization_Assignment_Restrictions(new Put_Supervisory_Organization_Assignment_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Organization_Assignment_Restrictions_Request = Put_Organization_Assignment_Restrictions_Request
			}).Put_Organization_Assignment_Restrictions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Supervisory_Organization_Assignment_RestrictionsOutput> Human_ResourcesPort.Put_Supervisory_Organization_Assignment_RestrictionsAsync(Put_Supervisory_Organization_Assignment_RestrictionsInput request)
		{
			return base.Channel.Put_Supervisory_Organization_Assignment_RestrictionsAsync(request);
		}

		public Task<Put_Supervisory_Organization_Assignment_RestrictionsOutput> Put_Supervisory_Organization_Assignment_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Assignment_Restrictions_RequestType Put_Organization_Assignment_Restrictions_Request)
		{
			return ((Human_ResourcesPort)this).Put_Supervisory_Organization_Assignment_RestrictionsAsync(new Put_Supervisory_Organization_Assignment_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Organization_Assignment_Restrictions_Request = Put_Organization_Assignment_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_FrequenciesOutput Human_ResourcesPort.Get_Frequencies(Get_FrequenciesInput request)
		{
			return base.Channel.Get_Frequencies(request);
		}

		public Get_Frequencies_ResponseType Get_Frequencies(Workday_Common_HeaderType Workday_Common_Header, Get_Frequencies_RequestType Get_Frequencies_Request)
		{
			return ((Human_ResourcesPort)this).Get_Frequencies(new Get_FrequenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Frequencies_Request = Get_Frequencies_Request
			}).Get_Frequencies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_FrequenciesOutput> Human_ResourcesPort.Get_FrequenciesAsync(Get_FrequenciesInput request)
		{
			return base.Channel.Get_FrequenciesAsync(request);
		}

		public Task<Get_FrequenciesOutput> Get_FrequenciesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Frequencies_RequestType Get_Frequencies_Request)
		{
			return ((Human_ResourcesPort)this).Get_FrequenciesAsync(new Get_FrequenciesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Frequencies_Request = Get_Frequencies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_FrequencyOutput Human_ResourcesPort.Put_Frequency(Put_FrequencyInput request)
		{
			return base.Channel.Put_Frequency(request);
		}

		public Put_Frequency_ResponseType Put_Frequency(Workday_Common_HeaderType Workday_Common_Header, Put_Frequency_RequestType Put_Frequency_Request)
		{
			return ((Human_ResourcesPort)this).Put_Frequency(new Put_FrequencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Frequency_Request = Put_Frequency_Request
			}).Put_Frequency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_FrequencyOutput> Human_ResourcesPort.Put_FrequencyAsync(Put_FrequencyInput request)
		{
			return base.Channel.Put_FrequencyAsync(request);
		}

		public Task<Put_FrequencyOutput> Put_FrequencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Frequency_RequestType Put_Frequency_Request)
		{
			return ((Human_ResourcesPort)this).Put_FrequencyAsync(new Put_FrequencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Frequency_Request = Put_Frequency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_DisabilitiesOutput Human_ResourcesPort.Get_Disabilities(Get_DisabilitiesInput request)
		{
			return base.Channel.Get_Disabilities(request);
		}

		public Get_Disabilities_ResponseType Get_Disabilities(Workday_Common_HeaderType Workday_Common_Header, Get_Disabilities_RequestType Get_Disabilities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Disabilities(new Get_DisabilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Disabilities_Request = Get_Disabilities_Request
			}).Get_Disabilities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_DisabilitiesOutput> Human_ResourcesPort.Get_DisabilitiesAsync(Get_DisabilitiesInput request)
		{
			return base.Channel.Get_DisabilitiesAsync(request);
		}

		public Task<Get_DisabilitiesOutput> Get_DisabilitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Disabilities_RequestType Get_Disabilities_Request)
		{
			return ((Human_ResourcesPort)this).Get_DisabilitiesAsync(new Get_DisabilitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Disabilities_Request = Get_Disabilities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_DisabilityOutput Human_ResourcesPort.Put_Disability(Put_DisabilityInput request)
		{
			return base.Channel.Put_Disability(request);
		}

		public Put_Disability_ResponseType Put_Disability(Workday_Common_HeaderType Workday_Common_Header, Put_Disability_RequestType Put_Disability_Request)
		{
			return ((Human_ResourcesPort)this).Put_Disability(new Put_DisabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Disability_Request = Put_Disability_Request
			}).Put_Disability_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_DisabilityOutput> Human_ResourcesPort.Put_DisabilityAsync(Put_DisabilityInput request)
		{
			return base.Channel.Put_DisabilityAsync(request);
		}

		public Task<Put_DisabilityOutput> Put_DisabilityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Disability_RequestType Put_Disability_Request)
		{
			return ((Human_ResourcesPort)this).Put_DisabilityAsync(new Put_DisabilityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Disability_Request = Put_Disability_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_ProfileOutput Human_ResourcesPort.Put_Job_Profile(Put_Job_ProfileInput request)
		{
			return base.Channel.Put_Job_Profile(request);
		}

		public Put_Job_Profile_ResponseType Put_Job_Profile(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Profile_RequestType Put_Job_Profile_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Profile(new Put_Job_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Profile_Request = Put_Job_Profile_Request
			}).Put_Job_Profile_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_ProfileOutput> Human_ResourcesPort.Put_Job_ProfileAsync(Put_Job_ProfileInput request)
		{
			return base.Channel.Put_Job_ProfileAsync(request);
		}

		public Task<Put_Job_ProfileOutput> Put_Job_ProfileAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Profile_RequestType Put_Job_Profile_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_ProfileAsync(new Put_Job_ProfileInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Profile_Request = Put_Job_Profile_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_ProfilesOutput Human_ResourcesPort.Get_Job_Profiles(Get_Job_ProfilesInput request)
		{
			return base.Channel.Get_Job_Profiles(request);
		}

		public Get_Job_Profiles_ResponseType Get_Job_Profiles(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Profiles_RequestType Get_Job_Profiles_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Profiles(new Get_Job_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Profiles_Request = Get_Job_Profiles_Request
			}).Get_Job_Profiles_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_ProfilesOutput> Human_ResourcesPort.Get_Job_ProfilesAsync(Get_Job_ProfilesInput request)
		{
			return base.Channel.Get_Job_ProfilesAsync(request);
		}

		public Task<Get_Job_ProfilesOutput> Get_Job_ProfilesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Profiles_RequestType Get_Job_Profiles_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_ProfilesAsync(new Get_Job_ProfilesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Profiles_Request = Get_Job_Profiles_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_EthnicitiesOutput Human_ResourcesPort.Get_Ethnicities(Get_EthnicitiesInput request)
		{
			return base.Channel.Get_Ethnicities(request);
		}

		public Get_Ethnicities_ResponseType Get_Ethnicities(Workday_Common_HeaderType Workday_Common_Header, Get_Ethnicities_RequestType Get_Ethnicities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Ethnicities(new Get_EthnicitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ethnicities_Request = Get_Ethnicities_Request
			}).Get_Ethnicities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_EthnicitiesOutput> Human_ResourcesPort.Get_EthnicitiesAsync(Get_EthnicitiesInput request)
		{
			return base.Channel.Get_EthnicitiesAsync(request);
		}

		public Task<Get_EthnicitiesOutput> Get_EthnicitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Ethnicities_RequestType Get_Ethnicities_Request)
		{
			return ((Human_ResourcesPort)this).Get_EthnicitiesAsync(new Get_EthnicitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Ethnicities_Request = Get_Ethnicities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_EthnicityOutput Human_ResourcesPort.Put_Ethnicity(Put_EthnicityInput request)
		{
			return base.Channel.Put_Ethnicity(request);
		}

		public Put_Ethnicity_ResponseType Put_Ethnicity(Workday_Common_HeaderType Workday_Common_Header, Put_Ethnicity_RequestType Put_Ethnicity_Request)
		{
			return ((Human_ResourcesPort)this).Put_Ethnicity(new Put_EthnicityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ethnicity_Request = Put_Ethnicity_Request
			}).Put_Ethnicity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_EthnicityOutput> Human_ResourcesPort.Put_EthnicityAsync(Put_EthnicityInput request)
		{
			return base.Channel.Put_EthnicityAsync(request);
		}

		public Task<Put_EthnicityOutput> Put_EthnicityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Ethnicity_RequestType Put_Ethnicity_Request)
		{
			return ((Human_ResourcesPort)this).Put_EthnicityAsync(new Put_EthnicityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Ethnicity_Request = Put_Ethnicity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Training_TypesOutput Human_ResourcesPort.Get_Training_Types(Get_Training_TypesInput request)
		{
			return base.Channel.Get_Training_Types(request);
		}

		public Get_Training_Types_ResponseType Get_Training_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Training_Types_RequestType Get_Training_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Training_Types(new Get_Training_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Training_Types_Request = Get_Training_Types_Request
			}).Get_Training_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Training_TypesOutput> Human_ResourcesPort.Get_Training_TypesAsync(Get_Training_TypesInput request)
		{
			return base.Channel.Get_Training_TypesAsync(request);
		}

		public Task<Get_Training_TypesOutput> Get_Training_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Training_Types_RequestType Get_Training_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Training_TypesAsync(new Get_Training_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Training_Types_Request = Get_Training_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Training_TypeOutput Human_ResourcesPort.Put_Training_Type(Put_Training_TypeInput request)
		{
			return base.Channel.Put_Training_Type(request);
		}

		public Put_Training_Type_ResponseType Put_Training_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Training_Type_RequestType Put_Training_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Training_Type(new Put_Training_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Training_Type_Request = Put_Training_Type_Request
			}).Put_Training_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Training_TypeOutput> Human_ResourcesPort.Put_Training_TypeAsync(Put_Training_TypeInput request)
		{
			return base.Channel.Put_Training_TypeAsync(request);
		}

		public Task<Put_Training_TypeOutput> Put_Training_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Training_Type_RequestType Put_Training_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Training_TypeAsync(new Put_Training_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Training_Type_Request = Put_Training_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Classification_GroupsOutput Human_ResourcesPort.Get_Job_Classification_Groups(Get_Job_Classification_GroupsInput request)
		{
			return base.Channel.Get_Job_Classification_Groups(request);
		}

		public Get_Job_Classification_Groups_ResponseType Get_Job_Classification_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Classification_Groups_RequestType Get_Job_Classification_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Classification_Groups(new Get_Job_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Classification_Groups_Request = Get_Job_Classification_Groups_Request
			}).Get_Job_Classification_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Classification_GroupsOutput> Human_ResourcesPort.Get_Job_Classification_GroupsAsync(Get_Job_Classification_GroupsInput request)
		{
			return base.Channel.Get_Job_Classification_GroupsAsync(request);
		}

		public Task<Get_Job_Classification_GroupsOutput> Get_Job_Classification_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Classification_Groups_RequestType Get_Job_Classification_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Classification_GroupsAsync(new Get_Job_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Classification_Groups_Request = Get_Job_Classification_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Classification_GroupOutput Human_ResourcesPort.Put_Job_Classification_Group(Put_Job_Classification_GroupInput request)
		{
			return base.Channel.Put_Job_Classification_Group(request);
		}

		public Put_Job_Classification_Group_ResponseType Put_Job_Classification_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Classification_Group_RequestType Put_Job_Classification_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Classification_Group(new Put_Job_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Classification_Group_Request = Put_Job_Classification_Group_Request
			}).Put_Job_Classification_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Classification_GroupOutput> Human_ResourcesPort.Put_Job_Classification_GroupAsync(Put_Job_Classification_GroupInput request)
		{
			return base.Channel.Put_Job_Classification_GroupAsync(request);
		}

		public Task<Put_Job_Classification_GroupOutput> Put_Job_Classification_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Classification_Group_RequestType Put_Job_Classification_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Classification_GroupAsync(new Put_Job_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Classification_Group_Request = Put_Job_Classification_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_FamiliesOutput Human_ResourcesPort.Get_Job_Families(Get_Job_FamiliesInput request)
		{
			return base.Channel.Get_Job_Families(request);
		}

		public Get_Job_Families_ResponseType Get_Job_Families(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Families_RequestType Get_Job_Families_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Families(new Get_Job_FamiliesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Families_Request = Get_Job_Families_Request
			}).Get_Job_Families_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_FamiliesOutput> Human_ResourcesPort.Get_Job_FamiliesAsync(Get_Job_FamiliesInput request)
		{
			return base.Channel.Get_Job_FamiliesAsync(request);
		}

		public Task<Get_Job_FamiliesOutput> Get_Job_FamiliesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Families_RequestType Get_Job_Families_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_FamiliesAsync(new Get_Job_FamiliesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Families_Request = Get_Job_Families_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_FamilyOutput Human_ResourcesPort.Put_Job_Family(Put_Job_FamilyInput request)
		{
			return base.Channel.Put_Job_Family(request);
		}

		public Put_Job_Family_ResponseType Put_Job_Family(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_RequestType Put_Job_Family_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Family(new Put_Job_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Request = Put_Job_Family_Request
			}).Put_Job_Family_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_FamilyOutput> Human_ResourcesPort.Put_Job_FamilyAsync(Put_Job_FamilyInput request)
		{
			return base.Channel.Put_Job_FamilyAsync(request);
		}

		public Task<Put_Job_FamilyOutput> Put_Job_FamilyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_RequestType Put_Job_Family_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_FamilyAsync(new Put_Job_FamilyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Request = Put_Job_Family_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Family_GroupsOutput Human_ResourcesPort.Get_Job_Family_Groups(Get_Job_Family_GroupsInput request)
		{
			return base.Channel.Get_Job_Family_Groups(request);
		}

		public Get_Job_Family_Groups_ResponseType Get_Job_Family_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Family_Groups_RequestType Get_Job_Family_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Family_Groups(new Get_Job_Family_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Family_Groups_Request = Get_Job_Family_Groups_Request
			}).Get_Job_Family_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Family_GroupsOutput> Human_ResourcesPort.Get_Job_Family_GroupsAsync(Get_Job_Family_GroupsInput request)
		{
			return base.Channel.Get_Job_Family_GroupsAsync(request);
		}

		public Task<Get_Job_Family_GroupsOutput> Get_Job_Family_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Family_Groups_RequestType Get_Job_Family_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Job_Family_GroupsAsync(new Get_Job_Family_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Family_Groups_Request = Get_Job_Family_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Family_GroupOutput Human_ResourcesPort.Put_Job_Family_Group(Put_Job_Family_GroupInput request)
		{
			return base.Channel.Put_Job_Family_Group(request);
		}

		public Put_Job_Family_Group_ResponseType Put_Job_Family_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_Group_RequestType Put_Job_Family_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Family_Group(new Put_Job_Family_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Group_Request = Put_Job_Family_Group_Request
			}).Put_Job_Family_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Family_GroupOutput> Human_ResourcesPort.Put_Job_Family_GroupAsync(Put_Job_Family_GroupInput request)
		{
			return base.Channel.Put_Job_Family_GroupAsync(request);
		}

		public Task<Put_Job_Family_GroupOutput> Put_Job_Family_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Family_Group_RequestType Put_Job_Family_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Job_Family_GroupAsync(new Put_Job_Family_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Family_Group_Request = Put_Job_Family_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_UserBased_Security_Group_AssignmentsOutput Human_ResourcesPort.Put_UserBased_Security_Group_Assignments(Put_UserBased_Security_Group_AssignmentsInput request)
		{
			return base.Channel.Put_UserBased_Security_Group_Assignments(request);
		}

		public Put_Assign_UserBased_Security_Groups_ResponseType Put_UserBased_Security_Group_Assignments(Workday_Common_HeaderType Workday_Common_Header, Put_Assign_UserBased_Security_Groups_RequestType Put_Assign_UserBased_Security_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Put_UserBased_Security_Group_Assignments(new Put_UserBased_Security_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Assign_UserBased_Security_Groups_Request = Put_Assign_UserBased_Security_Groups_Request
			}).Put_Assign_UserBased_Security_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_UserBased_Security_Group_AssignmentsOutput> Human_ResourcesPort.Put_UserBased_Security_Group_AssignmentsAsync(Put_UserBased_Security_Group_AssignmentsInput request)
		{
			return base.Channel.Put_UserBased_Security_Group_AssignmentsAsync(request);
		}

		public Task<Put_UserBased_Security_Group_AssignmentsOutput> Put_UserBased_Security_Group_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Assign_UserBased_Security_Groups_RequestType Put_Assign_UserBased_Security_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Put_UserBased_Security_Group_AssignmentsAsync(new Put_UserBased_Security_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Assign_UserBased_Security_Groups_Request = Put_Assign_UserBased_Security_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_UserBased_Security_Group_AssignmentsOutput Human_ResourcesPort.Get_UserBased_Security_Group_Assignments(Get_UserBased_Security_Group_AssignmentsInput request)
		{
			return base.Channel.Get_UserBased_Security_Group_Assignments(request);
		}

		public Get_Assign_UserBased_Security_Groups_ResponseType Get_UserBased_Security_Group_Assignments(Workday_Common_HeaderType Workday_Common_Header, Get_Assign_UserBased_Security_Groups_RequestType Get_Assign_UserBased_Security_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_UserBased_Security_Group_Assignments(new Get_UserBased_Security_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assign_UserBased_Security_Groups_Request = Get_Assign_UserBased_Security_Groups_Request
			}).Get_Assign_UserBased_Security_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_UserBased_Security_Group_AssignmentsOutput> Human_ResourcesPort.Get_UserBased_Security_Group_AssignmentsAsync(Get_UserBased_Security_Group_AssignmentsInput request)
		{
			return base.Channel.Get_UserBased_Security_Group_AssignmentsAsync(request);
		}

		public Task<Get_UserBased_Security_Group_AssignmentsOutput> Get_UserBased_Security_Group_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Assign_UserBased_Security_Groups_RequestType Get_Assign_UserBased_Security_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_UserBased_Security_Group_AssignmentsAsync(new Get_UserBased_Security_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assign_UserBased_Security_Groups_Request = Get_Assign_UserBased_Security_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Difficulty_to_FillOutput Human_ResourcesPort.Get_Difficulty_to_Fill(Get_Difficulty_to_FillInput request)
		{
			return base.Channel.Get_Difficulty_to_Fill(request);
		}

		public Get_Difficulty_to_Fill_ResponseType Get_Difficulty_to_Fill(Workday_Common_HeaderType Workday_Common_Header, Get_Difficulty_to_Fill_RequestType Get_Difficulty_to_Fill_Request)
		{
			return ((Human_ResourcesPort)this).Get_Difficulty_to_Fill(new Get_Difficulty_to_FillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Difficulty_to_Fill_Request = Get_Difficulty_to_Fill_Request
			}).Get_Difficulty_to_Fill_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Difficulty_to_FillOutput> Human_ResourcesPort.Get_Difficulty_to_FillAsync(Get_Difficulty_to_FillInput request)
		{
			return base.Channel.Get_Difficulty_to_FillAsync(request);
		}

		public Task<Get_Difficulty_to_FillOutput> Get_Difficulty_to_FillAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Difficulty_to_Fill_RequestType Get_Difficulty_to_Fill_Request)
		{
			return ((Human_ResourcesPort)this).Get_Difficulty_to_FillAsync(new Get_Difficulty_to_FillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Difficulty_to_Fill_Request = Get_Difficulty_to_Fill_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Difficulty_to_FillOutput Human_ResourcesPort.Put_Difficulty_to_Fill(Put_Difficulty_to_FillInput request)
		{
			return base.Channel.Put_Difficulty_to_Fill(request);
		}

		public Put_Difficulty_to_Fill_ResponseType Put_Difficulty_to_Fill(Workday_Common_HeaderType Workday_Common_Header, Put_Difficulty_to_Fill_RequestType Put_Difficulty_to_Fill_Request)
		{
			return ((Human_ResourcesPort)this).Put_Difficulty_to_Fill(new Put_Difficulty_to_FillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Difficulty_to_Fill_Request = Put_Difficulty_to_Fill_Request
			}).Put_Difficulty_to_Fill_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Difficulty_to_FillOutput> Human_ResourcesPort.Put_Difficulty_to_FillAsync(Put_Difficulty_to_FillInput request)
		{
			return base.Channel.Put_Difficulty_to_FillAsync(request);
		}

		public Task<Put_Difficulty_to_FillOutput> Put_Difficulty_to_FillAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Difficulty_to_Fill_RequestType Put_Difficulty_to_Fill_Request)
		{
			return ((Human_ResourcesPort)this).Put_Difficulty_to_FillAsync(new Put_Difficulty_to_FillInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Difficulty_to_Fill_Request = Put_Difficulty_to_Fill_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Worker_PhotosOutput Human_ResourcesPort.Get_Worker_Photos(Get_Worker_PhotosInput request)
		{
			return base.Channel.Get_Worker_Photos(request);
		}

		public Get_Worker_Photos_ResponseType Get_Worker_Photos(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Photos_RequestType Get_Worker_Photos_Request)
		{
			return ((Human_ResourcesPort)this).Get_Worker_Photos(new Get_Worker_PhotosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Photos_Request = Get_Worker_Photos_Request
			}).Get_Worker_Photos_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Worker_PhotosOutput> Human_ResourcesPort.Get_Worker_PhotosAsync(Get_Worker_PhotosInput request)
		{
			return base.Channel.Get_Worker_PhotosAsync(request);
		}

		public Task<Get_Worker_PhotosOutput> Get_Worker_PhotosAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Worker_Photos_RequestType Get_Worker_Photos_Request)
		{
			return ((Human_ResourcesPort)this).Get_Worker_PhotosAsync(new Get_Worker_PhotosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Worker_Photos_Request = Get_Worker_Photos_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Worker_PhotoOutput Human_ResourcesPort.Put_Worker_Photo(Put_Worker_PhotoInput request)
		{
			return base.Channel.Put_Worker_Photo(request);
		}

		public Put_Worker_Photo_ResponseType Put_Worker_Photo(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Photo_RequestType Put_Worker_Photo_Request)
		{
			return ((Human_ResourcesPort)this).Put_Worker_Photo(new Put_Worker_PhotoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Photo_Request = Put_Worker_Photo_Request
			}).Put_Worker_Photo_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Worker_PhotoOutput> Human_ResourcesPort.Put_Worker_PhotoAsync(Put_Worker_PhotoInput request)
		{
			return base.Channel.Put_Worker_PhotoAsync(request);
		}

		public Task<Put_Worker_PhotoOutput> Put_Worker_PhotoAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Worker_Photo_RequestType Put_Worker_Photo_Request)
		{
			return ((Human_ResourcesPort)this).Put_Worker_PhotoAsync(new Put_Worker_PhotoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Worker_Photo_Request = Put_Worker_Photo_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Union_MembershipOutput Human_ResourcesPort.Manage_Union_Membership(Manage_Union_MembershipInput request)
		{
			return base.Channel.Manage_Union_Membership(request);
		}

		public Manage_Union_Membership_ResponseType Manage_Union_Membership(Workday_Common_HeaderType Workday_Common_Header, Manage_Union_Membership_RequestType Manage_Union_Membership_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Union_Membership(new Manage_Union_MembershipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Union_Membership_Request = Manage_Union_Membership_Request
			}).Manage_Union_Membership_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Union_MembershipOutput> Human_ResourcesPort.Manage_Union_MembershipAsync(Manage_Union_MembershipInput request)
		{
			return base.Channel.Manage_Union_MembershipAsync(request);
		}

		public Task<Manage_Union_MembershipOutput> Manage_Union_MembershipAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Union_Membership_RequestType Manage_Union_Membership_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Union_MembershipAsync(new Manage_Union_MembershipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Union_Membership_Request = Manage_Union_Membership_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Academic_RanksOutput Human_ResourcesPort.Get_Academic_Ranks(Get_Academic_RanksInput request)
		{
			return base.Channel.Get_Academic_Ranks(request);
		}

		public Get_Academic_Ranks_ResponseType Get_Academic_Ranks(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Ranks_RequestType Get_Academic_Ranks_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_Ranks(new Get_Academic_RanksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Ranks_Request = Get_Academic_Ranks_Request
			}).Get_Academic_Ranks_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Academic_RanksOutput> Human_ResourcesPort.Get_Academic_RanksAsync(Get_Academic_RanksInput request)
		{
			return base.Channel.Get_Academic_RanksAsync(request);
		}

		public Task<Get_Academic_RanksOutput> Get_Academic_RanksAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Ranks_RequestType Get_Academic_Ranks_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_RanksAsync(new Get_Academic_RanksInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Ranks_Request = Get_Academic_Ranks_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Academic_RankOutput Human_ResourcesPort.Put_Academic_Rank(Put_Academic_RankInput request)
		{
			return base.Channel.Put_Academic_Rank(request);
		}

		public Put_Academic_Rank_ResponseType Put_Academic_Rank(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Rank_RequestType Put_Academic_Rank_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_Rank(new Put_Academic_RankInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Rank_Request = Put_Academic_Rank_Request
			}).Put_Academic_Rank_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Academic_RankOutput> Human_ResourcesPort.Put_Academic_RankAsync(Put_Academic_RankInput request)
		{
			return base.Channel.Put_Academic_RankAsync(request);
		}

		public Task<Put_Academic_RankOutput> Put_Academic_RankAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Rank_RequestType Put_Academic_Rank_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_RankAsync(new Put_Academic_RankInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Rank_Request = Put_Academic_Rank_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Academic_AppointmentOutput Human_ResourcesPort.End_Academic_Appointment(End_Academic_AppointmentInput request)
		{
			return base.Channel.End_Academic_Appointment(request);
		}

		public Academic_Appointment_ResponseType End_Academic_Appointment(Workday_Common_HeaderType Workday_Common_Header, End_Academic_Appointment_RequestType End_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).End_Academic_Appointment(new End_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Academic_Appointment_Request = End_Academic_Appointment_Request
			}).Academic_Appointment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Academic_AppointmentOutput> Human_ResourcesPort.End_Academic_AppointmentAsync(End_Academic_AppointmentInput request)
		{
			return base.Channel.End_Academic_AppointmentAsync(request);
		}

		public Task<End_Academic_AppointmentOutput> End_Academic_AppointmentAsync(Workday_Common_HeaderType Workday_Common_Header, End_Academic_Appointment_RequestType End_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).End_Academic_AppointmentAsync(new End_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Academic_Appointment_Request = End_Academic_Appointment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Provisioning_GroupsOutput Human_ResourcesPort.Get_Provisioning_Groups(Get_Provisioning_GroupsInput request)
		{
			return base.Channel.Get_Provisioning_Groups(request);
		}

		public Provisioning_Groups_ResponseType Get_Provisioning_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Provisioning_Groups_RequestType Get_Provisioning_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Provisioning_Groups(new Get_Provisioning_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Provisioning_Groups_Request = Get_Provisioning_Groups_Request
			}).Provisioning_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Provisioning_GroupsOutput> Human_ResourcesPort.Get_Provisioning_GroupsAsync(Get_Provisioning_GroupsInput request)
		{
			return base.Channel.Get_Provisioning_GroupsAsync(request);
		}

		public Task<Get_Provisioning_GroupsOutput> Get_Provisioning_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Provisioning_Groups_RequestType Get_Provisioning_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Provisioning_GroupsAsync(new Get_Provisioning_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Provisioning_Groups_Request = Get_Provisioning_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Academic_AppointmentOutput Human_ResourcesPort.Add_Academic_Appointment(Add_Academic_AppointmentInput request)
		{
			return base.Channel.Add_Academic_Appointment(request);
		}

		public Academic_Appointment_ResponseType Add_Academic_Appointment(Workday_Common_HeaderType Workday_Common_Header, Add_Academic_Appointment_RequestType Add_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).Add_Academic_Appointment(new Add_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Academic_Appointment_Request = Add_Academic_Appointment_Request
			}).Academic_Appointment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Academic_AppointmentOutput> Human_ResourcesPort.Add_Academic_AppointmentAsync(Add_Academic_AppointmentInput request)
		{
			return base.Channel.Add_Academic_AppointmentAsync(request);
		}

		public Task<End_Academic_AppointmentOutput> Add_Academic_AppointmentAsync(Workday_Common_HeaderType Workday_Common_Header, Add_Academic_Appointment_RequestType Add_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).Add_Academic_AppointmentAsync(new Add_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Add_Academic_Appointment_Request = Add_Academic_Appointment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Academic_AppointmentOutput Human_ResourcesPort.Update_Academic_Appointment(Update_Academic_AppointmentInput request)
		{
			return base.Channel.Update_Academic_Appointment(request);
		}

		public Academic_Appointment_ResponseType Update_Academic_Appointment(Workday_Common_HeaderType Workday_Common_Header, Update_Academic_Appointment_RequestType Update_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).Update_Academic_Appointment(new Update_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Academic_Appointment_Request = Update_Academic_Appointment_Request
			}).Academic_Appointment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Academic_AppointmentOutput> Human_ResourcesPort.Update_Academic_AppointmentAsync(Update_Academic_AppointmentInput request)
		{
			return base.Channel.Update_Academic_AppointmentAsync(request);
		}

		public Task<End_Academic_AppointmentOutput> Update_Academic_AppointmentAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Academic_Appointment_RequestType Update_Academic_Appointment_Request)
		{
			return ((Human_ResourcesPort)this).Update_Academic_AppointmentAsync(new Update_Academic_AppointmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Academic_Appointment_Request = Update_Academic_Appointment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Provisioning_GroupOutput Human_ResourcesPort.Put_Provisioning_Group(Put_Provisioning_GroupInput request)
		{
			return base.Channel.Put_Provisioning_Group(request);
		}

		public Put_Provisioning_Group_ResponseType Put_Provisioning_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Provisioning_Group_RequestType Put_Provisioning_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Provisioning_Group(new Put_Provisioning_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Provisioning_Group_Request = Put_Provisioning_Group_Request
			}).Put_Provisioning_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Provisioning_GroupOutput> Human_ResourcesPort.Put_Provisioning_GroupAsync(Put_Provisioning_GroupInput request)
		{
			return base.Channel.Put_Provisioning_GroupAsync(request);
		}

		public Task<Put_Provisioning_GroupOutput> Put_Provisioning_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Provisioning_Group_RequestType Put_Provisioning_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Provisioning_GroupAsync(new Put_Provisioning_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Provisioning_Group_Request = Put_Provisioning_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Provisioning_Group_AssignmentsOutput Human_ResourcesPort.Get_Provisioning_Group_Assignments(Get_Provisioning_Group_AssignmentsInput request)
		{
			return base.Channel.Get_Provisioning_Group_Assignments(request);
		}

		public Provisioning_Group_Assignments_ResponseType Get_Provisioning_Group_Assignments(Workday_Common_HeaderType Workday_Common_Header, Get_Provisioning_Group_Assignments_RequestType Get_Provisioning_Group_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Get_Provisioning_Group_Assignments(new Get_Provisioning_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Provisioning_Group_Assignments_Request = Get_Provisioning_Group_Assignments_Request
			}).Provisioning_Group_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Provisioning_Group_AssignmentsOutput> Human_ResourcesPort.Get_Provisioning_Group_AssignmentsAsync(Get_Provisioning_Group_AssignmentsInput request)
		{
			return base.Channel.Get_Provisioning_Group_AssignmentsAsync(request);
		}

		public Task<Get_Provisioning_Group_AssignmentsOutput> Get_Provisioning_Group_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Provisioning_Group_Assignments_RequestType Get_Provisioning_Group_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Get_Provisioning_Group_AssignmentsAsync(new Get_Provisioning_Group_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Provisioning_Group_Assignments_Request = Get_Provisioning_Group_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Provisioning_Group_AssignmentOutput Human_ResourcesPort.Put_Provisioning_Group_Assignment(Put_Provisioning_Group_AssignmentInput request)
		{
			return base.Channel.Put_Provisioning_Group_Assignment(request);
		}

		public Put_Provisioning_Group_Assignment_ResponseType Put_Provisioning_Group_Assignment(Workday_Common_HeaderType Workday_Common_Header, Put_Provisioning_Group_Assignment_RequestType Put_Provisioning_Group_Assignment_Request)
		{
			return ((Human_ResourcesPort)this).Put_Provisioning_Group_Assignment(new Put_Provisioning_Group_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Provisioning_Group_Assignment_Request = Put_Provisioning_Group_Assignment_Request
			}).Put_Provisioning_Group_Assignment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Provisioning_Group_AssignmentOutput> Human_ResourcesPort.Put_Provisioning_Group_AssignmentAsync(Put_Provisioning_Group_AssignmentInput request)
		{
			return base.Channel.Put_Provisioning_Group_AssignmentAsync(request);
		}

		public Task<Put_Provisioning_Group_AssignmentOutput> Put_Provisioning_Group_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Provisioning_Group_Assignment_RequestType Put_Provisioning_Group_Assignment_Request)
		{
			return ((Human_ResourcesPort)this).Put_Provisioning_Group_AssignmentAsync(new Put_Provisioning_Group_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Provisioning_Group_Assignment_Request = Put_Provisioning_Group_Assignment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Search_SettingsOutput Human_ResourcesPort.Get_Search_Settings(Get_Search_SettingsInput request)
		{
			return base.Channel.Get_Search_Settings(request);
		}

		public Get_Search_Settings_ResponseType Get_Search_Settings(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Settings_RequestType Get_Search_Settings_Request)
		{
			return ((Human_ResourcesPort)this).Get_Search_Settings(new Get_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Settings_Request = Get_Search_Settings_Request
			}).Get_Search_Settings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Search_SettingsOutput> Human_ResourcesPort.Get_Search_SettingsAsync(Get_Search_SettingsInput request)
		{
			return base.Channel.Get_Search_SettingsAsync(request);
		}

		public Task<Get_Search_SettingsOutput> Get_Search_SettingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Search_Settings_RequestType Get_Search_Settings_Request)
		{
			return ((Human_ResourcesPort)this).Get_Search_SettingsAsync(new Get_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Search_Settings_Request = Get_Search_Settings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Search_SettingsOutput Human_ResourcesPort.Put_Search_Settings(Put_Search_SettingsInput request)
		{
			return base.Channel.Put_Search_Settings(request);
		}

		public Put_Search_Settings_ResponseType Put_Search_Settings(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Settings_RequestType Put_Search_Settings_Request)
		{
			return ((Human_ResourcesPort)this).Put_Search_Settings(new Put_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Settings_Request = Put_Search_Settings_Request
			}).Put_Search_Settings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Search_SettingsOutput> Human_ResourcesPort.Put_Search_SettingsAsync(Put_Search_SettingsInput request)
		{
			return base.Channel.Put_Search_SettingsAsync(request);
		}

		public Task<Put_Search_SettingsOutput> Put_Search_SettingsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Settings_RequestType Put_Search_Settings_Request)
		{
			return ((Human_ResourcesPort)this).Put_Search_SettingsAsync(new Put_Search_SettingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Search_Settings_Request = Put_Search_Settings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Addresses_for_Country_Format_ExtensionOutput Human_ResourcesPort.Put_Addresses_for_Country_Format_Extension(Put_Addresses_for_Country_Format_ExtensionInput request)
		{
			return base.Channel.Put_Addresses_for_Country_Format_Extension(request);
		}

		public Put_Addresses_for_Country_Format_Extension_ResponseType Put_Addresses_for_Country_Format_Extension(Workday_Common_HeaderType Workday_Common_Header, Put_Addresses_for_Country_Format_Extension_RequestType Put_Addresses_for_Country_Format_Extension_Request)
		{
			return ((Human_ResourcesPort)this).Put_Addresses_for_Country_Format_Extension(new Put_Addresses_for_Country_Format_ExtensionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Addresses_for_Country_Format_Extension_Request = Put_Addresses_for_Country_Format_Extension_Request
			}).Put_Addresses_for_Country_Format_Extension_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Addresses_for_Country_Format_ExtensionOutput> Human_ResourcesPort.Put_Addresses_for_Country_Format_ExtensionAsync(Put_Addresses_for_Country_Format_ExtensionInput request)
		{
			return base.Channel.Put_Addresses_for_Country_Format_ExtensionAsync(request);
		}

		public Task<Put_Addresses_for_Country_Format_ExtensionOutput> Put_Addresses_for_Country_Format_ExtensionAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Addresses_for_Country_Format_Extension_RequestType Put_Addresses_for_Country_Format_Extension_Request)
		{
			return ((Human_ResourcesPort)this).Put_Addresses_for_Country_Format_ExtensionAsync(new Put_Addresses_for_Country_Format_ExtensionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Addresses_for_Country_Format_Extension_Request = Put_Addresses_for_Country_Format_Extension_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Maintain_Contact_InformationOutput Human_ResourcesPort.Maintain_Contact_Information(Maintain_Contact_InformationInput request)
		{
			return base.Channel.Maintain_Contact_Information(request);
		}

		public Maintain_Contact_Information_for_Person_Event_ResponseType Maintain_Contact_Information(Workday_Common_HeaderType Workday_Common_Header, Maintain_Contact_Information_for_Person_Event_RequestType Maintain_Contact_Information_for_Person_Event_Request)
		{
			return ((Human_ResourcesPort)this).Maintain_Contact_Information(new Maintain_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Contact_Information_for_Person_Event_Request = Maintain_Contact_Information_for_Person_Event_Request
			}).Maintain_Contact_Information_for_Person_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Maintain_Contact_InformationOutput> Human_ResourcesPort.Maintain_Contact_InformationAsync(Maintain_Contact_InformationInput request)
		{
			return base.Channel.Maintain_Contact_InformationAsync(request);
		}

		public Task<Maintain_Contact_InformationOutput> Maintain_Contact_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Maintain_Contact_Information_for_Person_Event_RequestType Maintain_Contact_Information_for_Person_Event_Request)
		{
			return ((Human_ResourcesPort)this).Maintain_Contact_InformationAsync(new Maintain_Contact_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Contact_Information_for_Person_Event_Request = Maintain_Contact_Information_for_Person_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Service_Center_RepresentativesOutput Human_ResourcesPort.Get_Service_Center_Representatives(Get_Service_Center_RepresentativesInput request)
		{
			return base.Channel.Get_Service_Center_Representatives(request);
		}

		public Get_Service_Center_Representatives_ResponseType Get_Service_Center_Representatives(Workday_Common_HeaderType Workday_Common_Header, Get_Service_Center_Representatives_RequestType Get_Service_Center_Representatives_Request)
		{
			return ((Human_ResourcesPort)this).Get_Service_Center_Representatives(new Get_Service_Center_RepresentativesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Service_Center_Representatives_Request = Get_Service_Center_Representatives_Request
			}).Get_Service_Center_Representatives_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Service_Center_RepresentativesOutput> Human_ResourcesPort.Get_Service_Center_RepresentativesAsync(Get_Service_Center_RepresentativesInput request)
		{
			return base.Channel.Get_Service_Center_RepresentativesAsync(request);
		}

		public Task<Get_Service_Center_RepresentativesOutput> Get_Service_Center_RepresentativesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Service_Center_Representatives_RequestType Get_Service_Center_Representatives_Request)
		{
			return ((Human_ResourcesPort)this).Get_Service_Center_RepresentativesAsync(new Get_Service_Center_RepresentativesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Service_Center_Representatives_Request = Get_Service_Center_Representatives_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Service_Center_RepresentativeOutput Human_ResourcesPort.Put_Service_Center_Representative(Put_Service_Center_RepresentativeInput request)
		{
			return base.Channel.Put_Service_Center_Representative(request);
		}

		public Put_Service_Center_Representative_ResponseType Put_Service_Center_Representative(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_RequestType Put_Service_Center_Representative_Request)
		{
			return ((Human_ResourcesPort)this).Put_Service_Center_Representative(new Put_Service_Center_RepresentativeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Service_Center_Representative_Request = Put_Service_Center_Representative_Request
			}).Put_Service_Center_Representative_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Service_Center_RepresentativeOutput> Human_ResourcesPort.Put_Service_Center_RepresentativeAsync(Put_Service_Center_RepresentativeInput request)
		{
			return base.Channel.Put_Service_Center_RepresentativeAsync(request);
		}

		public Task<Put_Service_Center_RepresentativeOutput> Put_Service_Center_RepresentativeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_RequestType Put_Service_Center_Representative_Request)
		{
			return ((Human_ResourcesPort)this).Put_Service_Center_RepresentativeAsync(new Put_Service_Center_RepresentativeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Service_Center_Representative_Request = Put_Service_Center_Representative_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Service_Center_Representative_Workday_AccountsOutput Human_ResourcesPort.Get_Service_Center_Representative_Workday_Accounts(Get_Service_Center_Representative_Workday_AccountsInput request)
		{
			return base.Channel.Get_Service_Center_Representative_Workday_Accounts(request);
		}

		public Get_Service_Center_Representative_Workday_Accounts_ResponseType Get_Service_Center_Representative_Workday_Accounts(Workday_Common_HeaderType Workday_Common_Header, Get_Service_Center_Representative_Workday_Accounts_RequestType Get_Service_Center_Representative_Workday_Accounts_Request)
		{
			return ((Human_ResourcesPort)this).Get_Service_Center_Representative_Workday_Accounts(new Get_Service_Center_Representative_Workday_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Service_Center_Representative_Workday_Accounts_Request = Get_Service_Center_Representative_Workday_Accounts_Request
			}).Get_Service_Center_Representative_Workday_Accounts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Service_Center_Representative_Workday_AccountsOutput> Human_ResourcesPort.Get_Service_Center_Representative_Workday_AccountsAsync(Get_Service_Center_Representative_Workday_AccountsInput request)
		{
			return base.Channel.Get_Service_Center_Representative_Workday_AccountsAsync(request);
		}

		public Task<Get_Service_Center_Representative_Workday_AccountsOutput> Get_Service_Center_Representative_Workday_AccountsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Service_Center_Representative_Workday_Accounts_RequestType Get_Service_Center_Representative_Workday_Accounts_Request)
		{
			return ((Human_ResourcesPort)this).Get_Service_Center_Representative_Workday_AccountsAsync(new Get_Service_Center_Representative_Workday_AccountsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Service_Center_Representative_Workday_Accounts_Request = Get_Service_Center_Representative_Workday_Accounts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Service_Center_Representative_Workday_AccountOutput Human_ResourcesPort.Put_Service_Center_Representative_Workday_Account(Put_Service_Center_Representative_Workday_AccountInput request)
		{
			return base.Channel.Put_Service_Center_Representative_Workday_Account(request);
		}

		public Put_Service_Center_Representative_Workday_Account_ResponseType Put_Service_Center_Representative_Workday_Account(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_Workday_Account_RequestType Put_Service_Center_Representative_Workday_Account_Request)
		{
			return ((Human_ResourcesPort)this).Put_Service_Center_Representative_Workday_Account(new Put_Service_Center_Representative_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Service_Center_Representative_Workday_Account_Request = Put_Service_Center_Representative_Workday_Account_Request
			}).Put_Service_Center_Representative_Workday_Account_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Service_Center_Representative_Workday_AccountOutput> Human_ResourcesPort.Put_Service_Center_Representative_Workday_AccountAsync(Put_Service_Center_Representative_Workday_AccountInput request)
		{
			return base.Channel.Put_Service_Center_Representative_Workday_AccountAsync(request);
		}

		public Task<Put_Service_Center_Representative_Workday_AccountOutput> Put_Service_Center_Representative_Workday_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Service_Center_Representative_Workday_Account_RequestType Put_Service_Center_Representative_Workday_Account_Request)
		{
			return ((Human_ResourcesPort)this).Put_Service_Center_Representative_Workday_AccountAsync(new Put_Service_Center_Representative_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Service_Center_Representative_Workday_Account_Request = Put_Service_Center_Representative_Workday_Account_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Background_Check_StatusOutput Human_ResourcesPort.Change_Background_Check_Status(Change_Background_Check_StatusInput request)
		{
			return base.Channel.Change_Background_Check_Status(request);
		}

		public Change_Background_Check_Status_ResponseType Change_Background_Check_Status(Workday_Common_HeaderType Workday_Common_Header, Change_Background_Check_Status_RequestType Change_Background_Check_Status_Request)
		{
			return ((Human_ResourcesPort)this).Change_Background_Check_Status(new Change_Background_Check_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Background_Check_Status_Request = Change_Background_Check_Status_Request
			}).Change_Background_Check_Status_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Background_Check_StatusOutput> Human_ResourcesPort.Change_Background_Check_StatusAsync(Change_Background_Check_StatusInput request)
		{
			return base.Channel.Change_Background_Check_StatusAsync(request);
		}

		public Task<Change_Background_Check_StatusOutput> Change_Background_Check_StatusAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Background_Check_Status_RequestType Change_Background_Check_Status_Request)
		{
			return ((Human_ResourcesPort)this).Change_Background_Check_StatusAsync(new Change_Background_Check_StatusInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Background_Check_Status_Request = Change_Background_Check_Status_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Academic_UnitsOutput Human_ResourcesPort.Get_Academic_Units(Get_Academic_UnitsInput request)
		{
			return base.Channel.Get_Academic_Units(request);
		}

		public Get_Academic_Units_ResponseType Get_Academic_Units(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Units_RequestType Get_Academic_Units_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_Units(new Get_Academic_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Units_Request = Get_Academic_Units_Request
			}).Get_Academic_Units_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Academic_UnitsOutput> Human_ResourcesPort.Get_Academic_UnitsAsync(Get_Academic_UnitsInput request)
		{
			return base.Channel.Get_Academic_UnitsAsync(request);
		}

		public Task<Get_Academic_UnitsOutput> Get_Academic_UnitsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Units_RequestType Get_Academic_Units_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_UnitsAsync(new Get_Academic_UnitsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Units_Request = Get_Academic_Units_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Academic_UnitOutput Human_ResourcesPort.Put_Academic_Unit(Put_Academic_UnitInput request)
		{
			return base.Channel.Put_Academic_Unit(request);
		}

		public Put_Academic_Unit_ResponseType Put_Academic_Unit(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Unit_RequestType Put_Academic_Unit_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_Unit(new Put_Academic_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Unit_Request = Put_Academic_Unit_Request
			}).Put_Academic_Unit_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Academic_UnitOutput> Human_ResourcesPort.Put_Academic_UnitAsync(Put_Academic_UnitInput request)
		{
			return base.Channel.Put_Academic_UnitAsync(request);
		}

		public Task<Put_Academic_UnitOutput> Put_Academic_UnitAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Unit_RequestType Put_Academic_Unit_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_UnitAsync(new Put_Academic_UnitInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Unit_Request = Put_Academic_Unit_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Academic_Unit_HierarchiesOutput Human_ResourcesPort.Get_Academic_Unit_Hierarchies(Get_Academic_Unit_HierarchiesInput request)
		{
			return base.Channel.Get_Academic_Unit_Hierarchies(request);
		}

		public Get_Academic_Unit_Hierarchies_ResponseType Get_Academic_Unit_Hierarchies(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Unit_Hierarchies_RequestType Get_Academic_Unit_Hierarchies_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_Unit_Hierarchies(new Get_Academic_Unit_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Unit_Hierarchies_Request = Get_Academic_Unit_Hierarchies_Request
			}).Get_Academic_Unit_Hierarchies_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Academic_Unit_HierarchiesOutput> Human_ResourcesPort.Get_Academic_Unit_HierarchiesAsync(Get_Academic_Unit_HierarchiesInput request)
		{
			return base.Channel.Get_Academic_Unit_HierarchiesAsync(request);
		}

		public Task<Get_Academic_Unit_HierarchiesOutput> Get_Academic_Unit_HierarchiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Academic_Unit_Hierarchies_RequestType Get_Academic_Unit_Hierarchies_Request)
		{
			return ((Human_ResourcesPort)this).Get_Academic_Unit_HierarchiesAsync(new Get_Academic_Unit_HierarchiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Academic_Unit_Hierarchies_Request = Get_Academic_Unit_Hierarchies_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Academic_Unit_HierarchyOutput Human_ResourcesPort.Put_Academic_Unit_Hierarchy(Put_Academic_Unit_HierarchyInput request)
		{
			return base.Channel.Put_Academic_Unit_Hierarchy(request);
		}

		public Put_Academic_Unit_Hierarchy_ResponseType Put_Academic_Unit_Hierarchy(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Unit_Hierarchy_RequestType Put_Academic_Unit_Hierarchy_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_Unit_Hierarchy(new Put_Academic_Unit_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Unit_Hierarchy_Request = Put_Academic_Unit_Hierarchy_Request
			}).Put_Academic_Unit_Hierarchy_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Academic_Unit_HierarchyOutput> Human_ResourcesPort.Put_Academic_Unit_HierarchyAsync(Put_Academic_Unit_HierarchyInput request)
		{
			return base.Channel.Put_Academic_Unit_HierarchyAsync(request);
		}

		public Task<Put_Academic_Unit_HierarchyOutput> Put_Academic_Unit_HierarchyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Unit_Hierarchy_RequestType Put_Academic_Unit_Hierarchy_Request)
		{
			return ((Human_ResourcesPort)this).Put_Academic_Unit_HierarchyAsync(new Put_Academic_Unit_HierarchyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Academic_Unit_Hierarchy_Request = Put_Academic_Unit_Hierarchy_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Political_AffiliationsOutput Human_ResourcesPort.Get_Political_Affiliations(Get_Political_AffiliationsInput request)
		{
			return base.Channel.Get_Political_Affiliations(request);
		}

		public Get_Political_Affiliations_ResponseType Get_Political_Affiliations(Workday_Common_HeaderType Workday_Common_Header, Get_Political_Affiliations_RequestType Get_Political_Affiliations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Political_Affiliations(new Get_Political_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Political_Affiliations_Request = Get_Political_Affiliations_Request
			}).Get_Political_Affiliations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Political_AffiliationsOutput> Human_ResourcesPort.Get_Political_AffiliationsAsync(Get_Political_AffiliationsInput request)
		{
			return base.Channel.Get_Political_AffiliationsAsync(request);
		}

		public Task<Get_Political_AffiliationsOutput> Get_Political_AffiliationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Political_Affiliations_RequestType Get_Political_Affiliations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Political_AffiliationsAsync(new Get_Political_AffiliationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Political_Affiliations_Request = Get_Political_Affiliations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Political_AffiliationOutput Human_ResourcesPort.Put_Political_Affiliation(Put_Political_AffiliationInput request)
		{
			return base.Channel.Put_Political_Affiliation(request);
		}

		public Put_Political_Affiliation_ResponseType Put_Political_Affiliation(Workday_Common_HeaderType Workday_Common_Header, Put_Political_Affiliation_RequestType Put_Political_Affiliation_Request)
		{
			return ((Human_ResourcesPort)this).Put_Political_Affiliation(new Put_Political_AffiliationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Political_Affiliation_Request = Put_Political_Affiliation_Request
			}).Put_Political_Affiliation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Political_AffiliationOutput> Human_ResourcesPort.Put_Political_AffiliationAsync(Put_Political_AffiliationInput request)
		{
			return base.Channel.Put_Political_AffiliationAsync(request);
		}

		public Task<Put_Political_AffiliationOutput> Put_Political_AffiliationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Political_Affiliation_RequestType Put_Political_Affiliation_Request)
		{
			return ((Human_ResourcesPort)this).Put_Political_AffiliationAsync(new Put_Political_AffiliationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Political_Affiliation_Request = Put_Political_Affiliation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Personal_InformationOutput Human_ResourcesPort.Change_Personal_Information(Change_Personal_InformationInput request)
		{
			return base.Channel.Change_Personal_Information(request);
		}

		public Change_Personal_Information_ResponseType Change_Personal_Information(Workday_Common_HeaderType Workday_Common_Header, Change_Personal_Information_RequestType Change_Personal_Information_Request)
		{
			return ((Human_ResourcesPort)this).Change_Personal_Information(new Change_Personal_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Personal_Information_Request = Change_Personal_Information_Request
			}).Change_Personal_Information_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Personal_InformationOutput> Human_ResourcesPort.Change_Personal_InformationAsync(Change_Personal_InformationInput request)
		{
			return base.Channel.Change_Personal_InformationAsync(request);
		}

		public Task<Change_Personal_InformationOutput> Change_Personal_InformationAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Personal_Information_RequestType Change_Personal_Information_Request)
		{
			return ((Human_ResourcesPort)this).Change_Personal_InformationAsync(new Change_Personal_InformationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Personal_Information_Request = Change_Personal_Information_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Government_IDsOutput Human_ResourcesPort.Change_Government_IDs(Change_Government_IDsInput request)
		{
			return base.Channel.Change_Government_IDs(request);
		}

		public Change_Government_IDs_ResponseType Change_Government_IDs(Workday_Common_HeaderType Workday_Common_Header, Change_Government_IDs_RequestType Change_Government_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Change_Government_IDs(new Change_Government_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Government_IDs_Request = Change_Government_IDs_Request
			}).Change_Government_IDs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Government_IDsOutput> Human_ResourcesPort.Change_Government_IDsAsync(Change_Government_IDsInput request)
		{
			return base.Channel.Change_Government_IDsAsync(request);
		}

		public Task<Change_Government_IDsOutput> Change_Government_IDsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Government_IDs_RequestType Change_Government_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Change_Government_IDsAsync(new Change_Government_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Government_IDs_Request = Change_Government_IDs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Legal_NameOutput Human_ResourcesPort.Change_Legal_Name(Change_Legal_NameInput request)
		{
			return base.Channel.Change_Legal_Name(request);
		}

		public Change_Legal_Name_ResponseType Change_Legal_Name(Workday_Common_HeaderType Workday_Common_Header, Change_Legal_Name_RequestType Change_Legal_Name_Request)
		{
			return ((Human_ResourcesPort)this).Change_Legal_Name(new Change_Legal_NameInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Legal_Name_Request = Change_Legal_Name_Request
			}).Change_Legal_Name_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Legal_NameOutput> Human_ResourcesPort.Change_Legal_NameAsync(Change_Legal_NameInput request)
		{
			return base.Channel.Change_Legal_NameAsync(request);
		}

		public Task<Change_Legal_NameOutput> Change_Legal_NameAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Legal_Name_RequestType Change_Legal_Name_Request)
		{
			return ((Human_ResourcesPort)this).Change_Legal_NameAsync(new Change_Legal_NameInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Legal_Name_Request = Change_Legal_Name_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Preferred_NameOutput Human_ResourcesPort.Change_Preferred_Name(Change_Preferred_NameInput request)
		{
			return base.Channel.Change_Preferred_Name(request);
		}

		public Change_Preferred_Name_ResponseType Change_Preferred_Name(Workday_Common_HeaderType Workday_Common_Header, Change_Preferred_Name_RequestType Change_Preferred_Name_Request)
		{
			return ((Human_ResourcesPort)this).Change_Preferred_Name(new Change_Preferred_NameInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Preferred_Name_Request = Change_Preferred_Name_Request
			}).Change_Preferred_Name_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Preferred_NameOutput> Human_ResourcesPort.Change_Preferred_NameAsync(Change_Preferred_NameInput request)
		{
			return base.Channel.Change_Preferred_NameAsync(request);
		}

		public Task<Change_Preferred_NameOutput> Change_Preferred_NameAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Preferred_Name_RequestType Change_Preferred_Name_Request)
		{
			return ((Human_ResourcesPort)this).Change_Preferred_NameAsync(new Change_Preferred_NameInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Preferred_Name_Request = Change_Preferred_Name_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Additional_NamesOutput Human_ResourcesPort.Change_Additional_Names(Change_Additional_NamesInput request)
		{
			return base.Channel.Change_Additional_Names(request);
		}

		public Change_Additional_Names_ResponseType Change_Additional_Names(Workday_Common_HeaderType Workday_Common_Header, Change_Additional_Names_RequestType Change_Additional_Names_Request)
		{
			return ((Human_ResourcesPort)this).Change_Additional_Names(new Change_Additional_NamesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Additional_Names_Request = Change_Additional_Names_Request
			}).Change_Additional_Names_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Additional_NamesOutput> Human_ResourcesPort.Change_Additional_NamesAsync(Change_Additional_NamesInput request)
		{
			return base.Channel.Change_Additional_NamesAsync(request);
		}

		public Task<Change_Additional_NamesOutput> Change_Additional_NamesAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Additional_Names_RequestType Change_Additional_Names_Request)
		{
			return ((Human_ResourcesPort)this).Change_Additional_NamesAsync(new Change_Additional_NamesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Additional_Names_Request = Change_Additional_Names_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Passports_and_VisasOutput Human_ResourcesPort.Change_Passports_and_Visas(Change_Passports_and_VisasInput request)
		{
			return base.Channel.Change_Passports_and_Visas(request);
		}

		public Change_Passports_and_Visas_ResponseType Change_Passports_and_Visas(Workday_Common_HeaderType Workday_Common_Header, Change_Passports_and_Visas_RequestType Change_Passports_and_Visas_Request)
		{
			return ((Human_ResourcesPort)this).Change_Passports_and_Visas(new Change_Passports_and_VisasInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Passports_and_Visas_Request = Change_Passports_and_Visas_Request
			}).Change_Passports_and_Visas_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Passports_and_VisasOutput> Human_ResourcesPort.Change_Passports_and_VisasAsync(Change_Passports_and_VisasInput request)
		{
			return base.Channel.Change_Passports_and_VisasAsync(request);
		}

		public Task<Change_Passports_and_VisasOutput> Change_Passports_and_VisasAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Passports_and_Visas_RequestType Change_Passports_and_Visas_Request)
		{
			return ((Human_ResourcesPort)this).Change_Passports_and_VisasAsync(new Change_Passports_and_VisasInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Passports_and_Visas_Request = Change_Passports_and_Visas_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_LicensesOutput Human_ResourcesPort.Change_Licenses(Change_LicensesInput request)
		{
			return base.Channel.Change_Licenses(request);
		}

		public Change_Licenses_ResponseType Change_Licenses(Workday_Common_HeaderType Workday_Common_Header, Change_Licenses_RequestType Change_Licenses_Request)
		{
			return ((Human_ResourcesPort)this).Change_Licenses(new Change_LicensesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Licenses_Request = Change_Licenses_Request
			}).Change_Licenses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_LicensesOutput> Human_ResourcesPort.Change_LicensesAsync(Change_LicensesInput request)
		{
			return base.Channel.Change_LicensesAsync(request);
		}

		public Task<Change_LicensesOutput> Change_LicensesAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Licenses_RequestType Change_Licenses_Request)
		{
			return ((Human_ResourcesPort)this).Change_LicensesAsync(new Change_LicensesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Licenses_Request = Change_Licenses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Other_IDsOutput Human_ResourcesPort.Change_Other_IDs(Change_Other_IDsInput request)
		{
			return base.Channel.Change_Other_IDs(request);
		}

		public Change_Other_IDs_ResponseType Change_Other_IDs(Workday_Common_HeaderType Workday_Common_Header, Change_Other_IDs_RequestType Change_Other_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Change_Other_IDs(new Change_Other_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Other_IDs_Request = Change_Other_IDs_Request
			}).Change_Other_IDs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Other_IDsOutput> Human_ResourcesPort.Change_Other_IDsAsync(Change_Other_IDsInput request)
		{
			return base.Channel.Change_Other_IDsAsync(request);
		}

		public Task<Change_Other_IDsOutput> Change_Other_IDsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Other_IDs_RequestType Change_Other_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Change_Other_IDsAsync(new Change_Other_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Other_IDs_Request = Change_Other_IDs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Former_WorkerOutput Human_ResourcesPort.Put_Former_Worker(Put_Former_WorkerInput request)
		{
			return base.Channel.Put_Former_Worker(request);
		}

		public Put_Former_Worker_ResponseType Put_Former_Worker(Workday_Common_HeaderType Workday_Common_Header, Put_Former_Worker_RequestType Put_Former_Worker_Request)
		{
			return ((Human_ResourcesPort)this).Put_Former_Worker(new Put_Former_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Former_Worker_Request = Put_Former_Worker_Request
			}).Put_Former_Worker_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Former_WorkerOutput> Human_ResourcesPort.Put_Former_WorkerAsync(Put_Former_WorkerInput request)
		{
			return base.Channel.Put_Former_WorkerAsync(request);
		}

		public Task<Put_Former_WorkerOutput> Put_Former_WorkerAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Former_Worker_RequestType Put_Former_Worker_Request)
		{
			return ((Human_ResourcesPort)this).Put_Former_WorkerAsync(new Put_Former_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Former_Worker_Request = Put_Former_Worker_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Former_WorkersOutput Human_ResourcesPort.Get_Former_Workers(Get_Former_WorkersInput request)
		{
			return base.Channel.Get_Former_Workers(request);
		}

		public Get_Former_Workers_ResponseType Get_Former_Workers(Workday_Common_HeaderType Workday_Common_Header, Get_Former_Workers_RequestType Get_Former_Workers_Request)
		{
			return ((Human_ResourcesPort)this).Get_Former_Workers(new Get_Former_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Former_Workers_Request = Get_Former_Workers_Request
			}).Get_Former_Workers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Former_WorkersOutput> Human_ResourcesPort.Get_Former_WorkersAsync(Get_Former_WorkersInput request)
		{
			return base.Channel.Get_Former_WorkersAsync(request);
		}

		public Task<Get_Former_WorkersOutput> Get_Former_WorkersAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Former_Workers_RequestType Get_Former_Workers_Request)
		{
			return ((Human_ResourcesPort)this).Get_Former_WorkersAsync(new Get_Former_WorkersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Former_Workers_Request = Get_Former_Workers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Social_Benefits_LocalitiesOutput Human_ResourcesPort.Get_Social_Benefits_Localities(Get_Social_Benefits_LocalitiesInput request)
		{
			return base.Channel.Get_Social_Benefits_Localities(request);
		}

		public Get_Social_Benefits_Localities_ResponseType Get_Social_Benefits_Localities(Workday_Common_HeaderType Workday_Common_Header, Get_Social_Benefits_Localities_RequestType Get_Social_Benefits_Localities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Social_Benefits_Localities(new Get_Social_Benefits_LocalitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Social_Benefits_Localities_Request = Get_Social_Benefits_Localities_Request
			}).Get_Social_Benefits_Localities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Social_Benefits_LocalitiesOutput> Human_ResourcesPort.Get_Social_Benefits_LocalitiesAsync(Get_Social_Benefits_LocalitiesInput request)
		{
			return base.Channel.Get_Social_Benefits_LocalitiesAsync(request);
		}

		public Task<Get_Social_Benefits_LocalitiesOutput> Get_Social_Benefits_LocalitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Social_Benefits_Localities_RequestType Get_Social_Benefits_Localities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Social_Benefits_LocalitiesAsync(new Get_Social_Benefits_LocalitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Social_Benefits_Localities_Request = Get_Social_Benefits_Localities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Social_Benefits_LocalityOutput Human_ResourcesPort.Put_Social_Benefits_Locality(Put_Social_Benefits_LocalityInput request)
		{
			return base.Channel.Put_Social_Benefits_Locality(request);
		}

		public Put_Social_Benefits_Locality_ResponseType Put_Social_Benefits_Locality(Workday_Common_HeaderType Workday_Common_Header, Put_Social_Benefits_Locality_RequestType Put_Social_Benefits_Locality_Request)
		{
			return ((Human_ResourcesPort)this).Put_Social_Benefits_Locality(new Put_Social_Benefits_LocalityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Social_Benefits_Locality_Request = Put_Social_Benefits_Locality_Request
			}).Put_Social_Benefits_Locality_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Social_Benefits_LocalityOutput> Human_ResourcesPort.Put_Social_Benefits_LocalityAsync(Put_Social_Benefits_LocalityInput request)
		{
			return base.Channel.Put_Social_Benefits_LocalityAsync(request);
		}

		public Task<Put_Social_Benefits_LocalityOutput> Put_Social_Benefits_LocalityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Social_Benefits_Locality_RequestType Put_Social_Benefits_Locality_Request)
		{
			return ((Human_ResourcesPort)this).Put_Social_Benefits_LocalityAsync(new Put_Social_Benefits_LocalityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Social_Benefits_Locality_Request = Put_Social_Benefits_Locality_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Former_Worker_DocumentOutput Human_ResourcesPort.Put_Former_Worker_Document(Put_Former_Worker_DocumentInput request)
		{
			return base.Channel.Put_Former_Worker_Document(request);
		}

		public Put_Former_Worker_Document_ResponseType Put_Former_Worker_Document(Workday_Common_HeaderType Workday_Common_Header, Put_Former_Worker_Document_RequestType Put_Former_Worker_Document_Request)
		{
			return ((Human_ResourcesPort)this).Put_Former_Worker_Document(new Put_Former_Worker_DocumentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Former_Worker_Document_Request = Put_Former_Worker_Document_Request
			}).Put_Former_Worker_Document_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Former_Worker_DocumentOutput> Human_ResourcesPort.Put_Former_Worker_DocumentAsync(Put_Former_Worker_DocumentInput request)
		{
			return base.Channel.Put_Former_Worker_DocumentAsync(request);
		}

		public Task<Put_Former_Worker_DocumentOutput> Put_Former_Worker_DocumentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Former_Worker_Document_RequestType Put_Former_Worker_Document_Request)
		{
			return ((Human_ResourcesPort)this).Put_Former_Worker_DocumentAsync(new Put_Former_Worker_DocumentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Former_Worker_Document_Request = Put_Former_Worker_Document_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Former_Worker_DocumentsOutput Human_ResourcesPort.Get_Former_Worker_Documents(Get_Former_Worker_DocumentsInput request)
		{
			return base.Channel.Get_Former_Worker_Documents(request);
		}

		public Get_Former_Worker_Documents_ResponseType Get_Former_Worker_Documents(Workday_Common_HeaderType Workday_Common_Header, Get_Former_Worker_Documents_RequestType Get_Former_Worker_Documents_Request)
		{
			return ((Human_ResourcesPort)this).Get_Former_Worker_Documents(new Get_Former_Worker_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Former_Worker_Documents_Request = Get_Former_Worker_Documents_Request
			}).Get_Former_Worker_Documents_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Former_Worker_DocumentsOutput> Human_ResourcesPort.Get_Former_Worker_DocumentsAsync(Get_Former_Worker_DocumentsInput request)
		{
			return base.Channel.Get_Former_Worker_DocumentsAsync(request);
		}

		public Task<Get_Former_Worker_DocumentsOutput> Get_Former_Worker_DocumentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Former_Worker_Documents_RequestType Get_Former_Worker_Documents_Request)
		{
			return ((Human_ResourcesPort)this).Get_Former_Worker_DocumentsAsync(new Get_Former_Worker_DocumentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Former_Worker_Documents_Request = Get_Former_Worker_Documents_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_Named_ProfessorshipOutput Human_ResourcesPort.Create_Named_Professorship(Create_Named_ProfessorshipInput request)
		{
			return base.Channel.Create_Named_Professorship(request);
		}

		public Create_Named_Professorship_ResponseType Create_Named_Professorship(Workday_Common_HeaderType Workday_Common_Header, Create_Named_Professorship_RequestType Create_Named_Professorship_Request)
		{
			return ((Human_ResourcesPort)this).Create_Named_Professorship(new Create_Named_ProfessorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Named_Professorship_Request = Create_Named_Professorship_Request
			}).Create_Named_Professorship_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_Named_ProfessorshipOutput> Human_ResourcesPort.Create_Named_ProfessorshipAsync(Create_Named_ProfessorshipInput request)
		{
			return base.Channel.Create_Named_ProfessorshipAsync(request);
		}

		public Task<Create_Named_ProfessorshipOutput> Create_Named_ProfessorshipAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Named_Professorship_RequestType Create_Named_Professorship_Request)
		{
			return ((Human_ResourcesPort)this).Create_Named_ProfessorshipAsync(new Create_Named_ProfessorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Named_Professorship_Request = Create_Named_Professorship_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Named_ProfessorshipOutput Human_ResourcesPort.Edit_Named_Professorship(Edit_Named_ProfessorshipInput request)
		{
			return base.Channel.Edit_Named_Professorship(request);
		}

		public Edit_Named_Professorship_ResponseType Edit_Named_Professorship(Workday_Common_HeaderType Workday_Common_Header, Edit_Named_Professorship_RequestType Edit_Named_Professorship_Request)
		{
			return ((Human_ResourcesPort)this).Edit_Named_Professorship(new Edit_Named_ProfessorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Named_Professorship_Request = Edit_Named_Professorship_Request
			}).Edit_Named_Professorship_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Named_ProfessorshipOutput> Human_ResourcesPort.Edit_Named_ProfessorshipAsync(Edit_Named_ProfessorshipInput request)
		{
			return base.Channel.Edit_Named_ProfessorshipAsync(request);
		}

		public Task<Edit_Named_ProfessorshipOutput> Edit_Named_ProfessorshipAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Named_Professorship_RequestType Edit_Named_Professorship_Request)
		{
			return ((Human_ResourcesPort)this).Edit_Named_ProfessorshipAsync(new Edit_Named_ProfessorshipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Named_Professorship_Request = Edit_Named_Professorship_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Assign_UserBased_Security_GroupOutput Human_ResourcesPort.Put_Assign_UserBased_Security_Group(Put_Assign_UserBased_Security_GroupInput request)
		{
			return base.Channel.Put_Assign_UserBased_Security_Group(request);
		}

		public Put_Assign_UserBased_Security_Group_ResponseType Put_Assign_UserBased_Security_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Assign_UserBased_Security_Group_RequestType Put_Assign_UserBased_Security_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Assign_UserBased_Security_Group(new Put_Assign_UserBased_Security_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Assign_UserBased_Security_Group_Request = Put_Assign_UserBased_Security_Group_Request
			}).Put_Assign_UserBased_Security_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Assign_UserBased_Security_GroupOutput> Human_ResourcesPort.Put_Assign_UserBased_Security_GroupAsync(Put_Assign_UserBased_Security_GroupInput request)
		{
			return base.Channel.Put_Assign_UserBased_Security_GroupAsync(request);
		}

		public Task<Put_Assign_UserBased_Security_GroupOutput> Put_Assign_UserBased_Security_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Assign_UserBased_Security_Group_RequestType Put_Assign_UserBased_Security_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Assign_UserBased_Security_GroupAsync(new Put_Assign_UserBased_Security_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Assign_UserBased_Security_Group_Request = Put_Assign_UserBased_Security_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Assign_UserBased_Security_GroupOutput Human_ResourcesPort.Get_Assign_UserBased_Security_Group(Get_Assign_UserBased_Security_GroupInput request)
		{
			return base.Channel.Get_Assign_UserBased_Security_Group(request);
		}

		public Get_Assign_UserBased_Security_Group_ResponseType Get_Assign_UserBased_Security_Group(Workday_Common_HeaderType Workday_Common_Header, Get_Assign_UserBased_Security_Group_RequestType Get_Assign_UserBased_Security_Group_Request)
		{
			return ((Human_ResourcesPort)this).Get_Assign_UserBased_Security_Group(new Get_Assign_UserBased_Security_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assign_UserBased_Security_Group_Request = Get_Assign_UserBased_Security_Group_Request
			}).Get_Assign_UserBased_Security_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Assign_UserBased_Security_GroupOutput> Human_ResourcesPort.Get_Assign_UserBased_Security_GroupAsync(Get_Assign_UserBased_Security_GroupInput request)
		{
			return base.Channel.Get_Assign_UserBased_Security_GroupAsync(request);
		}

		public Task<Get_Assign_UserBased_Security_GroupOutput> Get_Assign_UserBased_Security_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Assign_UserBased_Security_Group_RequestType Get_Assign_UserBased_Security_Group_Request)
		{
			return ((Human_ResourcesPort)this).Get_Assign_UserBased_Security_GroupAsync(new Get_Assign_UserBased_Security_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assign_UserBased_Security_Group_Request = Get_Assign_UserBased_Security_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Employee_Collective_Agreement_EventOutput Human_ResourcesPort.Assign_Employee_Collective_Agreement_Event(Assign_Employee_Collective_Agreement_EventInput request)
		{
			return base.Channel.Assign_Employee_Collective_Agreement_Event(request);
		}

		public Assign_Employee_Collective_Agreement_Event_ResponseType Assign_Employee_Collective_Agreement_Event(Workday_Common_HeaderType Workday_Common_Header, Assign_Employee_Collective_Agreement_Event_RequestType Assign_Employee_Collective_Agreement_Event_Request)
		{
			return ((Human_ResourcesPort)this).Assign_Employee_Collective_Agreement_Event(new Assign_Employee_Collective_Agreement_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Employee_Collective_Agreement_Event_Request = Assign_Employee_Collective_Agreement_Event_Request
			}).Assign_Employee_Collective_Agreement_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Employee_Collective_Agreement_EventOutput> Human_ResourcesPort.Assign_Employee_Collective_Agreement_EventAsync(Assign_Employee_Collective_Agreement_EventInput request)
		{
			return base.Channel.Assign_Employee_Collective_Agreement_EventAsync(request);
		}

		public Task<Assign_Employee_Collective_Agreement_EventOutput> Assign_Employee_Collective_Agreement_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Employee_Collective_Agreement_Event_RequestType Assign_Employee_Collective_Agreement_Event_Request)
		{
			return ((Human_ResourcesPort)this).Assign_Employee_Collective_Agreement_EventAsync(new Assign_Employee_Collective_Agreement_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Employee_Collective_Agreement_Event_Request = Assign_Employee_Collective_Agreement_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Emergency_ContactsOutput Human_ResourcesPort.Change_Emergency_Contacts(Change_Emergency_ContactsInput request)
		{
			return base.Channel.Change_Emergency_Contacts(request);
		}

		public Change_Emergency_Contacts_ResponseType Change_Emergency_Contacts(Workday_Common_HeaderType Workday_Common_Header, Change_Emergency_Contacts_RequestType Change_Emergency_Contacts_Request)
		{
			return ((Human_ResourcesPort)this).Change_Emergency_Contacts(new Change_Emergency_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Emergency_Contacts_Request = Change_Emergency_Contacts_Request
			}).Change_Emergency_Contacts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Emergency_ContactsOutput> Human_ResourcesPort.Change_Emergency_ContactsAsync(Change_Emergency_ContactsInput request)
		{
			return base.Channel.Change_Emergency_ContactsAsync(request);
		}

		public Task<Change_Emergency_ContactsOutput> Change_Emergency_ContactsAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Emergency_Contacts_RequestType Change_Emergency_Contacts_Request)
		{
			return ((Human_ResourcesPort)this).Change_Emergency_ContactsAsync(new Change_Emergency_ContactsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Emergency_Contacts_Request = Change_Emergency_Contacts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Reassign_Superior_to_Inactive_OrganizationOutput Human_ResourcesPort.Reassign_Superior_to_Inactive_Organization(Reassign_Superior_to_Inactive_OrganizationInput request)
		{
			return base.Channel.Reassign_Superior_to_Inactive_Organization(request);
		}

		public Reassign_Superior_to_Inactive_Organization_ResponseType Reassign_Superior_to_Inactive_Organization(Workday_Common_HeaderType Workday_Common_Header, Reassign_Superior_to_Inactive_Organization_RequestType Reassign_Superior_to_Inactive_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Reassign_Superior_to_Inactive_Organization(new Reassign_Superior_to_Inactive_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reassign_Superior_to_Inactive_Organization_Request = Reassign_Superior_to_Inactive_Organization_Request
			}).Reassign_Superior_to_Inactive_Organization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Reassign_Superior_to_Inactive_OrganizationOutput> Human_ResourcesPort.Reassign_Superior_to_Inactive_OrganizationAsync(Reassign_Superior_to_Inactive_OrganizationInput request)
		{
			return base.Channel.Reassign_Superior_to_Inactive_OrganizationAsync(request);
		}

		public Task<Reassign_Superior_to_Inactive_OrganizationOutput> Reassign_Superior_to_Inactive_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Reassign_Superior_to_Inactive_Organization_RequestType Reassign_Superior_to_Inactive_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Reassign_Superior_to_Inactive_OrganizationAsync(new Reassign_Superior_to_Inactive_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reassign_Superior_to_Inactive_Organization_Request = Reassign_Superior_to_Inactive_Organization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Location_Hierarchy_Organization_AssignmentsOutput Human_ResourcesPort.Put_Location_Hierarchy_Organization_Assignments(Put_Location_Hierarchy_Organization_AssignmentsInput request)
		{
			return base.Channel.Put_Location_Hierarchy_Organization_Assignments(request);
		}

		public Put_Location_Hierarchy_Organization_Assignments_ResponseType Put_Location_Hierarchy_Organization_Assignments(Workday_Common_HeaderType Workday_Common_Header, Put_Location_Hierarchy_Organization_Assignments_RequestType Put_Location_Hierarchy_Organization_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Put_Location_Hierarchy_Organization_Assignments(new Put_Location_Hierarchy_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Hierarchy_Organization_Assignments_Request = Put_Location_Hierarchy_Organization_Assignments_Request
			}).Put_Location_Hierarchy_Organization_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Location_Hierarchy_Organization_AssignmentsOutput> Human_ResourcesPort.Put_Location_Hierarchy_Organization_AssignmentsAsync(Put_Location_Hierarchy_Organization_AssignmentsInput request)
		{
			return base.Channel.Put_Location_Hierarchy_Organization_AssignmentsAsync(request);
		}

		public Task<Put_Location_Hierarchy_Organization_AssignmentsOutput> Put_Location_Hierarchy_Organization_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Location_Hierarchy_Organization_Assignments_RequestType Put_Location_Hierarchy_Organization_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Put_Location_Hierarchy_Organization_AssignmentsAsync(new Put_Location_Hierarchy_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Hierarchy_Organization_Assignments_Request = Put_Location_Hierarchy_Organization_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Location_Hierarchy_Organization_AssignmentsOutput Human_ResourcesPort.Get_Location_Hierarchy_Organization_Assignments(Get_Location_Hierarchy_Organization_AssignmentsInput request)
		{
			return base.Channel.Get_Location_Hierarchy_Organization_Assignments(request);
		}

		public Get_Location_Hierarchy_Organization_Assignments_ResponseType Get_Location_Hierarchy_Organization_Assignments(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Hierarchy_Organization_Assignments_RequestType Get_Location_Hierarchy_Organization_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Get_Location_Hierarchy_Organization_Assignments(new Get_Location_Hierarchy_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Location_Hierarchy_Organization_Assignments_Request = Get_Location_Hierarchy_Organization_Assignments_Request
			}).Get_Location_Hierarchy_Organization_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Location_Hierarchy_Organization_AssignmentsOutput> Human_ResourcesPort.Get_Location_Hierarchy_Organization_AssignmentsAsync(Get_Location_Hierarchy_Organization_AssignmentsInput request)
		{
			return base.Channel.Get_Location_Hierarchy_Organization_AssignmentsAsync(request);
		}

		public Task<Get_Location_Hierarchy_Organization_AssignmentsOutput> Get_Location_Hierarchy_Organization_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Hierarchy_Organization_Assignments_RequestType Get_Location_Hierarchy_Organization_Assignments_Request)
		{
			return ((Human_ResourcesPort)this).Get_Location_Hierarchy_Organization_AssignmentsAsync(new Get_Location_Hierarchy_Organization_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Location_Hierarchy_Organization_Assignments_Request = Get_Location_Hierarchy_Organization_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Organization_Reference_IDsOutput Human_ResourcesPort.Get_Organization_Reference_IDs(Get_Organization_Reference_IDsInput request)
		{
			return base.Channel.Get_Organization_Reference_IDs(request);
		}

		public Get_Organization_Reference_IDs_ResponseType Get_Organization_Reference_IDs(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Reference_IDs_RequestType Get_Organization_Reference_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Get_Organization_Reference_IDs(new Get_Organization_Reference_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organization_Reference_IDs_Request = Get_Organization_Reference_IDs_Request
			}).Get_Organization_Reference_IDs_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Organization_Reference_IDsOutput> Human_ResourcesPort.Get_Organization_Reference_IDsAsync(Get_Organization_Reference_IDsInput request)
		{
			return base.Channel.Get_Organization_Reference_IDsAsync(request);
		}

		public Task<Get_Organization_Reference_IDsOutput> Get_Organization_Reference_IDsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organization_Reference_IDs_RequestType Get_Organization_Reference_IDs_Request)
		{
			return ((Human_ResourcesPort)this).Get_Organization_Reference_IDsAsync(new Get_Organization_Reference_IDsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organization_Reference_IDs_Request = Get_Organization_Reference_IDs_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Organization_Reference_IDOutput Human_ResourcesPort.Put_Organization_Reference_ID(Put_Organization_Reference_IDInput request)
		{
			return base.Channel.Put_Organization_Reference_ID(request);
		}

		public Put_Organization_Reference_ID_ResponseType Put_Organization_Reference_ID(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Reference_ID_RequestType Put_Organization_Reference_ID_Request)
		{
			return ((Human_ResourcesPort)this).Put_Organization_Reference_ID(new Put_Organization_Reference_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Organization_Reference_ID_Request = Put_Organization_Reference_ID_Request
			}).Put_Organization_Reference_ID_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Organization_Reference_IDOutput> Human_ResourcesPort.Put_Organization_Reference_IDAsync(Put_Organization_Reference_IDInput request)
		{
			return base.Channel.Put_Organization_Reference_IDAsync(request);
		}

		public Task<Put_Organization_Reference_IDOutput> Put_Organization_Reference_IDAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Reference_ID_RequestType Put_Organization_Reference_ID_Request)
		{
			return ((Human_ResourcesPort)this).Put_Organization_Reference_IDAsync(new Put_Organization_Reference_IDInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Organization_Reference_ID_Request = Put_Organization_Reference_ID_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Committee_TypeOutput Human_ResourcesPort.Put_Committee_Type(Put_Committee_TypeInput request)
		{
			return base.Channel.Put_Committee_Type(request);
		}

		public Put_Committee_Type_ResponseType Put_Committee_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Type_RequestType Put_Committee_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Type(new Put_Committee_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Type_Request = Put_Committee_Type_Request
			}).Put_Committee_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Committee_TypeOutput> Human_ResourcesPort.Put_Committee_TypeAsync(Put_Committee_TypeInput request)
		{
			return base.Channel.Put_Committee_TypeAsync(request);
		}

		public Task<Put_Committee_TypeOutput> Put_Committee_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Type_RequestType Put_Committee_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_TypeAsync(new Put_Committee_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Type_Request = Put_Committee_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_TypesOutput Human_ResourcesPort.Get_Committee_Types(Get_Committee_TypesInput request)
		{
			return base.Channel.Get_Committee_Types(request);
		}

		public Get_Committee_Types_ResponseType Get_Committee_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Types_RequestType Get_Committee_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Types(new Get_Committee_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Types_Request = Get_Committee_Types_Request
			}).Get_Committee_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_TypesOutput> Human_ResourcesPort.Get_Committee_TypesAsync(Get_Committee_TypesInput request)
		{
			return base.Channel.Get_Committee_TypesAsync(request);
		}

		public Task<Get_Committee_TypesOutput> Get_Committee_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Types_RequestType Get_Committee_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_TypesAsync(new Get_Committee_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Types_Request = Get_Committee_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Committee_Classification_GroupOutput Human_ResourcesPort.Put_Committee_Classification_Group(Put_Committee_Classification_GroupInput request)
		{
			return base.Channel.Put_Committee_Classification_Group(request);
		}

		public Put_Committee_Classification_Group_ResponseType Put_Committee_Classification_Group(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Classification_Group_RequestType Put_Committee_Classification_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Classification_Group(new Put_Committee_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Classification_Group_Request = Put_Committee_Classification_Group_Request
			}).Put_Committee_Classification_Group_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Committee_Classification_GroupOutput> Human_ResourcesPort.Put_Committee_Classification_GroupAsync(Put_Committee_Classification_GroupInput request)
		{
			return base.Channel.Put_Committee_Classification_GroupAsync(request);
		}

		public Task<Put_Committee_Classification_GroupOutput> Put_Committee_Classification_GroupAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Classification_Group_RequestType Put_Committee_Classification_Group_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Classification_GroupAsync(new Put_Committee_Classification_GroupInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Classification_Group_Request = Put_Committee_Classification_Group_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_Classification_GroupsOutput Human_ResourcesPort.Get_Committee_Classification_Groups(Get_Committee_Classification_GroupsInput request)
		{
			return base.Channel.Get_Committee_Classification_Groups(request);
		}

		public Get_Committee_Classification_Groups_ResponseType Get_Committee_Classification_Groups(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Classification_Groups_RequestType Get_Committee_Classification_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Classification_Groups(new Get_Committee_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Classification_Groups_Request = Get_Committee_Classification_Groups_Request
			}).Get_Committee_Classification_Groups_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_Classification_GroupsOutput> Human_ResourcesPort.Get_Committee_Classification_GroupsAsync(Get_Committee_Classification_GroupsInput request)
		{
			return base.Channel.Get_Committee_Classification_GroupsAsync(request);
		}

		public Task<Get_Committee_Classification_GroupsOutput> Get_Committee_Classification_GroupsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Classification_Groups_RequestType Get_Committee_Classification_Groups_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Classification_GroupsAsync(new Get_Committee_Classification_GroupsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Classification_Groups_Request = Get_Committee_Classification_Groups_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Committee_ClassificationOutput Human_ResourcesPort.Put_Committee_Classification(Put_Committee_ClassificationInput request)
		{
			return base.Channel.Put_Committee_Classification(request);
		}

		public Put_Committee_Classification_ResponseType Put_Committee_Classification(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Classification_RequestType Put_Committee_Classification_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Classification(new Put_Committee_ClassificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Classification_Request = Put_Committee_Classification_Request
			}).Put_Committee_Classification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Committee_ClassificationOutput> Human_ResourcesPort.Put_Committee_ClassificationAsync(Put_Committee_ClassificationInput request)
		{
			return base.Channel.Put_Committee_ClassificationAsync(request);
		}

		public Task<Put_Committee_ClassificationOutput> Put_Committee_ClassificationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Classification_RequestType Put_Committee_Classification_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_ClassificationAsync(new Put_Committee_ClassificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Classification_Request = Put_Committee_Classification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_ClassificationsOutput Human_ResourcesPort.Get_Committee_Classifications(Get_Committee_ClassificationsInput request)
		{
			return base.Channel.Get_Committee_Classifications(request);
		}

		public Get_Committee_Classifications_ResponseType Get_Committee_Classifications(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Classifications_RequestType Get_Committee_Classifications_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Classifications(new Get_Committee_ClassificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Classifications_Request = Get_Committee_Classifications_Request
			}).Get_Committee_Classifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_ClassificationsOutput> Human_ResourcesPort.Get_Committee_ClassificationsAsync(Get_Committee_ClassificationsInput request)
		{
			return base.Channel.Get_Committee_ClassificationsAsync(request);
		}

		public Task<Get_Committee_ClassificationsOutput> Get_Committee_ClassificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Classifications_RequestType Get_Committee_Classifications_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_ClassificationsAsync(new Get_Committee_ClassificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Classifications_Request = Get_Committee_Classifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_Membership_TypesOutput Human_ResourcesPort.Get_Committee_Membership_Types(Get_Committee_Membership_TypesInput request)
		{
			return base.Channel.Get_Committee_Membership_Types(request);
		}

		public Get_Committee_Membership_Types_ResponseType Get_Committee_Membership_Types(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Membership_Types_RequestType Get_Committee_Membership_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Membership_Types(new Get_Committee_Membership_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Membership_Types_Request = Get_Committee_Membership_Types_Request
			}).Get_Committee_Membership_Types_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_Membership_TypesOutput> Human_ResourcesPort.Get_Committee_Membership_TypesAsync(Get_Committee_Membership_TypesInput request)
		{
			return base.Channel.Get_Committee_Membership_TypesAsync(request);
		}

		public Task<Get_Committee_Membership_TypesOutput> Get_Committee_Membership_TypesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Membership_Types_RequestType Get_Committee_Membership_Types_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Membership_TypesAsync(new Get_Committee_Membership_TypesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Membership_Types_Request = Get_Committee_Membership_Types_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Committee_Membership_TypeOutput Human_ResourcesPort.Put_Committee_Membership_Type(Put_Committee_Membership_TypeInput request)
		{
			return base.Channel.Put_Committee_Membership_Type(request);
		}

		public Put_Committee_Membership_Type_ResponseType Put_Committee_Membership_Type(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Membership_Type_RequestType Put_Committee_Membership_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Membership_Type(new Put_Committee_Membership_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Membership_Type_Request = Put_Committee_Membership_Type_Request
			}).Put_Committee_Membership_Type_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Committee_Membership_TypeOutput> Human_ResourcesPort.Put_Committee_Membership_TypeAsync(Put_Committee_Membership_TypeInput request)
		{
			return base.Channel.Put_Committee_Membership_TypeAsync(request);
		}

		public Task<Put_Committee_Membership_TypeOutput> Put_Committee_Membership_TypeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Membership_Type_RequestType Put_Committee_Membership_Type_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Membership_TypeAsync(new Put_Committee_Membership_TypeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Membership_Type_Request = Put_Committee_Membership_Type_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Committee_MembershipOutput Human_ResourcesPort.Manage_Committee_Membership(Manage_Committee_MembershipInput request)
		{
			return base.Channel.Manage_Committee_Membership(request);
		}

		public Manage_Committee_Membership_ResponseType Manage_Committee_Membership(Workday_Common_HeaderType Workday_Common_Header, Manage_Committee_Membership_RequestType Manage_Committee_Membership_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Committee_Membership(new Manage_Committee_MembershipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Committee_Membership_Request = Manage_Committee_Membership_Request
			}).Manage_Committee_Membership_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Committee_MembershipOutput> Human_ResourcesPort.Manage_Committee_MembershipAsync(Manage_Committee_MembershipInput request)
		{
			return base.Channel.Manage_Committee_MembershipAsync(request);
		}

		public Task<Manage_Committee_MembershipOutput> Manage_Committee_MembershipAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Committee_Membership_RequestType Manage_Committee_Membership_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Committee_MembershipAsync(new Manage_Committee_MembershipInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Committee_Membership_Request = Manage_Committee_Membership_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Employee_Probation_Periods_EventOutput Human_ResourcesPort.Manage_Employee_Probation_Periods_Event(Manage_Employee_Probation_Periods_EventInput request)
		{
			return base.Channel.Manage_Employee_Probation_Periods_Event(request);
		}

		public Manage_Employee_Probation_Periods_Event_ResponseType Manage_Employee_Probation_Periods_Event(Workday_Common_HeaderType Workday_Common_Header, Manage_Employee_Probation_Periods_Event_RequestType Manage_Employee_Probation_Periods_Event_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Employee_Probation_Periods_Event(new Manage_Employee_Probation_Periods_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Employee_Probation_Periods_Event_Request = Manage_Employee_Probation_Periods_Event_Request
			}).Manage_Employee_Probation_Periods_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Employee_Probation_Periods_EventOutput> Human_ResourcesPort.Manage_Employee_Probation_Periods_EventAsync(Manage_Employee_Probation_Periods_EventInput request)
		{
			return base.Channel.Manage_Employee_Probation_Periods_EventAsync(request);
		}

		public Task<Manage_Employee_Probation_Periods_EventOutput> Manage_Employee_Probation_Periods_EventAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Employee_Probation_Periods_Event_RequestType Manage_Employee_Probation_Periods_Event_Request)
		{
			return ((Human_ResourcesPort)this).Manage_Employee_Probation_Periods_EventAsync(new Manage_Employee_Probation_Periods_EventInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Employee_Probation_Periods_Event_Request = Manage_Employee_Probation_Periods_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Maintain_Committee_DefinitionOutput Human_ResourcesPort.Maintain_Committee_Definition(Maintain_Committee_DefinitionInput request)
		{
			return base.Channel.Maintain_Committee_Definition(request);
		}

		public Maintain_Committee_Definition_ResponseType Maintain_Committee_Definition(Workday_Common_HeaderType Workday_Common_Header, Maintain_Committee_Definition_RequestType Maintain_Committee_Definition_Request)
		{
			return ((Human_ResourcesPort)this).Maintain_Committee_Definition(new Maintain_Committee_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Committee_Definition_Request = Maintain_Committee_Definition_Request
			}).Maintain_Committee_Definition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Maintain_Committee_DefinitionOutput> Human_ResourcesPort.Maintain_Committee_DefinitionAsync(Maintain_Committee_DefinitionInput request)
		{
			return base.Channel.Maintain_Committee_DefinitionAsync(request);
		}

		public Task<Maintain_Committee_DefinitionOutput> Maintain_Committee_DefinitionAsync(Workday_Common_HeaderType Workday_Common_Header, Maintain_Committee_Definition_RequestType Maintain_Committee_Definition_Request)
		{
			return ((Human_ResourcesPort)this).Maintain_Committee_DefinitionAsync(new Maintain_Committee_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Maintain_Committee_Definition_Request = Maintain_Committee_Definition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_DefinitionOutput Human_ResourcesPort.Get_Committee_Definition(Get_Committee_DefinitionInput request)
		{
			return base.Channel.Get_Committee_Definition(request);
		}

		public Get_Committee_Definition_ResponseType Get_Committee_Definition(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Definition_RequestType Get_Committee_Definition_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Definition(new Get_Committee_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Definition_Request = Get_Committee_Definition_Request
			}).Get_Committee_Definition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_DefinitionOutput> Human_ResourcesPort.Get_Committee_DefinitionAsync(Get_Committee_DefinitionInput request)
		{
			return base.Channel.Get_Committee_DefinitionAsync(request);
		}

		public Task<Get_Committee_DefinitionOutput> Get_Committee_DefinitionAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Definition_RequestType Get_Committee_Definition_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_DefinitionAsync(new Get_Committee_DefinitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Definition_Request = Get_Committee_Definition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_LGBT_IdentificationsOutput Human_ResourcesPort.Get_LGBT_Identifications(Get_LGBT_IdentificationsInput request)
		{
			return base.Channel.Get_LGBT_Identifications(request);
		}

		public Get_LGBT_Identifications_ResponseType Get_LGBT_Identifications(Workday_Common_HeaderType Workday_Common_Header, Get_LGBT_Identifications_RequestType Get_LGBT_Identifications_Request)
		{
			return ((Human_ResourcesPort)this).Get_LGBT_Identifications(new Get_LGBT_IdentificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_LGBT_Identifications_Request = Get_LGBT_Identifications_Request
			}).Get_LGBT_Identifications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_LGBT_IdentificationsOutput> Human_ResourcesPort.Get_LGBT_IdentificationsAsync(Get_LGBT_IdentificationsInput request)
		{
			return base.Channel.Get_LGBT_IdentificationsAsync(request);
		}

		public Task<Get_LGBT_IdentificationsOutput> Get_LGBT_IdentificationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_LGBT_Identifications_RequestType Get_LGBT_Identifications_Request)
		{
			return ((Human_ResourcesPort)this).Get_LGBT_IdentificationsAsync(new Get_LGBT_IdentificationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_LGBT_Identifications_Request = Get_LGBT_Identifications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_LGBT_IdentificationOutput Human_ResourcesPort.Put_LGBT_Identification(Put_LGBT_IdentificationInput request)
		{
			return base.Channel.Put_LGBT_Identification(request);
		}

		public Put_LGBT_Identification_ResponseType Put_LGBT_Identification(Workday_Common_HeaderType Workday_Common_Header, Put_LGBT_Identification_RequestType Put_LGBT_Identification_Request)
		{
			return ((Human_ResourcesPort)this).Put_LGBT_Identification(new Put_LGBT_IdentificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_LGBT_Identification_Request = Put_LGBT_Identification_Request
			}).Put_LGBT_Identification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_LGBT_IdentificationOutput> Human_ResourcesPort.Put_LGBT_IdentificationAsync(Put_LGBT_IdentificationInput request)
		{
			return base.Channel.Put_LGBT_IdentificationAsync(request);
		}

		public Task<Put_LGBT_IdentificationOutput> Put_LGBT_IdentificationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_LGBT_Identification_RequestType Put_LGBT_Identification_Request)
		{
			return ((Human_ResourcesPort)this).Put_LGBT_IdentificationAsync(new Put_LGBT_IdentificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_LGBT_Identification_Request = Put_LGBT_Identification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Appointment_SpecialtyOutput Human_ResourcesPort.Put_Appointment_Specialty(Put_Appointment_SpecialtyInput request)
		{
			return base.Channel.Put_Appointment_Specialty(request);
		}

		public Put_Appointment_Specialty_ResponseType Put_Appointment_Specialty(Workday_Common_HeaderType Workday_Common_Header, Put_Appointment_Specialty_RequestType Put_Appointment_Specialty_Request)
		{
			return ((Human_ResourcesPort)this).Put_Appointment_Specialty(new Put_Appointment_SpecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Appointment_Specialty_Request = Put_Appointment_Specialty_Request
			}).Put_Appointment_Specialty_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Appointment_SpecialtyOutput> Human_ResourcesPort.Put_Appointment_SpecialtyAsync(Put_Appointment_SpecialtyInput request)
		{
			return base.Channel.Put_Appointment_SpecialtyAsync(request);
		}

		public Task<Put_Appointment_SpecialtyOutput> Put_Appointment_SpecialtyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Appointment_Specialty_RequestType Put_Appointment_Specialty_Request)
		{
			return ((Human_ResourcesPort)this).Put_Appointment_SpecialtyAsync(new Put_Appointment_SpecialtyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Appointment_Specialty_Request = Put_Appointment_Specialty_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Appointment_SpecialtiesOutput Human_ResourcesPort.Get_Appointment_Specialties(Get_Appointment_SpecialtiesInput request)
		{
			return base.Channel.Get_Appointment_Specialties(request);
		}

		public Get_Appointment_Specialties_ResponseType Get_Appointment_Specialties(Workday_Common_HeaderType Workday_Common_Header, Get_Appointment_Specialties_RequestType Get_Appointment_Specialties_Request)
		{
			return ((Human_ResourcesPort)this).Get_Appointment_Specialties(new Get_Appointment_SpecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Appointment_Specialties_Request = Get_Appointment_Specialties_Request
			}).Get_Appointment_Specialties_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Appointment_SpecialtiesOutput> Human_ResourcesPort.Get_Appointment_SpecialtiesAsync(Get_Appointment_SpecialtiesInput request)
		{
			return base.Channel.Get_Appointment_SpecialtiesAsync(request);
		}

		public Task<Get_Appointment_SpecialtiesOutput> Get_Appointment_SpecialtiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Appointment_Specialties_RequestType Get_Appointment_Specialties_Request)
		{
			return ((Human_ResourcesPort)this).Get_Appointment_SpecialtiesAsync(new Get_Appointment_SpecialtiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Appointment_Specialties_Request = Get_Appointment_Specialties_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		End_Collective_Agreement_AssignmentOutput Human_ResourcesPort.End_Collective_Agreement_Assignment(End_Collective_Agreement_AssignmentInput request)
		{
			return base.Channel.End_Collective_Agreement_Assignment(request);
		}

		public End_Collective_Agreement_Assignment_Event_ResponseType End_Collective_Agreement_Assignment(Workday_Common_HeaderType Workday_Common_Header, End_Collective_Agreement_Assignment_Event_RequestType End_Collective_Agreement_Assignment_Event_Request)
		{
			return ((Human_ResourcesPort)this).End_Collective_Agreement_Assignment(new End_Collective_Agreement_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Collective_Agreement_Assignment_Event_Request = End_Collective_Agreement_Assignment_Event_Request
			}).End_Collective_Agreement_Assignment_Event_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<End_Collective_Agreement_AssignmentOutput> Human_ResourcesPort.End_Collective_Agreement_AssignmentAsync(End_Collective_Agreement_AssignmentInput request)
		{
			return base.Channel.End_Collective_Agreement_AssignmentAsync(request);
		}

		public Task<End_Collective_Agreement_AssignmentOutput> End_Collective_Agreement_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, End_Collective_Agreement_Assignment_Event_RequestType End_Collective_Agreement_Assignment_Event_Request)
		{
			return ((Human_ResourcesPort)this).End_Collective_Agreement_AssignmentAsync(new End_Collective_Agreement_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				End_Collective_Agreement_Assignment_Event_Request = End_Collective_Agreement_Assignment_Event_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Committee_MeetingsOutput Human_ResourcesPort.Get_Committee_Meetings(Get_Committee_MeetingsInput request)
		{
			return base.Channel.Get_Committee_Meetings(request);
		}

		public Get_Committee_Meetings_ResponseType Get_Committee_Meetings(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Meetings_RequestType Get_Committee_Meetings_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_Meetings(new Get_Committee_MeetingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Meetings_Request = Get_Committee_Meetings_Request
			}).Get_Committee_Meetings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Committee_MeetingsOutput> Human_ResourcesPort.Get_Committee_MeetingsAsync(Get_Committee_MeetingsInput request)
		{
			return base.Channel.Get_Committee_MeetingsAsync(request);
		}

		public Task<Get_Committee_MeetingsOutput> Get_Committee_MeetingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Committee_Meetings_RequestType Get_Committee_Meetings_Request)
		{
			return ((Human_ResourcesPort)this).Get_Committee_MeetingsAsync(new Get_Committee_MeetingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Committee_Meetings_Request = Get_Committee_Meetings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Committee_MeetingOutput Human_ResourcesPort.Put_Committee_Meeting(Put_Committee_MeetingInput request)
		{
			return base.Channel.Put_Committee_Meeting(request);
		}

		public Put_Committee_Meeting_ResponseType Put_Committee_Meeting(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Meeting_RequestType Put_Committee_Meeting_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_Meeting(new Put_Committee_MeetingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Meeting_Request = Put_Committee_Meeting_Request
			}).Put_Committee_Meeting_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Committee_MeetingOutput> Human_ResourcesPort.Put_Committee_MeetingAsync(Put_Committee_MeetingInput request)
		{
			return base.Channel.Put_Committee_MeetingAsync(request);
		}

		public Task<Put_Committee_MeetingOutput> Put_Committee_MeetingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Committee_Meeting_RequestType Put_Committee_Meeting_Request)
		{
			return ((Human_ResourcesPort)this).Put_Committee_MeetingAsync(new Put_Committee_MeetingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Committee_Meeting_Request = Put_Committee_Meeting_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_EstablishmentsOutput Human_ResourcesPort.Get_Establishments(Get_EstablishmentsInput request)
		{
			return base.Channel.Get_Establishments(request);
		}

		public Get_Establishments_ResponseType Get_Establishments(Workday_Common_HeaderType Workday_Common_Header, Get_Establishments_RequestType Get_Establishments_Request)
		{
			return ((Human_ResourcesPort)this).Get_Establishments(new Get_EstablishmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Establishments_Request = Get_Establishments_Request
			}).Get_Establishments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_EstablishmentsOutput> Human_ResourcesPort.Get_EstablishmentsAsync(Get_EstablishmentsInput request)
		{
			return base.Channel.Get_EstablishmentsAsync(request);
		}

		public Task<Get_EstablishmentsOutput> Get_EstablishmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Establishments_RequestType Get_Establishments_Request)
		{
			return ((Human_ResourcesPort)this).Get_EstablishmentsAsync(new Get_EstablishmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Establishments_Request = Get_Establishments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_EstablishmentOutput Human_ResourcesPort.Put_Establishment(Put_EstablishmentInput request)
		{
			return base.Channel.Put_Establishment(request);
		}

		public Put_Establishment_ResponseType Put_Establishment(Workday_Common_HeaderType Workday_Common_Header, Put_Establishment_RequestType Put_Establishment_Request)
		{
			return ((Human_ResourcesPort)this).Put_Establishment(new Put_EstablishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Establishment_Request = Put_Establishment_Request
			}).Put_Establishment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_EstablishmentOutput> Human_ResourcesPort.Put_EstablishmentAsync(Put_EstablishmentInput request)
		{
			return base.Channel.Put_EstablishmentAsync(request);
		}

		public Task<Put_EstablishmentOutput> Put_EstablishmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Establishment_RequestType Put_Establishment_Request)
		{
			return ((Human_ResourcesPort)this).Put_EstablishmentAsync(new Put_EstablishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Establishment_Request = Put_Establishment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_EstablishmentOutput Human_ResourcesPort.Assign_Establishment(Assign_EstablishmentInput request)
		{
			return base.Channel.Assign_Establishment(request);
		}

		public Assign_Establishment_ResponseType Assign_Establishment(Workday_Common_HeaderType Workday_Common_Header, Assign_Establishment_RequestType Assign_Establishment_Request)
		{
			return ((Human_ResourcesPort)this).Assign_Establishment(new Assign_EstablishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Establishment_Request = Assign_Establishment_Request
			}).Assign_Establishment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_EstablishmentOutput> Human_ResourcesPort.Assign_EstablishmentAsync(Assign_EstablishmentInput request)
		{
			return base.Channel.Assign_EstablishmentAsync(request);
		}

		public Task<Assign_EstablishmentOutput> Assign_EstablishmentAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Establishment_RequestType Assign_Establishment_Request)
		{
			return ((Human_ResourcesPort)this).Assign_EstablishmentAsync(new Assign_EstablishmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Establishment_Request = Assign_Establishment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Workday_AccountOutput Human_ResourcesPort.Get_Workday_Account(Get_Workday_AccountInput request)
		{
			return base.Channel.Get_Workday_Account(request);
		}

		public Get_Workday_Account_ResponseType Get_Workday_Account(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Account_RequestType Get_Workday_Account_Request)
		{
			return ((Human_ResourcesPort)this).Get_Workday_Account(new Get_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Account_Request = Get_Workday_Account_Request
			}).Get_Workday_Account_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Workday_AccountOutput> Human_ResourcesPort.Get_Workday_AccountAsync(Get_Workday_AccountInput request)
		{
			return base.Channel.Get_Workday_AccountAsync(request);
		}

		public Task<Get_Workday_AccountOutput> Get_Workday_AccountAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Account_RequestType Get_Workday_Account_Request)
		{
			return ((Human_ResourcesPort)this).Get_Workday_AccountAsync(new Get_Workday_AccountInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Workday_Account_Request = Get_Workday_Account_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Reactivate_OrganizationOutput Human_ResourcesPort.Reactivate_Organization(Reactivate_OrganizationInput request)
		{
			return base.Channel.Reactivate_Organization(request);
		}

		public Reactivate_Organization_ResponseType Reactivate_Organization(Workday_Common_HeaderType Workday_Common_Header, Reactivate_Organization_RequestType Reactivate_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Reactivate_Organization(new Reactivate_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reactivate_Organization_Request = Reactivate_Organization_Request
			}).Reactivate_Organization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Reactivate_OrganizationOutput> Human_ResourcesPort.Reactivate_OrganizationAsync(Reactivate_OrganizationInput request)
		{
			return base.Channel.Reactivate_OrganizationAsync(request);
		}

		public Task<Reactivate_OrganizationOutput> Reactivate_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Reactivate_Organization_RequestType Reactivate_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Reactivate_OrganizationAsync(new Reactivate_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Reactivate_Organization_Request = Reactivate_Organization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Change_Veteran_Status_IdentificationOutput Human_ResourcesPort.Change_Veteran_Status_Identification(Change_Veteran_Status_IdentificationInput request)
		{
			return base.Channel.Change_Veteran_Status_Identification(request);
		}

		public Change_Veteran_Status_Identification_ResponseType Change_Veteran_Status_Identification(Workday_Common_HeaderType Workday_Common_Header, Change_Veteran_Status_Identification_RequestType Change_Veteran_Status_Identification_Request)
		{
			return ((Human_ResourcesPort)this).Change_Veteran_Status_Identification(new Change_Veteran_Status_IdentificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Veteran_Status_Identification_Request = Change_Veteran_Status_Identification_Request
			}).Change_Veteran_Status_Identification_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Change_Veteran_Status_IdentificationOutput> Human_ResourcesPort.Change_Veteran_Status_IdentificationAsync(Change_Veteran_Status_IdentificationInput request)
		{
			return base.Channel.Change_Veteran_Status_IdentificationAsync(request);
		}

		public Task<Change_Veteran_Status_IdentificationOutput> Change_Veteran_Status_IdentificationAsync(Workday_Common_HeaderType Workday_Common_Header, Change_Veteran_Status_Identification_RequestType Change_Veteran_Status_Identification_Request)
		{
			return ((Human_ResourcesPort)this).Change_Veteran_Status_IdentificationAsync(new Change_Veteran_Status_IdentificationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Change_Veteran_Status_Identification_Request = Change_Veteran_Status_Identification_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assign_Members_to_Custom_OrganizationOutput Human_ResourcesPort.Assign_Members_to_Custom_Organization(Assign_Members_to_Custom_OrganizationInput request)
		{
			return base.Channel.Assign_Members_to_Custom_Organization(request);
		}

		public Assign_Members_to_Custom_Organization_ResponseType Assign_Members_to_Custom_Organization(Workday_Common_HeaderType Workday_Common_Header, Assign_Members_to_Custom_Organization_RequestType Assign_Members_to_Custom_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Assign_Members_to_Custom_Organization(new Assign_Members_to_Custom_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Members_to_Custom_Organization_Request = Assign_Members_to_Custom_Organization_Request
			}).Assign_Members_to_Custom_Organization_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assign_Members_to_Custom_OrganizationOutput> Human_ResourcesPort.Assign_Members_to_Custom_OrganizationAsync(Assign_Members_to_Custom_OrganizationInput request)
		{
			return base.Channel.Assign_Members_to_Custom_OrganizationAsync(request);
		}

		public Task<Assign_Members_to_Custom_OrganizationOutput> Assign_Members_to_Custom_OrganizationAsync(Workday_Common_HeaderType Workday_Common_Header, Assign_Members_to_Custom_Organization_RequestType Assign_Members_to_Custom_Organization_Request)
		{
			return ((Human_ResourcesPort)this).Assign_Members_to_Custom_OrganizationAsync(new Assign_Members_to_Custom_OrganizationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assign_Members_to_Custom_Organization_Request = Assign_Members_to_Custom_Organization_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Work_Status_Rule_SetOutput Human_ResourcesPort.Put_Work_Status_Rule_Set(Put_Work_Status_Rule_SetInput request)
		{
			return base.Channel.Put_Work_Status_Rule_Set(request);
		}

		public Put_Work_Status_Rule_Set_ResponseType Put_Work_Status_Rule_Set(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Status_Rule_Set_RequestType Put_Work_Status_Rule_Set_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_Status_Rule_Set(new Put_Work_Status_Rule_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Status_Rule_Set_Request = Put_Work_Status_Rule_Set_Request
			}).Put_Work_Status_Rule_Set_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Work_Status_Rule_SetOutput> Human_ResourcesPort.Put_Work_Status_Rule_SetAsync(Put_Work_Status_Rule_SetInput request)
		{
			return base.Channel.Put_Work_Status_Rule_SetAsync(request);
		}

		public Task<Put_Work_Status_Rule_SetOutput> Put_Work_Status_Rule_SetAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Work_Status_Rule_Set_RequestType Put_Work_Status_Rule_Set_Request)
		{
			return ((Human_ResourcesPort)this).Put_Work_Status_Rule_SetAsync(new Put_Work_Status_Rule_SetInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Work_Status_Rule_Set_Request = Put_Work_Status_Rule_Set_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Work_Status_Rule_SetsOutput Human_ResourcesPort.Get_Work_Status_Rule_Sets(Get_Work_Status_Rule_SetsInput request)
		{
			return base.Channel.Get_Work_Status_Rule_Sets(request);
		}

		public Get_Work_Status_Rule_Sets_ResponseType Get_Work_Status_Rule_Sets(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Status_Rule_Sets_RequestType Get_Work_Status_Rule_Sets_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_Status_Rule_Sets(new Get_Work_Status_Rule_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Status_Rule_Sets_Request = Get_Work_Status_Rule_Sets_Request
			}).Get_Work_Status_Rule_Sets_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Work_Status_Rule_SetsOutput> Human_ResourcesPort.Get_Work_Status_Rule_SetsAsync(Get_Work_Status_Rule_SetsInput request)
		{
			return base.Channel.Get_Work_Status_Rule_SetsAsync(request);
		}

		public Task<Get_Work_Status_Rule_SetsOutput> Get_Work_Status_Rule_SetsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Work_Status_Rule_Sets_RequestType Get_Work_Status_Rule_Sets_Request)
		{
			return ((Human_ResourcesPort)this).Get_Work_Status_Rule_SetsAsync(new Get_Work_Status_Rule_SetsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Work_Status_Rule_Sets_Request = Get_Work_Status_Rule_Sets_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Period_Reporting_CalendarOutput Human_ResourcesPort.Put_Period_Reporting_Calendar(Put_Period_Reporting_CalendarInput request)
		{
			return base.Channel.Put_Period_Reporting_Calendar(request);
		}

		public Put_Period_Reporting_Calendar_ResponseType Put_Period_Reporting_Calendar(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Reporting_Calendar_RequestType Put_Period_Reporting_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Period_Reporting_Calendar(new Put_Period_Reporting_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Reporting_Calendar_Request = Put_Period_Reporting_Calendar_Request
			}).Put_Period_Reporting_Calendar_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Period_Reporting_CalendarOutput> Human_ResourcesPort.Put_Period_Reporting_CalendarAsync(Put_Period_Reporting_CalendarInput request)
		{
			return base.Channel.Put_Period_Reporting_CalendarAsync(request);
		}

		public Task<Put_Period_Reporting_CalendarOutput> Put_Period_Reporting_CalendarAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Period_Reporting_Calendar_RequestType Put_Period_Reporting_Calendar_Request)
		{
			return ((Human_ResourcesPort)this).Put_Period_Reporting_CalendarAsync(new Put_Period_Reporting_CalendarInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Period_Reporting_Calendar_Request = Put_Period_Reporting_Calendar_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Period_Reporting_CalendarsOutput Human_ResourcesPort.Get_Period_Reporting_Calendars(Get_Period_Reporting_CalendarsInput request)
		{
			return base.Channel.Get_Period_Reporting_Calendars(request);
		}

		public Get_Period_Reporting_Calendars_ResponseType Get_Period_Reporting_Calendars(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Reporting_Calendars_RequestType Get_Period_Reporting_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Period_Reporting_Calendars(new Get_Period_Reporting_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Reporting_Calendars_Request = Get_Period_Reporting_Calendars_Request
			}).Get_Period_Reporting_Calendars_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Period_Reporting_CalendarsOutput> Human_ResourcesPort.Get_Period_Reporting_CalendarsAsync(Get_Period_Reporting_CalendarsInput request)
		{
			return base.Channel.Get_Period_Reporting_CalendarsAsync(request);
		}

		public Task<Get_Period_Reporting_CalendarsOutput> Get_Period_Reporting_CalendarsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Period_Reporting_Calendars_RequestType Get_Period_Reporting_Calendars_Request)
		{
			return ((Human_ResourcesPort)this).Get_Period_Reporting_CalendarsAsync(new Get_Period_Reporting_CalendarsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Period_Reporting_Calendars_Request = Get_Period_Reporting_Calendars_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Location_AttributeOutput Human_ResourcesPort.Put_Location_Attribute(Put_Location_AttributeInput request)
		{
			return base.Channel.Put_Location_Attribute(request);
		}

		public Put_Location_Attribute_ResponseType Put_Location_Attribute(Workday_Common_HeaderType Workday_Common_Header, Put_Location_Attribute_RequestType Put_Location_Attribute_Request)
		{
			return ((Human_ResourcesPort)this).Put_Location_Attribute(new Put_Location_AttributeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Attribute_Request = Put_Location_Attribute_Request
			}).Put_Location_Attribute_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Location_AttributeOutput> Human_ResourcesPort.Put_Location_AttributeAsync(Put_Location_AttributeInput request)
		{
			return base.Channel.Put_Location_AttributeAsync(request);
		}

		public Task<Put_Location_AttributeOutput> Put_Location_AttributeAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Location_Attribute_RequestType Put_Location_Attribute_Request)
		{
			return ((Human_ResourcesPort)this).Put_Location_AttributeAsync(new Put_Location_AttributeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Location_Attribute_Request = Put_Location_Attribute_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Location_AttributesOutput Human_ResourcesPort.Get_Location_Attributes(Get_Location_AttributesInput request)
		{
			return base.Channel.Get_Location_Attributes(request);
		}

		public Get_Location_Attributes_ResponseType Get_Location_Attributes(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Attributes_RequestType Get_Location_Attributes_Request)
		{
			return ((Human_ResourcesPort)this).Get_Location_Attributes(new Get_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Location_Attributes_Request = Get_Location_Attributes_Request
			}).Get_Location_Attributes_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Location_AttributesOutput> Human_ResourcesPort.Get_Location_AttributesAsync(Get_Location_AttributesInput request)
		{
			return base.Channel.Get_Location_AttributesAsync(request);
		}

		public Task<Get_Location_AttributesOutput> Get_Location_AttributesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Location_Attributes_RequestType Get_Location_Attributes_Request)
		{
			return ((Human_ResourcesPort)this).Get_Location_AttributesAsync(new Get_Location_AttributesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Location_Attributes_Request = Get_Location_Attributes_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Disability_Self_Identification_RecordOutput Human_ResourcesPort.Put_External_Disability_Self_Identification_Record(Put_External_Disability_Self_Identification_RecordInput request)
		{
			return base.Channel.Put_External_Disability_Self_Identification_Record(request);
		}

		public Put_External_Disability_Self_Identification_Record_ResponseType Put_External_Disability_Self_Identification_Record(Workday_Common_HeaderType Workday_Common_Header, Put_External_Disability_Self_Identification_Record_RequestType Put_External_Disability_Self_Identification_Record_Request)
		{
			return ((Human_ResourcesPort)this).Put_External_Disability_Self_Identification_Record(new Put_External_Disability_Self_Identification_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Disability_Self_Identification_Record_Request = Put_External_Disability_Self_Identification_Record_Request
			}).Put_External_Disability_Self_Identification_Record_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Disability_Self_Identification_RecordOutput> Human_ResourcesPort.Put_External_Disability_Self_Identification_RecordAsync(Put_External_Disability_Self_Identification_RecordInput request)
		{
			return base.Channel.Put_External_Disability_Self_Identification_RecordAsync(request);
		}

		public Task<Put_External_Disability_Self_Identification_RecordOutput> Put_External_Disability_Self_Identification_RecordAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Disability_Self_Identification_Record_RequestType Put_External_Disability_Self_Identification_Record_Request)
		{
			return ((Human_ResourcesPort)this).Put_External_Disability_Self_Identification_RecordAsync(new Put_External_Disability_Self_Identification_RecordInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Disability_Self_Identification_Record_Request = Put_External_Disability_Self_Identification_Record_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_External_Disability_Self_Identification_RecordsOutput Human_ResourcesPort.Get_External_Disability_Self_Identification_Records(Get_External_Disability_Self_Identification_RecordsInput request)
		{
			return base.Channel.Get_External_Disability_Self_Identification_Records(request);
		}

		public Get_External_Disability_Self_Identification_Records_ResponseType Get_External_Disability_Self_Identification_Records(Workday_Common_HeaderType Workday_Common_Header, Get_External_Disability_Self_Identification_Records_RequestType Get_External_Disability_Self_Identification_Records_Request)
		{
			return ((Human_ResourcesPort)this).Get_External_Disability_Self_Identification_Records(new Get_External_Disability_Self_Identification_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Disability_Self_Identification_Records_Request = Get_External_Disability_Self_Identification_Records_Request
			}).Get_External_Disability_Self_Identification_Records_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_External_Disability_Self_Identification_RecordsOutput> Human_ResourcesPort.Get_External_Disability_Self_Identification_RecordsAsync(Get_External_Disability_Self_Identification_RecordsInput request)
		{
			return base.Channel.Get_External_Disability_Self_Identification_RecordsAsync(request);
		}

		public Task<Get_External_Disability_Self_Identification_RecordsOutput> Get_External_Disability_Self_Identification_RecordsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_External_Disability_Self_Identification_Records_RequestType Get_External_Disability_Self_Identification_Records_Request)
		{
			return ((Human_ResourcesPort)this).Get_External_Disability_Self_Identification_RecordsAsync(new Get_External_Disability_Self_Identification_RecordsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Disability_Self_Identification_Records_Request = Get_External_Disability_Self_Identification_Records_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Gender_IdentitiesOutput Human_ResourcesPort.Get_Gender_Identities(Get_Gender_IdentitiesInput request)
		{
			return base.Channel.Get_Gender_Identities(request);
		}

		public Get_Gender_Identities_ResponseType Get_Gender_Identities(Workday_Common_HeaderType Workday_Common_Header, Get_Gender_Identities_RequestType Get_Gender_Identities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Gender_Identities(new Get_Gender_IdentitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gender_Identities_Request = Get_Gender_Identities_Request
			}).Get_Gender_Identities_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Gender_IdentitiesOutput> Human_ResourcesPort.Get_Gender_IdentitiesAsync(Get_Gender_IdentitiesInput request)
		{
			return base.Channel.Get_Gender_IdentitiesAsync(request);
		}

		public Task<Get_Gender_IdentitiesOutput> Get_Gender_IdentitiesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Gender_Identities_RequestType Get_Gender_Identities_Request)
		{
			return ((Human_ResourcesPort)this).Get_Gender_IdentitiesAsync(new Get_Gender_IdentitiesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Gender_Identities_Request = Get_Gender_Identities_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Gender_IdentityOutput Human_ResourcesPort.Put_Gender_Identity(Put_Gender_IdentityInput request)
		{
			return base.Channel.Put_Gender_Identity(request);
		}

		public Put_Gender_Identity_ResponseType Put_Gender_Identity(Workday_Common_HeaderType Workday_Common_Header, Put_Gender_Identity_RequestType Put_Gender_Identity_Request)
		{
			return ((Human_ResourcesPort)this).Put_Gender_Identity(new Put_Gender_IdentityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gender_Identity_Request = Put_Gender_Identity_Request
			}).Put_Gender_Identity_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Gender_IdentityOutput> Human_ResourcesPort.Put_Gender_IdentityAsync(Put_Gender_IdentityInput request)
		{
			return base.Channel.Put_Gender_IdentityAsync(request);
		}

		public Task<Put_Gender_IdentityOutput> Put_Gender_IdentityAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Gender_Identity_RequestType Put_Gender_Identity_Request)
		{
			return ((Human_ResourcesPort)this).Put_Gender_IdentityAsync(new Put_Gender_IdentityInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Gender_Identity_Request = Put_Gender_Identity_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Sexual_OrientationsOutput Human_ResourcesPort.Get_Sexual_Orientations(Get_Sexual_OrientationsInput request)
		{
			return base.Channel.Get_Sexual_Orientations(request);
		}

		public Get_Sexual_Orientations_ResponseType Get_Sexual_Orientations(Workday_Common_HeaderType Workday_Common_Header, Get_Sexual_Orientations_RequestType Get_Sexual_Orientations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Sexual_Orientations(new Get_Sexual_OrientationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sexual_Orientations_Request = Get_Sexual_Orientations_Request
			}).Get_Sexual_Orientations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Sexual_OrientationsOutput> Human_ResourcesPort.Get_Sexual_OrientationsAsync(Get_Sexual_OrientationsInput request)
		{
			return base.Channel.Get_Sexual_OrientationsAsync(request);
		}

		public Task<Get_Sexual_OrientationsOutput> Get_Sexual_OrientationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Sexual_Orientations_RequestType Get_Sexual_Orientations_Request)
		{
			return ((Human_ResourcesPort)this).Get_Sexual_OrientationsAsync(new Get_Sexual_OrientationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Sexual_Orientations_Request = Get_Sexual_Orientations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Sexual_OrientationOutput Human_ResourcesPort.Put_Sexual_Orientation(Put_Sexual_OrientationInput request)
		{
			return base.Channel.Put_Sexual_Orientation(request);
		}

		public Put_Sexual_Orientation_ResponseType Put_Sexual_Orientation(Workday_Common_HeaderType Workday_Common_Header, Put_Sexual_Orientation_RequestType Put_Sexual_Orientation_Request)
		{
			return ((Human_ResourcesPort)this).Put_Sexual_Orientation(new Put_Sexual_OrientationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sexual_Orientation_Request = Put_Sexual_Orientation_Request
			}).Put_Sexual_Orientation_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Sexual_OrientationOutput> Human_ResourcesPort.Put_Sexual_OrientationAsync(Put_Sexual_OrientationInput request)
		{
			return base.Channel.Put_Sexual_OrientationAsync(request);
		}

		public Task<Put_Sexual_OrientationOutput> Put_Sexual_OrientationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Sexual_Orientation_RequestType Put_Sexual_Orientation_Request)
		{
			return ((Human_ResourcesPort)this).Put_Sexual_OrientationAsync(new Put_Sexual_OrientationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Sexual_Orientation_Request = Put_Sexual_Orientation_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PronounsOutput Human_ResourcesPort.Get_Pronouns(Get_PronounsInput request)
		{
			return base.Channel.Get_Pronouns(request);
		}

		public Get_Pronouns_ResponseType Get_Pronouns(Workday_Common_HeaderType Workday_Common_Header, Get_Pronouns_RequestType Get_Pronouns_Request)
		{
			return ((Human_ResourcesPort)this).Get_Pronouns(new Get_PronounsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Pronouns_Request = Get_Pronouns_Request
			}).Get_Pronouns_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PronounsOutput> Human_ResourcesPort.Get_PronounsAsync(Get_PronounsInput request)
		{
			return base.Channel.Get_PronounsAsync(request);
		}

		public Task<Get_PronounsOutput> Get_PronounsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Pronouns_RequestType Get_Pronouns_Request)
		{
			return ((Human_ResourcesPort)this).Get_PronounsAsync(new Get_PronounsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Pronouns_Request = Get_Pronouns_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_PronounOutput Human_ResourcesPort.Put_Pronoun(Put_PronounInput request)
		{
			return base.Channel.Put_Pronoun(request);
		}

		public Put_Pronoun_ResponseType Put_Pronoun(Workday_Common_HeaderType Workday_Common_Header, Put_Pronoun_RequestType Put_Pronoun_Request)
		{
			return ((Human_ResourcesPort)this).Put_Pronoun(new Put_PronounInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Pronoun_Request = Put_Pronoun_Request
			}).Put_Pronoun_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_PronounOutput> Human_ResourcesPort.Put_PronounAsync(Put_PronounInput request)
		{
			return base.Channel.Put_PronounAsync(request);
		}

		public Task<Put_PronounOutput> Put_PronounAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Pronoun_RequestType Put_Pronoun_Request)
		{
			return ((Human_ResourcesPort)this).Put_PronounAsync(new Put_PronounInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Pronoun_Request = Put_Pronoun_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_Reference_Letter_for_WorkerOutput Human_ResourcesPort.Create_Reference_Letter_for_Worker(Create_Reference_Letter_for_WorkerInput request)
		{
			return base.Channel.Create_Reference_Letter_for_Worker(request);
		}

		public Create_Reference_Letter_for_Worker_ResponseType Create_Reference_Letter_for_Worker(Workday_Common_HeaderType Workday_Common_Header, Create_Reference_Letter_for_Worker_RequestType Create_Reference_Letter_for_Worker_Request)
		{
			return ((Human_ResourcesPort)this).Create_Reference_Letter_for_Worker(new Create_Reference_Letter_for_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Reference_Letter_for_Worker_Request = Create_Reference_Letter_for_Worker_Request
			}).Create_Reference_Letter_for_Worker_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_Reference_Letter_for_WorkerOutput> Human_ResourcesPort.Create_Reference_Letter_for_WorkerAsync(Create_Reference_Letter_for_WorkerInput request)
		{
			return base.Channel.Create_Reference_Letter_for_WorkerAsync(request);
		}

		public Task<Create_Reference_Letter_for_WorkerOutput> Create_Reference_Letter_for_WorkerAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Reference_Letter_for_Worker_RequestType Create_Reference_Letter_for_Worker_Request)
		{
			return ((Human_ResourcesPort)this).Create_Reference_Letter_for_WorkerAsync(new Create_Reference_Letter_for_WorkerInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Reference_Letter_for_Worker_Request = Create_Reference_Letter_for_Worker_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Universal_IdentifierOutput Human_ResourcesPort.Get_Universal_Identifier(Get_Universal_IdentifierInput request)
		{
			return base.Channel.Get_Universal_Identifier(request);
		}

		public Get_Universal_Identifiers_ResponseType Get_Universal_Identifier(Workday_Common_HeaderType Workday_Common_Header, Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request)
		{
			return ((Human_ResourcesPort)this).Get_Universal_Identifier(new Get_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Universal_Identifiers_Request = Get_Universal_Identifiers_Request
			}).Get_Universal_Identifiers_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Universal_IdentifierOutput> Human_ResourcesPort.Get_Universal_IdentifierAsync(Get_Universal_IdentifierInput request)
		{
			return base.Channel.Get_Universal_IdentifierAsync(request);
		}

		public Task<Get_Universal_IdentifierOutput> Get_Universal_IdentifierAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Universal_Identifiers_RequestType Get_Universal_Identifiers_Request)
		{
			return ((Human_ResourcesPort)this).Get_Universal_IdentifierAsync(new Get_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Universal_Identifiers_Request = Get_Universal_Identifiers_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Universal_IdentifierOutput Human_ResourcesPort.Put_Universal_Identifier(Put_Universal_IdentifierInput request)
		{
			return base.Channel.Put_Universal_Identifier(request);
		}

		public Put_Universal_Identifier_ResponseType Put_Universal_Identifier(Workday_Common_HeaderType Workday_Common_Header, Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request)
		{
			return ((Human_ResourcesPort)this).Put_Universal_Identifier(new Put_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Universal_Identifier_Request = Put_Universal_Identifier_Request
			}).Put_Universal_Identifier_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Universal_IdentifierOutput> Human_ResourcesPort.Put_Universal_IdentifierAsync(Put_Universal_IdentifierInput request)
		{
			return base.Channel.Put_Universal_IdentifierAsync(request);
		}

		public Task<Put_Universal_IdentifierOutput> Put_Universal_IdentifierAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Universal_Identifier_RequestType Put_Universal_Identifier_Request)
		{
			return ((Human_ResourcesPort)this).Put_Universal_IdentifierAsync(new Put_Universal_IdentifierInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Universal_Identifier_Request = Put_Universal_Identifier_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_Universal_IdentifiersOutput Human_ResourcesPort.Import_Universal_Identifiers(Import_Universal_IdentifiersInput request)
		{
			return base.Channel.Import_Universal_Identifiers(request);
		}

		public Put_Import_Process_ResponseType Import_Universal_Identifiers(Workday_Common_HeaderType Workday_Common_Header, Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request)
		{
			return ((Human_ResourcesPort)this).Import_Universal_Identifiers(new Import_Universal_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Universal_Identifier_Request = Import_Universal_Identifier_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_Universal_IdentifiersOutput> Human_ResourcesPort.Import_Universal_IdentifiersAsync(Import_Universal_IdentifiersInput request)
		{
			return base.Channel.Import_Universal_IdentifiersAsync(request);
		}

		public Task<Import_Universal_IdentifiersOutput> Import_Universal_IdentifiersAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Universal_Identifier_RequestType Import_Universal_Identifier_Request)
		{
			return ((Human_ResourcesPort)this).Import_Universal_IdentifiersAsync(new Import_Universal_IdentifiersInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Universal_Identifier_Request = Import_Universal_Identifier_Request
			});
		}
	}
}
