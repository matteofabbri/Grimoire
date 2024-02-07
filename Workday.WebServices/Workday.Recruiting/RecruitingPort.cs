using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace = "urn:com.workday/bsvc/Recruiting", ConfigurationName = "Recruiting.RecruitingPort")]
	public interface RecruitingPort
	{
		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Server_TimestampOutput Get_Server_Timestamp(Get_Server_TimestampInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Server_TimestampOutput> Get_Server_TimestampAsync(Get_Server_TimestampInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_ApplicantsOutput Get_Applicants(Get_ApplicantsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_ApplicantsOutput> Get_ApplicantsAsync(Get_ApplicantsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_ApplicantOutput Put_Applicant(Put_ApplicantInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_ApplicantOutput> Put_ApplicantAsync(Put_ApplicantInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_PositionOutput Create_Position(Create_PositionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_PositionOutput> Create_PositionAsync(Create_PositionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_PositionsOutput Get_Positions(Get_PositionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_PositionsOutput> Get_PositionsAsync(Get_PositionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_OrganizationsOutput Get_Organizations(Get_OrganizationsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Get_OrganizationsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Position_RestrictionsOutput Edit_Position_Restrictions(Edit_Position_RestrictionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Position_RestrictionsOutput> Edit_Position_RestrictionsAsync(Edit_Position_RestrictionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_Job_RequisitionOutput Create_Job_Requisition(Create_Job_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_Job_RequisitionOutput> Create_Job_RequisitionAsync(Create_Job_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Job_RequisitionOutput Edit_Job_Requisition(Edit_Job_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Job_RequisitionOutput> Edit_Job_RequisitionAsync(Edit_Job_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_RequisitionsOutput Get_Job_Requisitions(Get_Job_RequisitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_RequisitionsOutput> Get_Job_RequisitionsAsync(Get_Job_RequisitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_CandidateOutput Put_Candidate(Put_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_CandidateOutput> Put_CandidateAsync(Put_CandidateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_CandidatesOutput Get_Candidates(Get_CandidatesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_CandidatesOutput> Get_CandidatesAsync(Get_CandidatesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Unpost_JobOutput Unpost_Job(Unpost_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Unpost_JobOutput> Unpost_JobAsync(Unpost_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Post_JobOutput Post_Job(Post_JobInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Post_JobOutput> Post_JobAsync(Post_JobInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Update_Job_PostingOutput Update_Job_Posting(Update_Job_PostingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Update_Job_PostingOutput> Update_Job_PostingAsync(Update_Job_PostingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Close_Job_RequisitionOutput Close_Job_Requisition(Close_Job_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Close_Job_RequisitionOutput> Close_Job_RequisitionAsync(Close_Job_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Candidate_AttachmentOutput Put_Candidate_Attachment(Put_Candidate_AttachmentInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Candidate_AttachmentOutput> Put_Candidate_AttachmentAsync(Put_Candidate_AttachmentInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Candidate_AttachmentsOutput Get_Candidate_Attachments(Get_Candidate_AttachmentsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Candidate_AttachmentsOutput> Get_Candidate_AttachmentsAsync(Get_Candidate_AttachmentsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Posting_SitesOutput Get_Job_Posting_Sites(Get_Job_Posting_SitesInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Posting_SitesOutput> Get_Job_Posting_SitesAsync(Get_Job_Posting_SitesInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Posting_SiteOutput Put_Job_Posting_Site(Put_Job_Posting_SiteInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Posting_SiteOutput> Put_Job_Posting_SiteAsync(Put_Job_Posting_SiteInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Candidate_PhotoOutput Put_Candidate_Photo(Put_Candidate_PhotoInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Candidate_PhotoOutput> Put_Candidate_PhotoAsync(Put_Candidate_PhotoInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Candidate_PhotosOutput Get_Candidate_Photos(Get_Candidate_PhotosInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Candidate_PhotosOutput> Get_Candidate_PhotosAsync(Get_Candidate_PhotosInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Manage_Job_Requisition_FreezeOutput Manage_Job_Requisition_Freeze(Manage_Job_Requisition_FreezeInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Manage_Job_Requisition_FreezeOutput> Manage_Job_Requisition_FreezeAsync(Manage_Job_Requisition_FreezeInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Background_CheckOutput Put_Background_Check(Put_Background_CheckInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Background_CheckOutput> Put_Background_CheckAsync(Put_Background_CheckInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Background_CheckOutput Get_Background_Check(Get_Background_CheckInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Background_CheckOutput> Get_Background_CheckAsync(Get_Background_CheckInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_PostingsOutput Get_Job_Postings(Get_Job_PostingsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_PostingsOutput> Get_Job_PostingsAsync(Get_Job_PostingsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Assess_CandidateOutput Get_Assess_Candidate(Get_Assess_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Assess_CandidateOutput> Get_Assess_CandidateAsync(Get_Assess_CandidateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Assess_CandidateOutput Assess_Candidate(Assess_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Assess_CandidateOutput> Assess_CandidateAsync(Assess_CandidateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Create_Evergreen_RequisitionOutput Create_Evergreen_Requisition(Create_Evergreen_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Create_Evergreen_RequisitionOutput> Create_Evergreen_RequisitionAsync(Create_Evergreen_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Evergreen_RequisitionsOutput Get_Evergreen_Requisitions(Get_Evergreen_RequisitionsInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Evergreen_RequisitionsOutput> Get_Evergreen_RequisitionsAsync(Get_Evergreen_RequisitionsInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Evergreen_RequisitionOutput Edit_Evergreen_Requisition(Edit_Evergreen_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Evergreen_RequisitionOutput> Edit_Evergreen_RequisitionAsync(Edit_Evergreen_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Close_Evergreen_RequisitionOutput Close_Evergreen_Requisition(Close_Evergreen_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Close_Evergreen_RequisitionOutput> Close_Evergreen_RequisitionAsync(Close_Evergreen_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Move_Job_RequisitionOutput Move_Job_Requisition(Move_Job_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Move_Job_RequisitionOutput> Move_Job_RequisitionAsync(Move_Job_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Position_Restrictions_Additional_DataOutput Edit_Position_Restrictions_Additional_Data(Edit_Position_Restrictions_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Position_Restrictions_Additional_DataOutput> Edit_Position_Restrictions_Additional_DataAsync(Edit_Position_Restrictions_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Edit_Job_Requisition_Additional_DataOutput Edit_Job_Requisition_Additional_Data(Edit_Job_Requisition_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Edit_Job_Requisition_Additional_DataOutput> Edit_Job_Requisition_Additional_DataAsync(Edit_Job_Requisition_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Move_Candidate_to_Linked_Job_RequisitionOutput Move_Candidate_to_Linked_Job_Requisition(Move_Candidate_to_Linked_Job_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Move_Candidate_to_Linked_Job_RequisitionOutput> Move_Candidate_to_Linked_Job_RequisitionAsync(Move_Candidate_to_Linked_Job_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Primary_PostingOutput Put_Primary_Posting(Put_Primary_PostingInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Primary_PostingOutput> Put_Primary_PostingAsync(Put_Primary_PostingInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Move_Candidate_to_Linked_Evergreen_RequisitionOutput Move_Candidate_to_Linked_Evergreen_Requisition(Move_Candidate_to_Linked_Evergreen_RequisitionInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Move_Candidate_to_Linked_Evergreen_RequisitionOutput> Move_Candidate_to_Linked_Evergreen_RequisitionAsync(Move_Candidate_to_Linked_Evergreen_RequisitionInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Job_Application_Additional_DataOutput Get_Job_Application_Additional_Data(Get_Job_Application_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Job_Application_Additional_DataOutput> Get_Job_Application_Additional_DataAsync(Get_Job_Application_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Job_Application_Additional_DataOutput Put_Job_Application_Additional_Data(Put_Job_Application_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Job_Application_Additional_DataOutput> Put_Job_Application_Additional_DataAsync(Put_Job_Application_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Submit_Recruiting_Agency_CandidateOutput Submit_Recruiting_Agency_Candidate(Submit_Recruiting_Agency_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Submit_Recruiting_Agency_CandidateOutput> Submit_Recruiting_Agency_CandidateAsync(Submit_Recruiting_Agency_CandidateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Move_CandidateOutput Move_Candidate(Move_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Move_CandidateOutput> Move_CandidateAsync(Move_CandidateInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Get_Recruiting_Agency_Additional_DataOutput Get_Recruiting_Agency_Additional_Data(Get_Recruiting_Agency_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Get_Recruiting_Agency_Additional_DataOutput> Get_Recruiting_Agency_Additional_DataAsync(Get_Recruiting_Agency_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Put_Recruiting_Agency_Additional_DataOutput Put_Recruiting_Agency_Additional_Data(Put_Recruiting_Agency_Additional_DataInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Put_Recruiting_Agency_Additional_DataOutput> Put_Recruiting_Agency_Additional_DataAsync(Put_Recruiting_Agency_Additional_DataInput request);

		[FaultContract(typeof(Validation_ErrorType[]), Action = "", Name = "Validation_Fault", Namespace = "urn:com.workday/bsvc"), FaultContract(typeof(Processing_FaultType), Action = "", Name = "Processing_Fault", Namespace = "urn:com.workday/bsvc"), OperationContract(Action = "", ReplyAction = "*"), XmlSerializerFormat(SupportFaults = true)]
		Refer_a_CandidateOutput Refer_a_Candidate(Refer_a_CandidateInput request);

		[OperationContract(Action = "", ReplyAction = "*")]
		Task<Refer_a_CandidateOutput> Refer_a_CandidateAsync(Refer_a_CandidateInput request);
	}
}
