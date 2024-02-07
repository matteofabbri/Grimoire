using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Student_Recruiting", ConfigurationName = "StudentRecruiting.Student_RecruitingPort")]
	public interface Student_RecruitingPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Recruiting_EventsOutput Get_Student_Recruiting_Events(Get_Student_Recruiting_EventsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Recruiting_EventsOutput> Get_Student_Recruiting_EventsAsync(Get_Student_Recruiting_EventsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_Recruiting_EventOutput Submit_Student_Recruiting_Event(Submit_Student_Recruiting_EventInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_Recruiting_EventOutput> Submit_Student_Recruiting_EventAsync(Submit_Student_Recruiting_EventInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Recruiting_CyclesOutput Get_Student_Recruiting_Cycles(Get_Student_Recruiting_CyclesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Recruiting_CyclesOutput> Get_Student_Recruiting_CyclesAsync(Get_Student_Recruiting_CyclesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Recruiting_CycleOutput Put_Student_Recruiting_Cycle(Put_Student_Recruiting_CycleInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Recruiting_CycleOutput> Put_Student_Recruiting_CycleAsync(Put_Student_Recruiting_CycleInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Recruiting_RegionsOutput Get_Recruiting_Regions(Get_Recruiting_RegionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Recruiting_RegionsOutput> Get_Recruiting_RegionsAsync(Get_Recruiting_RegionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Recruiting_RegionOutput Put_Recruiting_Region(Put_Recruiting_RegionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Recruiting_RegionOutput> Put_Recruiting_RegionAsync(Put_Recruiting_RegionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_RecruitersOutput Get_Student_Recruiters(Get_Student_RecruitersInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_RecruitersOutput> Get_Student_RecruitersAsync(Get_Student_RecruitersInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_RecruiterOutput Submit_Student_Recruiter(Submit_Student_RecruiterInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_RecruiterOutput> Submit_Student_RecruiterAsync(Submit_Student_RecruiterInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Recruiting_CampaignsOutput Get_Student_Recruiting_Campaigns(Get_Student_Recruiting_CampaignsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Recruiting_CampaignsOutput> Get_Student_Recruiting_CampaignsAsync(Get_Student_Recruiting_CampaignsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Student_Recruiting_CampaignOutput Submit_Student_Recruiting_Campaign(Submit_Student_Recruiting_CampaignInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Student_Recruiting_CampaignOutput> Submit_Student_Recruiting_CampaignAsync(Submit_Student_Recruiting_CampaignInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Ad_Hoc_LocationsOutput Get_Ad_Hoc_Locations(Get_Ad_Hoc_LocationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Ad_Hoc_LocationsOutput> Get_Ad_Hoc_LocationsAsync(Get_Ad_Hoc_LocationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Ad_Hoc_LocationOutput Put_Ad_Hoc_Location(Put_Ad_Hoc_LocationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Ad_Hoc_LocationOutput> Put_Ad_Hoc_LocationAsync(Put_Ad_Hoc_LocationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Search_Service_DefinitionsOutput Get_Search_Service_Definitions(Get_Search_Service_DefinitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Search_Service_DefinitionsOutput> Get_Search_Service_DefinitionsAsync(Get_Search_Service_DefinitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Search_Service_DefinitionOutput Put_Search_Service_Definition(Put_Search_Service_DefinitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Search_Service_DefinitionOutput> Put_Search_Service_DefinitionAsync(Put_Search_Service_DefinitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Recruiting_Event_Registration_RecordOutput Put_Student_Recruiting_Event_Registration_Record(Put_Student_Recruiting_Event_Registration_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Recruiting_Event_Registration_RecordOutput> Put_Student_Recruiting_Event_Registration_RecordAsync(Put_Student_Recruiting_Event_Registration_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Marketing_Activity_DefinitionsOutput Get_Marketing_Activity_Definitions(Get_Marketing_Activity_DefinitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Marketing_Activity_DefinitionsOutput> Get_Marketing_Activity_DefinitionsAsync(Get_Marketing_Activity_DefinitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Marketing_Activity_DefinitionOutput Put_Marketing_Activity_Definition(Put_Marketing_Activity_DefinitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Marketing_Activity_DefinitionOutput> Put_Marketing_Activity_DefinitionAsync(Put_Marketing_Activity_DefinitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_RecruitmentsOutput Get_Student_Recruitments(Get_Student_RecruitmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_RecruitmentsOutput> Get_Student_RecruitmentsAsync(Get_Student_RecruitmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_RecruitmentOutput Put_Student_Recruitment(Put_Student_RecruitmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_RecruitmentOutput> Put_Student_RecruitmentAsync(Put_Student_RecruitmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Recruiting_Event_Registration_RecordsOutput Get_Student_Recruiting_Event_Registration_Records(Get_Student_Recruiting_Event_Registration_RecordsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Recruiting_Event_Registration_RecordsOutput> Get_Student_Recruiting_Event_Registration_RecordsAsync(Get_Student_Recruiting_Event_Registration_RecordsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Unregister_Student_Recruiting_Registration_RecordOutput Put_Unregister_Student_Recruiting_Registration_Record(Put_Unregister_Student_Recruiting_Registration_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Unregister_Student_Recruiting_Registration_RecordOutput> Put_Unregister_Student_Recruiting_Registration_RecordAsync(Put_Unregister_Student_Recruiting_Registration_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Recruiting_Event_Attendance_RecordOutput Put_Student_Recruiting_Event_Attendance_Record(Put_Student_Recruiting_Event_Attendance_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Recruiting_Event_Attendance_RecordOutput> Put_Student_Recruiting_Event_Attendance_RecordAsync(Put_Student_Recruiting_Event_Attendance_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput Put_Remove_Student_Recruiting_Event_Attendance_Record(Put_Remove_Student_Recruiting_Event_Attendance_RecordInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Remove_Student_Recruiting_Event_Attendance_RecordOutput> Put_Remove_Student_Recruiting_Event_Attendance_RecordAsync(Put_Remove_Student_Recruiting_Event_Attendance_RecordInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_Student_RecruitmentsOutput Import_Student_Recruitments(Import_Student_RecruitmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_Student_RecruitmentsOutput> Import_Student_RecruitmentsAsync(Import_Student_RecruitmentsInput request);
	}
}
