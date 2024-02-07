using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Admissions", ConfigurationName = "AdmissionsService.AdmissionsPort")]
	public interface AdmissionsPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Application_Admission_ResponseOutput Put_Student_Application_Admission_Response(Put_Student_Application_Admission_ResponseInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Application_Admission_ResponseOutput> Put_Student_Application_Admission_ResponseAsync(Put_Student_Application_Admission_ResponseInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Application_Admission_ResponsesOutput Get_Student_Application_Admission_Responses(Get_Student_Application_Admission_ResponsesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Application_Admission_ResponsesOutput> Get_Student_Application_Admission_ResponsesAsync(Get_Student_Application_Admission_ResponsesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Application_Requirement_AssignmentOutput Put_Student_Application_Requirement_Assignment(Put_Student_Application_Requirement_AssignmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Application_Requirement_AssignmentOutput> Put_Student_Application_Requirement_AssignmentAsync(Put_Student_Application_Requirement_AssignmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Application_Requirement_AssignmentsOutput Get_Student_Application_Requirement_Assignments(Get_Student_Application_Requirement_AssignmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Application_Requirement_AssignmentsOutput> Get_Student_Application_Requirement_AssignmentsAsync(Get_Student_Application_Requirement_AssignmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_External_Student_TranscriptOutput Put_External_Student_Transcript(Put_External_Student_TranscriptInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_External_Student_TranscriptOutput> Put_External_Student_TranscriptAsync(Put_External_Student_TranscriptInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_External_Student_TranscriptsOutput Get_External_Student_Transcripts(Get_External_Student_TranscriptsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_External_Student_TranscriptsOutput> Get_External_Student_TranscriptsAsync(Get_External_Student_TranscriptsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_ApplicationsOutput Get_Student_Applications(Get_Student_ApplicationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_ApplicationsOutput> Get_Student_ApplicationsAsync(Get_Student_ApplicationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_ApplicationOutput Put_Student_Application(Put_Student_ApplicationInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_ApplicationOutput> Put_Student_ApplicationAsync(Put_Student_ApplicationInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Student_Application_ResidencyOutput Put_Student_Application_Residency(Put_Student_Application_ResidencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Student_Application_ResidencyOutput> Put_Student_Application_ResidencyAsync(Put_Student_Application_ResidencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Student_Application_ResidencyOutput Get_Student_Application_Residency(Get_Student_Application_ResidencyInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Student_Application_ResidencyOutput> Get_Student_Application_ResidencyAsync(Get_Student_Application_ResidencyInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_External_Student_TranscriptsOutput Import_External_Student_Transcripts(Import_External_Student_TranscriptsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_External_Student_TranscriptsOutput> Import_External_Student_TranscriptsAsync(Import_External_Student_TranscriptsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_External_Student_TranscriptsOutput Import_Student_Applications(Import_Student_ApplicationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_External_Student_TranscriptsOutput> Import_Student_ApplicationsAsync(Import_Student_ApplicationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Import_External_Student_TranscriptsOutput Import_Student_Application_Admission_Decision(Import_Student_Application_Admission_DecisionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Import_External_Student_TranscriptsOutput> Import_Student_Application_Admission_DecisionAsync(Import_Student_Application_Admission_DecisionInput request);
	}
}
