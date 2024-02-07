using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Human_Resources", ConfigurationName = "Human_ResourcesService.Human_ResourcesPort")]
	public interface Human_ResourcesPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_LocationOutput Put_Location(Put_LocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_LocationOutput> Put_LocationAsync(Put_LocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Find_Business_SiteOutput Find_Business_Site(Find_Business_SiteInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Find_Business_SiteOutput> Find_Business_SiteAsync(Find_Business_SiteInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrganizationOutput Get_Organization(Get_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrganizationOutput> Get_OrganizationAsync(Get_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Update_OrganizationOutput Add_Update_Organization(Add_Update_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Update_OrganizationOutput> Add_Update_OrganizationAsync(Add_Update_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_Personal_InfoOutput Get_Employee_Personal_Info(Get_Employee_Personal_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_Personal_InfoOutput> Get_Employee_Personal_InfoAsync(Get_Employee_Personal_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contingent_Worker_Contract_InfoOutput Get_Contingent_Worker_Contract_Info(Get_Contingent_Worker_Contract_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contingent_Worker_Contract_InfoOutput> Get_Contingent_Worker_Contract_InfoAsync(Get_Contingent_Worker_Contract_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_ProfileOutput Get_Worker_Profile(Get_Worker_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_ProfileOutput> Get_Worker_ProfileAsync(Get_Worker_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Previous_System_Job_HistoryOutput Put_Previous_System_Job_History(Put_Previous_System_Job_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Previous_System_Job_HistoryOutput> Put_Previous_System_Job_HistoryAsync(Put_Previous_System_Job_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Dissolve_Organization_StructureOutput Dissolve_Organization_Structure(Dissolve_Organization_StructureInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Dissolve_Organization_StructureOutput> Dissolve_Organization_StructureAsync(Dissolve_Organization_StructureInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Find_OrganizationOutput Find_Organization(Find_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Find_OrganizationOutput> Find_OrganizationAsync(Find_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Employee_Personal_InfoOutput Update_Employee_Personal_Info(Update_Employee_Personal_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Employee_Personal_InfoOutput> Update_Employee_Personal_InfoAsync(Update_Employee_Personal_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Business_SiteOutput Get_Business_Site(Get_Business_SiteInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Business_SiteOutput> Get_Business_SiteAsync(Get_Business_SiteInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_Employment_InfoOutput Get_Employee_Employment_Info(Get_Employee_Employment_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_Employment_InfoOutput> Get_Employee_Employment_InfoAsync(Get_Employee_Employment_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contingent_Worker_Personal_InfoOutput Get_Contingent_Worker_Personal_Info(Get_Contingent_Worker_Personal_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contingent_Worker_Personal_InfoOutput> Get_Contingent_Worker_Personal_InfoAsync(Get_Contingent_Worker_Personal_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Contingent_Worker_Personal_InfoOutput Update_Contingent_Worker_Personal_Info(Update_Contingent_Worker_Personal_InfoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Contingent_Worker_Personal_InfoOutput> Update_Contingent_Worker_Personal_InfoAsync(Update_Contingent_Worker_Personal_InfoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Inactivate_OrganizationOutput Inactivate_Organization(Inactivate_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Inactivate_OrganizationOutput> Inactivate_OrganizationAsync(Inactivate_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_Related_PersonsOutput Get_Employee_Related_Persons(Get_Employee_Related_PersonsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_Related_PersonsOutput> Get_Employee_Related_PersonsAsync(Get_Employee_Related_PersonsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_LocationsOutput Get_Locations(Get_LocationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_LocationsOutput> Get_LocationsAsync(Get_LocationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Previous_System_Job_HistoryOutput Get_Previous_System_Job_History(Get_Previous_System_Job_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Previous_System_Job_HistoryOutput> Get_Previous_System_Job_HistoryAsync(Get_Previous_System_Job_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Server_TimestampOutput Get_Server_Timestamp(Get_Server_TimestampInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Server_TimestampOutput> Get_Server_TimestampAsync(Get_Server_TimestampInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Employee_ImageOutput Update_Employee_Image(Update_Employee_ImageInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Employee_ImageOutput> Update_Employee_ImageAsync(Update_Employee_ImageInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_EmployeeOutput Get_Employee(Get_EmployeeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_EmployeeOutput> Get_EmployeeAsync(Get_EmployeeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Contingent_WorkerOutput Get_Contingent_Worker(Get_Contingent_WorkerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Contingent_WorkerOutput> Get_Contingent_WorkerAsync(Get_Contingent_WorkerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_Event_HistoryOutput Get_Worker_Event_History(Get_Worker_Event_HistoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_Event_HistoryOutput> Get_Worker_Event_HistoryAsync(Get_Worker_Event_HistoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Workday_AccountOutput Update_Workday_Account(Update_Workday_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Workday_AccountOutput> Update_Workday_AccountAsync(Update_Workday_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Add_Workday_AccountOutput Add_Workday_Account(Add_Workday_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Add_Workday_AccountOutput> Add_Workday_AccountAsync(Add_Workday_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Company_Insider_TypeOutput Put_Company_Insider_Type(Put_Company_Insider_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Company_Insider_TypeOutput> Put_Company_Insider_TypeAsync(Put_Company_Insider_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Company_Insider_TypesOutput Get_Company_Insider_Types(Get_Company_Insider_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Company_Insider_TypesOutput> Get_Company_Insider_TypesAsync(Get_Company_Insider_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Employee_ImageOutput Get_Employee_Image(Get_Employee_ImageInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Employee_ImageOutput> Get_Employee_ImageAsync(Get_Employee_ImageInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Work_ShiftOutput Put_Work_Shift(Put_Work_ShiftInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Work_ShiftOutput> Put_Work_ShiftAsync(Put_Work_ShiftInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Work_ShiftsOutput Get_Work_Shifts(Get_Work_ShiftsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Work_ShiftsOutput> Get_Work_ShiftsAsync(Get_Work_ShiftsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_CategoryOutput Put_Job_Category(Put_Job_CategoryInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_CategoryOutput> Put_Job_CategoryAsync(Put_Job_CategoryInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_CategoriesOutput Get_Job_Categories(Get_Job_CategoriesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_CategoriesOutput> Get_Job_CategoriesAsync(Get_Job_CategoriesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_WorkersOutput Get_Workers(Get_WorkersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_WorkersOutput> Get_WorkersAsync(Get_WorkersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DependentOutput Put_Dependent(Put_DependentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DependentOutput> Put_DependentAsync(Put_DependentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrganizationsOutput Get_Organizations(Get_OrganizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Get_OrganizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Workers_Compensation_CodeOutput Put_Workers_Compensation_Code(Put_Workers_Compensation_CodeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Workers_Compensation_CodeOutput> Put_Workers_Compensation_CodeAsync(Put_Workers_Compensation_CodeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workers_Compensation_CodesOutput Get_Workers_Compensation_Codes(Get_Workers_Compensation_CodesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workers_Compensation_CodesOutput> Get_Workers_Compensation_CodesAsync(Get_Workers_Compensation_CodesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Holiday_CalendarsOutput Get_Holiday_Calendars(Get_Holiday_CalendarsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Holiday_CalendarsOutput> Get_Holiday_CalendarsAsync(Get_Holiday_CalendarsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Holiday_CalendarOutput Put_Holiday_Calendar(Put_Holiday_CalendarInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Holiday_CalendarOutput> Put_Holiday_CalendarAsync(Put_Holiday_CalendarInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Work_Schedule_CalendarsOutput Get_Work_Schedule_Calendars(Get_Work_Schedule_CalendarsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Work_Schedule_CalendarsOutput> Get_Work_Schedule_CalendarsAsync(Get_Work_Schedule_CalendarsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Work_Schedule_CalendarOutput Put_Work_Schedule_Calendar(Put_Work_Schedule_CalendarInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Work_Schedule_CalendarOutput> Put_Work_Schedule_CalendarAsync(Put_Work_Schedule_CalendarInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Supervisory_Organization_Assignment_RestrictionsOutput Get_Supervisory_Organization_Assignment_Restrictions(Get_Supervisory_Organization_Assignment_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Supervisory_Organization_Assignment_RestrictionsOutput> Get_Supervisory_Organization_Assignment_RestrictionsAsync(Get_Supervisory_Organization_Assignment_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Supervisory_Organization_Assignment_RestrictionsOutput Put_Supervisory_Organization_Assignment_Restrictions(Put_Supervisory_Organization_Assignment_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Supervisory_Organization_Assignment_RestrictionsOutput> Put_Supervisory_Organization_Assignment_RestrictionsAsync(Put_Supervisory_Organization_Assignment_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_FrequenciesOutput Get_Frequencies(Get_FrequenciesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_FrequenciesOutput> Get_FrequenciesAsync(Get_FrequenciesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_FrequencyOutput Put_Frequency(Put_FrequencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_FrequencyOutput> Put_FrequencyAsync(Put_FrequencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_DisabilitiesOutput Get_Disabilities(Get_DisabilitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_DisabilitiesOutput> Get_DisabilitiesAsync(Get_DisabilitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_DisabilityOutput Put_Disability(Put_DisabilityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_DisabilityOutput> Put_DisabilityAsync(Put_DisabilityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_ProfileOutput Put_Job_Profile(Put_Job_ProfileInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_ProfileOutput> Put_Job_ProfileAsync(Put_Job_ProfileInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_ProfilesOutput Get_Job_Profiles(Get_Job_ProfilesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_ProfilesOutput> Get_Job_ProfilesAsync(Get_Job_ProfilesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_EthnicitiesOutput Get_Ethnicities(Get_EthnicitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_EthnicitiesOutput> Get_EthnicitiesAsync(Get_EthnicitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_EthnicityOutput Put_Ethnicity(Put_EthnicityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_EthnicityOutput> Put_EthnicityAsync(Put_EthnicityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Training_TypesOutput Get_Training_Types(Get_Training_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Training_TypesOutput> Get_Training_TypesAsync(Get_Training_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Training_TypeOutput Put_Training_Type(Put_Training_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Training_TypeOutput> Put_Training_TypeAsync(Put_Training_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Classification_GroupsOutput Get_Job_Classification_Groups(Get_Job_Classification_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Classification_GroupsOutput> Get_Job_Classification_GroupsAsync(Get_Job_Classification_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Classification_GroupOutput Put_Job_Classification_Group(Put_Job_Classification_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Classification_GroupOutput> Put_Job_Classification_GroupAsync(Put_Job_Classification_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_FamiliesOutput Get_Job_Families(Get_Job_FamiliesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_FamiliesOutput> Get_Job_FamiliesAsync(Get_Job_FamiliesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_FamilyOutput Put_Job_Family(Put_Job_FamilyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_FamilyOutput> Put_Job_FamilyAsync(Put_Job_FamilyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Family_GroupsOutput Get_Job_Family_Groups(Get_Job_Family_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Family_GroupsOutput> Get_Job_Family_GroupsAsync(Get_Job_Family_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Family_GroupOutput Put_Job_Family_Group(Put_Job_Family_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Family_GroupOutput> Put_Job_Family_GroupAsync(Put_Job_Family_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_UserBased_Security_Group_AssignmentsOutput Put_UserBased_Security_Group_Assignments(Put_UserBased_Security_Group_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_UserBased_Security_Group_AssignmentsOutput> Put_UserBased_Security_Group_AssignmentsAsync(Put_UserBased_Security_Group_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_UserBased_Security_Group_AssignmentsOutput Get_UserBased_Security_Group_Assignments(Get_UserBased_Security_Group_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_UserBased_Security_Group_AssignmentsOutput> Get_UserBased_Security_Group_AssignmentsAsync(Get_UserBased_Security_Group_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Difficulty_to_FillOutput Get_Difficulty_to_Fill(Get_Difficulty_to_FillInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Difficulty_to_FillOutput> Get_Difficulty_to_FillAsync(Get_Difficulty_to_FillInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Difficulty_to_FillOutput Put_Difficulty_to_Fill(Put_Difficulty_to_FillInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Difficulty_to_FillOutput> Put_Difficulty_to_FillAsync(Put_Difficulty_to_FillInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Worker_PhotosOutput Get_Worker_Photos(Get_Worker_PhotosInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Worker_PhotosOutput> Get_Worker_PhotosAsync(Get_Worker_PhotosInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Worker_PhotoOutput Put_Worker_Photo(Put_Worker_PhotoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Worker_PhotoOutput> Put_Worker_PhotoAsync(Put_Worker_PhotoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Union_MembershipOutput Manage_Union_Membership(Manage_Union_MembershipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Union_MembershipOutput> Manage_Union_MembershipAsync(Manage_Union_MembershipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Academic_RanksOutput Get_Academic_Ranks(Get_Academic_RanksInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Academic_RanksOutput> Get_Academic_RanksAsync(Get_Academic_RanksInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Academic_RankOutput Put_Academic_Rank(Put_Academic_RankInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Academic_RankOutput> Put_Academic_RankAsync(Put_Academic_RankInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Academic_AppointmentOutput End_Academic_Appointment(End_Academic_AppointmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Academic_AppointmentOutput> End_Academic_AppointmentAsync(End_Academic_AppointmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Provisioning_GroupsOutput Get_Provisioning_Groups(Get_Provisioning_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Provisioning_GroupsOutput> Get_Provisioning_GroupsAsync(Get_Provisioning_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Academic_AppointmentOutput Add_Academic_Appointment(Add_Academic_AppointmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Academic_AppointmentOutput> Add_Academic_AppointmentAsync(Add_Academic_AppointmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Academic_AppointmentOutput Update_Academic_Appointment(Update_Academic_AppointmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Academic_AppointmentOutput> Update_Academic_AppointmentAsync(Update_Academic_AppointmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Provisioning_GroupOutput Put_Provisioning_Group(Put_Provisioning_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Provisioning_GroupOutput> Put_Provisioning_GroupAsync(Put_Provisioning_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Provisioning_Group_AssignmentsOutput Get_Provisioning_Group_Assignments(Get_Provisioning_Group_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Provisioning_Group_AssignmentsOutput> Get_Provisioning_Group_AssignmentsAsync(Get_Provisioning_Group_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Provisioning_Group_AssignmentOutput Put_Provisioning_Group_Assignment(Put_Provisioning_Group_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Provisioning_Group_AssignmentOutput> Put_Provisioning_Group_AssignmentAsync(Put_Provisioning_Group_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Search_SettingsOutput Get_Search_Settings(Get_Search_SettingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Search_SettingsOutput> Get_Search_SettingsAsync(Get_Search_SettingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Search_SettingsOutput Put_Search_Settings(Put_Search_SettingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Search_SettingsOutput> Put_Search_SettingsAsync(Put_Search_SettingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Addresses_for_Country_Format_ExtensionOutput Put_Addresses_for_Country_Format_Extension(Put_Addresses_for_Country_Format_ExtensionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Addresses_for_Country_Format_ExtensionOutput> Put_Addresses_for_Country_Format_ExtensionAsync(Put_Addresses_for_Country_Format_ExtensionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Maintain_Contact_InformationOutput Maintain_Contact_Information(Maintain_Contact_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Maintain_Contact_InformationOutput> Maintain_Contact_InformationAsync(Maintain_Contact_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Service_Center_RepresentativesOutput Get_Service_Center_Representatives(Get_Service_Center_RepresentativesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Service_Center_RepresentativesOutput> Get_Service_Center_RepresentativesAsync(Get_Service_Center_RepresentativesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Service_Center_RepresentativeOutput Put_Service_Center_Representative(Put_Service_Center_RepresentativeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Service_Center_RepresentativeOutput> Put_Service_Center_RepresentativeAsync(Put_Service_Center_RepresentativeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Service_Center_Representative_Workday_AccountsOutput Get_Service_Center_Representative_Workday_Accounts(Get_Service_Center_Representative_Workday_AccountsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Service_Center_Representative_Workday_AccountsOutput> Get_Service_Center_Representative_Workday_AccountsAsync(Get_Service_Center_Representative_Workday_AccountsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Service_Center_Representative_Workday_AccountOutput Put_Service_Center_Representative_Workday_Account(Put_Service_Center_Representative_Workday_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Service_Center_Representative_Workday_AccountOutput> Put_Service_Center_Representative_Workday_AccountAsync(Put_Service_Center_Representative_Workday_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Background_Check_StatusOutput Change_Background_Check_Status(Change_Background_Check_StatusInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Background_Check_StatusOutput> Change_Background_Check_StatusAsync(Change_Background_Check_StatusInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Academic_UnitsOutput Get_Academic_Units(Get_Academic_UnitsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Academic_UnitsOutput> Get_Academic_UnitsAsync(Get_Academic_UnitsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Academic_UnitOutput Put_Academic_Unit(Put_Academic_UnitInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Academic_UnitOutput> Put_Academic_UnitAsync(Put_Academic_UnitInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Academic_Unit_HierarchiesOutput Get_Academic_Unit_Hierarchies(Get_Academic_Unit_HierarchiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Academic_Unit_HierarchiesOutput> Get_Academic_Unit_HierarchiesAsync(Get_Academic_Unit_HierarchiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Academic_Unit_HierarchyOutput Put_Academic_Unit_Hierarchy(Put_Academic_Unit_HierarchyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Academic_Unit_HierarchyOutput> Put_Academic_Unit_HierarchyAsync(Put_Academic_Unit_HierarchyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Political_AffiliationsOutput Get_Political_Affiliations(Get_Political_AffiliationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Political_AffiliationsOutput> Get_Political_AffiliationsAsync(Get_Political_AffiliationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Political_AffiliationOutput Put_Political_Affiliation(Put_Political_AffiliationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Political_AffiliationOutput> Put_Political_AffiliationAsync(Put_Political_AffiliationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Personal_InformationOutput Change_Personal_Information(Change_Personal_InformationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Personal_InformationOutput> Change_Personal_InformationAsync(Change_Personal_InformationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Government_IDsOutput Change_Government_IDs(Change_Government_IDsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Government_IDsOutput> Change_Government_IDsAsync(Change_Government_IDsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Legal_NameOutput Change_Legal_Name(Change_Legal_NameInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Legal_NameOutput> Change_Legal_NameAsync(Change_Legal_NameInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Preferred_NameOutput Change_Preferred_Name(Change_Preferred_NameInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Preferred_NameOutput> Change_Preferred_NameAsync(Change_Preferred_NameInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Additional_NamesOutput Change_Additional_Names(Change_Additional_NamesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Additional_NamesOutput> Change_Additional_NamesAsync(Change_Additional_NamesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Passports_and_VisasOutput Change_Passports_and_Visas(Change_Passports_and_VisasInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Passports_and_VisasOutput> Change_Passports_and_VisasAsync(Change_Passports_and_VisasInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_LicensesOutput Change_Licenses(Change_LicensesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_LicensesOutput> Change_LicensesAsync(Change_LicensesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Other_IDsOutput Change_Other_IDs(Change_Other_IDsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Other_IDsOutput> Change_Other_IDsAsync(Change_Other_IDsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Former_WorkerOutput Put_Former_Worker(Put_Former_WorkerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Former_WorkerOutput> Put_Former_WorkerAsync(Put_Former_WorkerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Former_WorkersOutput Get_Former_Workers(Get_Former_WorkersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Former_WorkersOutput> Get_Former_WorkersAsync(Get_Former_WorkersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Social_Benefits_LocalitiesOutput Get_Social_Benefits_Localities(Get_Social_Benefits_LocalitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Social_Benefits_LocalitiesOutput> Get_Social_Benefits_LocalitiesAsync(Get_Social_Benefits_LocalitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Social_Benefits_LocalityOutput Put_Social_Benefits_Locality(Put_Social_Benefits_LocalityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Social_Benefits_LocalityOutput> Put_Social_Benefits_LocalityAsync(Put_Social_Benefits_LocalityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Former_Worker_DocumentOutput Put_Former_Worker_Document(Put_Former_Worker_DocumentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Former_Worker_DocumentOutput> Put_Former_Worker_DocumentAsync(Put_Former_Worker_DocumentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Former_Worker_DocumentsOutput Get_Former_Worker_Documents(Get_Former_Worker_DocumentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Former_Worker_DocumentsOutput> Get_Former_Worker_DocumentsAsync(Get_Former_Worker_DocumentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_Named_ProfessorshipOutput Create_Named_Professorship(Create_Named_ProfessorshipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_Named_ProfessorshipOutput> Create_Named_ProfessorshipAsync(Create_Named_ProfessorshipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Named_ProfessorshipOutput Edit_Named_Professorship(Edit_Named_ProfessorshipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Named_ProfessorshipOutput> Edit_Named_ProfessorshipAsync(Edit_Named_ProfessorshipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Assign_UserBased_Security_GroupOutput Put_Assign_UserBased_Security_Group(Put_Assign_UserBased_Security_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Assign_UserBased_Security_GroupOutput> Put_Assign_UserBased_Security_GroupAsync(Put_Assign_UserBased_Security_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Assign_UserBased_Security_GroupOutput Get_Assign_UserBased_Security_Group(Get_Assign_UserBased_Security_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Assign_UserBased_Security_GroupOutput> Get_Assign_UserBased_Security_GroupAsync(Get_Assign_UserBased_Security_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Employee_Collective_Agreement_EventOutput Assign_Employee_Collective_Agreement_Event(Assign_Employee_Collective_Agreement_EventInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Employee_Collective_Agreement_EventOutput> Assign_Employee_Collective_Agreement_EventAsync(Assign_Employee_Collective_Agreement_EventInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Emergency_ContactsOutput Change_Emergency_Contacts(Change_Emergency_ContactsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Emergency_ContactsOutput> Change_Emergency_ContactsAsync(Change_Emergency_ContactsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Reassign_Superior_to_Inactive_OrganizationOutput Reassign_Superior_to_Inactive_Organization(Reassign_Superior_to_Inactive_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Reassign_Superior_to_Inactive_OrganizationOutput> Reassign_Superior_to_Inactive_OrganizationAsync(Reassign_Superior_to_Inactive_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Location_Hierarchy_Organization_AssignmentsOutput Put_Location_Hierarchy_Organization_Assignments(Put_Location_Hierarchy_Organization_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Location_Hierarchy_Organization_AssignmentsOutput> Put_Location_Hierarchy_Organization_AssignmentsAsync(Put_Location_Hierarchy_Organization_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Location_Hierarchy_Organization_AssignmentsOutput Get_Location_Hierarchy_Organization_Assignments(Get_Location_Hierarchy_Organization_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Location_Hierarchy_Organization_AssignmentsOutput> Get_Location_Hierarchy_Organization_AssignmentsAsync(Get_Location_Hierarchy_Organization_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Organization_Reference_IDsOutput Get_Organization_Reference_IDs(Get_Organization_Reference_IDsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Organization_Reference_IDsOutput> Get_Organization_Reference_IDsAsync(Get_Organization_Reference_IDsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Organization_Reference_IDOutput Put_Organization_Reference_ID(Put_Organization_Reference_IDInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Organization_Reference_IDOutput> Put_Organization_Reference_IDAsync(Put_Organization_Reference_IDInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Committee_TypeOutput Put_Committee_Type(Put_Committee_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Committee_TypeOutput> Put_Committee_TypeAsync(Put_Committee_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_TypesOutput Get_Committee_Types(Get_Committee_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_TypesOutput> Get_Committee_TypesAsync(Get_Committee_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Committee_Classification_GroupOutput Put_Committee_Classification_Group(Put_Committee_Classification_GroupInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Committee_Classification_GroupOutput> Put_Committee_Classification_GroupAsync(Put_Committee_Classification_GroupInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_Classification_GroupsOutput Get_Committee_Classification_Groups(Get_Committee_Classification_GroupsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_Classification_GroupsOutput> Get_Committee_Classification_GroupsAsync(Get_Committee_Classification_GroupsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Committee_ClassificationOutput Put_Committee_Classification(Put_Committee_ClassificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Committee_ClassificationOutput> Put_Committee_ClassificationAsync(Put_Committee_ClassificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_ClassificationsOutput Get_Committee_Classifications(Get_Committee_ClassificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_ClassificationsOutput> Get_Committee_ClassificationsAsync(Get_Committee_ClassificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_Membership_TypesOutput Get_Committee_Membership_Types(Get_Committee_Membership_TypesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_Membership_TypesOutput> Get_Committee_Membership_TypesAsync(Get_Committee_Membership_TypesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Committee_Membership_TypeOutput Put_Committee_Membership_Type(Put_Committee_Membership_TypeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Committee_Membership_TypeOutput> Put_Committee_Membership_TypeAsync(Put_Committee_Membership_TypeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Committee_MembershipOutput Manage_Committee_Membership(Manage_Committee_MembershipInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Committee_MembershipOutput> Manage_Committee_MembershipAsync(Manage_Committee_MembershipInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Employee_Probation_Periods_EventOutput Manage_Employee_Probation_Periods_Event(Manage_Employee_Probation_Periods_EventInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Employee_Probation_Periods_EventOutput> Manage_Employee_Probation_Periods_EventAsync(Manage_Employee_Probation_Periods_EventInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Maintain_Committee_DefinitionOutput Maintain_Committee_Definition(Maintain_Committee_DefinitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Maintain_Committee_DefinitionOutput> Maintain_Committee_DefinitionAsync(Maintain_Committee_DefinitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_DefinitionOutput Get_Committee_Definition(Get_Committee_DefinitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_DefinitionOutput> Get_Committee_DefinitionAsync(Get_Committee_DefinitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_LGBT_IdentificationsOutput Get_LGBT_Identifications(Get_LGBT_IdentificationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_LGBT_IdentificationsOutput> Get_LGBT_IdentificationsAsync(Get_LGBT_IdentificationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_LGBT_IdentificationOutput Put_LGBT_Identification(Put_LGBT_IdentificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_LGBT_IdentificationOutput> Put_LGBT_IdentificationAsync(Put_LGBT_IdentificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Appointment_SpecialtyOutput Put_Appointment_Specialty(Put_Appointment_SpecialtyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Appointment_SpecialtyOutput> Put_Appointment_SpecialtyAsync(Put_Appointment_SpecialtyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Appointment_SpecialtiesOutput Get_Appointment_Specialties(Get_Appointment_SpecialtiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Appointment_SpecialtiesOutput> Get_Appointment_SpecialtiesAsync(Get_Appointment_SpecialtiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		End_Collective_Agreement_AssignmentOutput End_Collective_Agreement_Assignment(End_Collective_Agreement_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<End_Collective_Agreement_AssignmentOutput> End_Collective_Agreement_AssignmentAsync(End_Collective_Agreement_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Committee_MeetingsOutput Get_Committee_Meetings(Get_Committee_MeetingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Committee_MeetingsOutput> Get_Committee_MeetingsAsync(Get_Committee_MeetingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Committee_MeetingOutput Put_Committee_Meeting(Put_Committee_MeetingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Committee_MeetingOutput> Put_Committee_MeetingAsync(Put_Committee_MeetingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_EstablishmentsOutput Get_Establishments(Get_EstablishmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_EstablishmentsOutput> Get_EstablishmentsAsync(Get_EstablishmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_EstablishmentOutput Put_Establishment(Put_EstablishmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_EstablishmentOutput> Put_EstablishmentAsync(Put_EstablishmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_EstablishmentOutput Assign_Establishment(Assign_EstablishmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_EstablishmentOutput> Assign_EstablishmentAsync(Assign_EstablishmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Workday_AccountOutput Get_Workday_Account(Get_Workday_AccountInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Workday_AccountOutput> Get_Workday_AccountAsync(Get_Workday_AccountInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Reactivate_OrganizationOutput Reactivate_Organization(Reactivate_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Reactivate_OrganizationOutput> Reactivate_OrganizationAsync(Reactivate_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Change_Veteran_Status_IdentificationOutput Change_Veteran_Status_Identification(Change_Veteran_Status_IdentificationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Change_Veteran_Status_IdentificationOutput> Change_Veteran_Status_IdentificationAsync(Change_Veteran_Status_IdentificationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assign_Members_to_Custom_OrganizationOutput Assign_Members_to_Custom_Organization(Assign_Members_to_Custom_OrganizationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assign_Members_to_Custom_OrganizationOutput> Assign_Members_to_Custom_OrganizationAsync(Assign_Members_to_Custom_OrganizationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Work_Status_Rule_SetOutput Put_Work_Status_Rule_Set(Put_Work_Status_Rule_SetInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Work_Status_Rule_SetOutput> Put_Work_Status_Rule_SetAsync(Put_Work_Status_Rule_SetInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Work_Status_Rule_SetsOutput Get_Work_Status_Rule_Sets(Get_Work_Status_Rule_SetsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Work_Status_Rule_SetsOutput> Get_Work_Status_Rule_SetsAsync(Get_Work_Status_Rule_SetsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Period_Reporting_CalendarOutput Put_Period_Reporting_Calendar(Put_Period_Reporting_CalendarInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Period_Reporting_CalendarOutput> Put_Period_Reporting_CalendarAsync(Put_Period_Reporting_CalendarInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Period_Reporting_CalendarsOutput Get_Period_Reporting_Calendars(Get_Period_Reporting_CalendarsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Period_Reporting_CalendarsOutput> Get_Period_Reporting_CalendarsAsync(Get_Period_Reporting_CalendarsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Location_AttributeOutput Put_Location_Attribute(Put_Location_AttributeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Location_AttributeOutput> Put_Location_AttributeAsync(Put_Location_AttributeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Location_AttributesOutput Get_Location_Attributes(Get_Location_AttributesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Location_AttributesOutput> Get_Location_AttributesAsync(Get_Location_AttributesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Disability_Self_Identification_RecordOutput Put_External_Disability_Self_Identification_Record(Put_External_Disability_Self_Identification_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Disability_Self_Identification_RecordOutput> Put_External_Disability_Self_Identification_RecordAsync(Put_External_Disability_Self_Identification_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_External_Disability_Self_Identification_RecordsOutput Get_External_Disability_Self_Identification_Records(Get_External_Disability_Self_Identification_RecordsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_External_Disability_Self_Identification_RecordsOutput> Get_External_Disability_Self_Identification_RecordsAsync(Get_External_Disability_Self_Identification_RecordsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Gender_IdentitiesOutput Get_Gender_Identities(Get_Gender_IdentitiesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Gender_IdentitiesOutput> Get_Gender_IdentitiesAsync(Get_Gender_IdentitiesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Gender_IdentityOutput Put_Gender_Identity(Put_Gender_IdentityInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Gender_IdentityOutput> Put_Gender_IdentityAsync(Put_Gender_IdentityInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Sexual_OrientationsOutput Get_Sexual_Orientations(Get_Sexual_OrientationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Sexual_OrientationsOutput> Get_Sexual_OrientationsAsync(Get_Sexual_OrientationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Sexual_OrientationOutput Put_Sexual_Orientation(Put_Sexual_OrientationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Sexual_OrientationOutput> Put_Sexual_OrientationAsync(Put_Sexual_OrientationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PronounsOutput Get_Pronouns(Get_PronounsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PronounsOutput> Get_PronounsAsync(Get_PronounsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_PronounOutput Put_Pronoun(Put_PronounInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_PronounOutput> Put_PronounAsync(Put_PronounInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_Reference_Letter_for_WorkerOutput Create_Reference_Letter_for_Worker(Create_Reference_Letter_for_WorkerInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_Reference_Letter_for_WorkerOutput> Create_Reference_Letter_for_WorkerAsync(Create_Reference_Letter_for_WorkerInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Universal_IdentifierOutput Get_Universal_Identifier(Get_Universal_IdentifierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Universal_IdentifierOutput> Get_Universal_IdentifierAsync(Get_Universal_IdentifierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Universal_IdentifierOutput Put_Universal_Identifier(Put_Universal_IdentifierInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Universal_IdentifierOutput> Put_Universal_IdentifierAsync(Put_Universal_IdentifierInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Universal_IdentifiersOutput Import_Universal_Identifiers(Import_Universal_IdentifiersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Universal_IdentifiersOutput> Import_Universal_IdentifiersAsync(Import_Universal_IdentifiersInput request);
	}
}
