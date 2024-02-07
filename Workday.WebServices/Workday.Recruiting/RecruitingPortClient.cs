using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class RecruitingPortClient : ClientBase<RecruitingPort>, RecruitingPort
	{
		public RecruitingPortClient()
		{
		}

		public RecruitingPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public RecruitingPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public RecruitingPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public RecruitingPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Server_TimestampOutput RecruitingPort.Get_Server_Timestamp(Get_Server_TimestampInput request)
		{
			return base.Channel.Get_Server_Timestamp(request);
		}

		public Server_TimestampType Get_Server_Timestamp(Workday_Common_HeaderType Workday_Common_Header, Server_Timestamp_GetType Server_Timestamp_Get)
		{
			return ((RecruitingPort)this).Get_Server_Timestamp(new Get_Server_TimestampInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Server_Timestamp_Get = Server_Timestamp_Get
			}).Server_Timestamp;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Server_TimestampOutput> RecruitingPort.Get_Server_TimestampAsync(Get_Server_TimestampInput request)
		{
			return base.Channel.Get_Server_TimestampAsync(request);
		}

		public Task<Get_Server_TimestampOutput> Get_Server_TimestampAsync(Workday_Common_HeaderType Workday_Common_Header, Server_Timestamp_GetType Server_Timestamp_Get)
		{
			return ((RecruitingPort)this).Get_Server_TimestampAsync(new Get_Server_TimestampInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Server_Timestamp_Get = Server_Timestamp_Get
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_ApplicantsOutput RecruitingPort.Get_Applicants(Get_ApplicantsInput request)
		{
			return base.Channel.Get_Applicants(request);
		}

		public Get_Applicants_ResponseType Get_Applicants(Workday_Common_HeaderType Workday_Common_Header, Get_Applicants_RequestType Get_Applicants_Request)
		{
			return ((RecruitingPort)this).Get_Applicants(new Get_ApplicantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Applicants_Request = Get_Applicants_Request
			}).Get_Applicants_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_ApplicantsOutput> RecruitingPort.Get_ApplicantsAsync(Get_ApplicantsInput request)
		{
			return base.Channel.Get_ApplicantsAsync(request);
		}

		public Task<Get_ApplicantsOutput> Get_ApplicantsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Applicants_RequestType Get_Applicants_Request)
		{
			return ((RecruitingPort)this).Get_ApplicantsAsync(new Get_ApplicantsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Applicants_Request = Get_Applicants_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_ApplicantOutput RecruitingPort.Put_Applicant(Put_ApplicantInput request)
		{
			return base.Channel.Put_Applicant(request);
		}

		public Put_Applicant_ResponseType Put_Applicant(Workday_Common_HeaderType Workday_Common_Header, Put_Applicant_RequestType Put_Applicant_Request)
		{
			return ((RecruitingPort)this).Put_Applicant(new Put_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Applicant_Request = Put_Applicant_Request
			}).Put_Applicant_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_ApplicantOutput> RecruitingPort.Put_ApplicantAsync(Put_ApplicantInput request)
		{
			return base.Channel.Put_ApplicantAsync(request);
		}

		public Task<Put_ApplicantOutput> Put_ApplicantAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Applicant_RequestType Put_Applicant_Request)
		{
			return ((RecruitingPort)this).Put_ApplicantAsync(new Put_ApplicantInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Applicant_Request = Put_Applicant_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_PositionOutput RecruitingPort.Create_Position(Create_PositionInput request)
		{
			return base.Channel.Create_Position(request);
		}

		public Create_Position_ResponseType Create_Position(Workday_Common_HeaderType Workday_Common_Header, Create_Position_RequestType Create_Position_Request)
		{
			return ((RecruitingPort)this).Create_Position(new Create_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Position_Request = Create_Position_Request
			}).Create_Position_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_PositionOutput> RecruitingPort.Create_PositionAsync(Create_PositionInput request)
		{
			return base.Channel.Create_PositionAsync(request);
		}

		public Task<Create_PositionOutput> Create_PositionAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Position_RequestType Create_Position_Request)
		{
			return ((RecruitingPort)this).Create_PositionAsync(new Create_PositionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Position_Request = Create_Position_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_PositionsOutput RecruitingPort.Get_Positions(Get_PositionsInput request)
		{
			return base.Channel.Get_Positions(request);
		}

		public Get_Positions_ResponseType Get_Positions(Workday_Common_HeaderType Workday_Common_Header, Get_Positions_RequestType Get_Positions_Request)
		{
			return ((RecruitingPort)this).Get_Positions(new Get_PositionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Positions_Request = Get_Positions_Request
			}).Get_Positions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_PositionsOutput> RecruitingPort.Get_PositionsAsync(Get_PositionsInput request)
		{
			return base.Channel.Get_PositionsAsync(request);
		}

		public Task<Get_PositionsOutput> Get_PositionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Positions_RequestType Get_Positions_Request)
		{
			return ((RecruitingPort)this).Get_PositionsAsync(new Get_PositionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Positions_Request = Get_Positions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_OrganizationsOutput RecruitingPort.Get_Organizations(Get_OrganizationsInput request)
		{
			return base.Channel.Get_Organizations(request);
		}

		public Get_Organizations_ResponseType Get_Organizations(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((RecruitingPort)this).Get_Organizations(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			}).Get_Organizations_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_OrganizationsOutput> RecruitingPort.Get_OrganizationsAsync(Get_OrganizationsInput request)
		{
			return base.Channel.Get_OrganizationsAsync(request);
		}

		public Task<Get_OrganizationsOutput> Get_OrganizationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Organizations_RequestType Get_Organizations_Request)
		{
			return ((RecruitingPort)this).Get_OrganizationsAsync(new Get_OrganizationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Organizations_Request = Get_Organizations_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Position_RestrictionsOutput RecruitingPort.Edit_Position_Restrictions(Edit_Position_RestrictionsInput request)
		{
			return base.Channel.Edit_Position_Restrictions(request);
		}

		public Edit_Positon_Restriction_ResponseType Edit_Position_Restrictions(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_RequestType Edit_Position_Restrictions_Request)
		{
			return ((RecruitingPort)this).Edit_Position_Restrictions(new Edit_Position_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Request = Edit_Position_Restrictions_Request
			}).Edit_Positon_Restriction_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Position_RestrictionsOutput> RecruitingPort.Edit_Position_RestrictionsAsync(Edit_Position_RestrictionsInput request)
		{
			return base.Channel.Edit_Position_RestrictionsAsync(request);
		}

		public Task<Edit_Position_RestrictionsOutput> Edit_Position_RestrictionsAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_RequestType Edit_Position_Restrictions_Request)
		{
			return ((RecruitingPort)this).Edit_Position_RestrictionsAsync(new Edit_Position_RestrictionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Request = Edit_Position_Restrictions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_Job_RequisitionOutput RecruitingPort.Create_Job_Requisition(Create_Job_RequisitionInput request)
		{
			return base.Channel.Create_Job_Requisition(request);
		}

		public Create_Job_Requisition_ResponseType Create_Job_Requisition(Workday_Common_HeaderType Workday_Common_Header, Create_Requisition_RequestType Create_Requisition_Request)
		{
			return ((RecruitingPort)this).Create_Job_Requisition(new Create_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Requisition_Request = Create_Requisition_Request
			}).Create_Job_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_Job_RequisitionOutput> RecruitingPort.Create_Job_RequisitionAsync(Create_Job_RequisitionInput request)
		{
			return base.Channel.Create_Job_RequisitionAsync(request);
		}

		public Task<Create_Job_RequisitionOutput> Create_Job_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Requisition_RequestType Create_Requisition_Request)
		{
			return ((RecruitingPort)this).Create_Job_RequisitionAsync(new Create_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Requisition_Request = Create_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Job_RequisitionOutput RecruitingPort.Edit_Job_Requisition(Edit_Job_RequisitionInput request)
		{
			return base.Channel.Edit_Job_Requisition(request);
		}

		public Edit_Job_Requisition_ResponseType Edit_Job_Requisition(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Requisition_RequestType Edit_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Edit_Job_Requisition(new Edit_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Requisition_Request = Edit_Job_Requisition_Request
			}).Edit_Job_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Job_RequisitionOutput> RecruitingPort.Edit_Job_RequisitionAsync(Edit_Job_RequisitionInput request)
		{
			return base.Channel.Edit_Job_RequisitionAsync(request);
		}

		public Task<Edit_Job_RequisitionOutput> Edit_Job_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Requisition_RequestType Edit_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Edit_Job_RequisitionAsync(new Edit_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Requisition_Request = Edit_Job_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_RequisitionsOutput RecruitingPort.Get_Job_Requisitions(Get_Job_RequisitionsInput request)
		{
			return base.Channel.Get_Job_Requisitions(request);
		}

		public Get_Job_Requisitions_ResponseType Get_Job_Requisitions(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Requisitions_RequestType Get_Job_Requisitions_Request)
		{
			return ((RecruitingPort)this).Get_Job_Requisitions(new Get_Job_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Requisitions_Request = Get_Job_Requisitions_Request
			}).Get_Job_Requisitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_RequisitionsOutput> RecruitingPort.Get_Job_RequisitionsAsync(Get_Job_RequisitionsInput request)
		{
			return base.Channel.Get_Job_RequisitionsAsync(request);
		}

		public Task<Get_Job_RequisitionsOutput> Get_Job_RequisitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Requisitions_RequestType Get_Job_Requisitions_Request)
		{
			return ((RecruitingPort)this).Get_Job_RequisitionsAsync(new Get_Job_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Requisitions_Request = Get_Job_Requisitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_CandidateOutput RecruitingPort.Put_Candidate(Put_CandidateInput request)
		{
			return base.Channel.Put_Candidate(request);
		}

		public Put_Candidate_ResponseType Put_Candidate(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_RequestType Put_Candidate_Request)
		{
			return ((RecruitingPort)this).Put_Candidate(new Put_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Request = Put_Candidate_Request
			}).Put_Candidate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_CandidateOutput> RecruitingPort.Put_CandidateAsync(Put_CandidateInput request)
		{
			return base.Channel.Put_CandidateAsync(request);
		}

		public Task<Put_CandidateOutput> Put_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_RequestType Put_Candidate_Request)
		{
			return ((RecruitingPort)this).Put_CandidateAsync(new Put_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Request = Put_Candidate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_CandidatesOutput RecruitingPort.Get_Candidates(Get_CandidatesInput request)
		{
			return base.Channel.Get_Candidates(request);
		}

		public Get_Candidates_ResponseType Get_Candidates(Workday_Common_HeaderType Workday_Common_Header, Get_Candidates_RequestType Get_Candidates_Request)
		{
			return ((RecruitingPort)this).Get_Candidates(new Get_CandidatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidates_Request = Get_Candidates_Request
			}).Get_Candidates_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_CandidatesOutput> RecruitingPort.Get_CandidatesAsync(Get_CandidatesInput request)
		{
			return base.Channel.Get_CandidatesAsync(request);
		}

		public Task<Get_CandidatesOutput> Get_CandidatesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Candidates_RequestType Get_Candidates_Request)
		{
			return ((RecruitingPort)this).Get_CandidatesAsync(new Get_CandidatesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidates_Request = Get_Candidates_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Unpost_JobOutput RecruitingPort.Unpost_Job(Unpost_JobInput request)
		{
			return base.Channel.Unpost_Job(request);
		}

		public Unpost_Job_ResponseType Unpost_Job(Workday_Common_HeaderType Workday_Common_Header, Unpost_Job_RequestType Unpost_Job_Request)
		{
			return ((RecruitingPort)this).Unpost_Job(new Unpost_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Unpost_Job_Request = Unpost_Job_Request
			}).Unpost_Job_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Unpost_JobOutput> RecruitingPort.Unpost_JobAsync(Unpost_JobInput request)
		{
			return base.Channel.Unpost_JobAsync(request);
		}

		public Task<Unpost_JobOutput> Unpost_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Unpost_Job_RequestType Unpost_Job_Request)
		{
			return ((RecruitingPort)this).Unpost_JobAsync(new Unpost_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Unpost_Job_Request = Unpost_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Post_JobOutput RecruitingPort.Post_Job(Post_JobInput request)
		{
			return base.Channel.Post_Job(request);
		}

		public Post_Job_ResponseType Post_Job(Workday_Common_HeaderType Workday_Common_Header, Post_Job_RequestType Post_Job_Request)
		{
			return ((RecruitingPort)this).Post_Job(new Post_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Post_Job_Request = Post_Job_Request
			}).Post_Job_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Post_JobOutput> RecruitingPort.Post_JobAsync(Post_JobInput request)
		{
			return base.Channel.Post_JobAsync(request);
		}

		public Task<Post_JobOutput> Post_JobAsync(Workday_Common_HeaderType Workday_Common_Header, Post_Job_RequestType Post_Job_Request)
		{
			return ((RecruitingPort)this).Post_JobAsync(new Post_JobInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Post_Job_Request = Post_Job_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Update_Job_PostingOutput RecruitingPort.Update_Job_Posting(Update_Job_PostingInput request)
		{
			return base.Channel.Update_Job_Posting(request);
		}

		public Update_Job_Posting_ResponseType Update_Job_Posting(Workday_Common_HeaderType Workday_Common_Header, Update_Job_Posting_RequestType Update_Job_Posting_Request)
		{
			return ((RecruitingPort)this).Update_Job_Posting(new Update_Job_PostingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Job_Posting_Request = Update_Job_Posting_Request
			}).Update_Job_Posting_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Update_Job_PostingOutput> RecruitingPort.Update_Job_PostingAsync(Update_Job_PostingInput request)
		{
			return base.Channel.Update_Job_PostingAsync(request);
		}

		public Task<Update_Job_PostingOutput> Update_Job_PostingAsync(Workday_Common_HeaderType Workday_Common_Header, Update_Job_Posting_RequestType Update_Job_Posting_Request)
		{
			return ((RecruitingPort)this).Update_Job_PostingAsync(new Update_Job_PostingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Update_Job_Posting_Request = Update_Job_Posting_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Close_Job_RequisitionOutput RecruitingPort.Close_Job_Requisition(Close_Job_RequisitionInput request)
		{
			return base.Channel.Close_Job_Requisition(request);
		}

		public Close_Job_Requisition_ResponseType Close_Job_Requisition(Workday_Common_HeaderType Workday_Common_Header, Close_Job_Requisition_RequestType Close_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Close_Job_Requisition(new Close_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Job_Requisition_Request = Close_Job_Requisition_Request
			}).Close_Job_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Close_Job_RequisitionOutput> RecruitingPort.Close_Job_RequisitionAsync(Close_Job_RequisitionInput request)
		{
			return base.Channel.Close_Job_RequisitionAsync(request);
		}

		public Task<Close_Job_RequisitionOutput> Close_Job_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Close_Job_Requisition_RequestType Close_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Close_Job_RequisitionAsync(new Close_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Job_Requisition_Request = Close_Job_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Candidate_AttachmentOutput RecruitingPort.Put_Candidate_Attachment(Put_Candidate_AttachmentInput request)
		{
			return base.Channel.Put_Candidate_Attachment(request);
		}

		public Put_Candidate_Attachment_ResponseType Put_Candidate_Attachment(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_Attachment_RequestType Put_Candidate_Attachment_Request)
		{
			return ((RecruitingPort)this).Put_Candidate_Attachment(new Put_Candidate_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Attachment_Request = Put_Candidate_Attachment_Request
			}).Put_Candidate_Attachment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Candidate_AttachmentOutput> RecruitingPort.Put_Candidate_AttachmentAsync(Put_Candidate_AttachmentInput request)
		{
			return base.Channel.Put_Candidate_AttachmentAsync(request);
		}

		public Task<Put_Candidate_AttachmentOutput> Put_Candidate_AttachmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_Attachment_RequestType Put_Candidate_Attachment_Request)
		{
			return ((RecruitingPort)this).Put_Candidate_AttachmentAsync(new Put_Candidate_AttachmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Attachment_Request = Put_Candidate_Attachment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Candidate_AttachmentsOutput RecruitingPort.Get_Candidate_Attachments(Get_Candidate_AttachmentsInput request)
		{
			return base.Channel.Get_Candidate_Attachments(request);
		}

		public Get_Candidate_Attachments_ResponseType Get_Candidate_Attachments(Workday_Common_HeaderType Workday_Common_Header, Get_Candidate_Attachments_RequestType Get_Candidate_Attachments_Request)
		{
			return ((RecruitingPort)this).Get_Candidate_Attachments(new Get_Candidate_AttachmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidate_Attachments_Request = Get_Candidate_Attachments_Request
			}).Get_Candidate_Attachments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Candidate_AttachmentsOutput> RecruitingPort.Get_Candidate_AttachmentsAsync(Get_Candidate_AttachmentsInput request)
		{
			return base.Channel.Get_Candidate_AttachmentsAsync(request);
		}

		public Task<Get_Candidate_AttachmentsOutput> Get_Candidate_AttachmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Candidate_Attachments_RequestType Get_Candidate_Attachments_Request)
		{
			return ((RecruitingPort)this).Get_Candidate_AttachmentsAsync(new Get_Candidate_AttachmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidate_Attachments_Request = Get_Candidate_Attachments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Posting_SitesOutput RecruitingPort.Get_Job_Posting_Sites(Get_Job_Posting_SitesInput request)
		{
			return base.Channel.Get_Job_Posting_Sites(request);
		}

		public Get_Job_Posting_Sites_ResponseType Get_Job_Posting_Sites(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Posting_Sites_RequestType Get_Job_Posting_Sites_Request)
		{
			return ((RecruitingPort)this).Get_Job_Posting_Sites(new Get_Job_Posting_SitesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Posting_Sites_Request = Get_Job_Posting_Sites_Request
			}).Get_Job_Posting_Sites_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Posting_SitesOutput> RecruitingPort.Get_Job_Posting_SitesAsync(Get_Job_Posting_SitesInput request)
		{
			return base.Channel.Get_Job_Posting_SitesAsync(request);
		}

		public Task<Get_Job_Posting_SitesOutput> Get_Job_Posting_SitesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Posting_Sites_RequestType Get_Job_Posting_Sites_Request)
		{
			return ((RecruitingPort)this).Get_Job_Posting_SitesAsync(new Get_Job_Posting_SitesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Posting_Sites_Request = Get_Job_Posting_Sites_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Posting_SiteOutput RecruitingPort.Put_Job_Posting_Site(Put_Job_Posting_SiteInput request)
		{
			return base.Channel.Put_Job_Posting_Site(request);
		}

		public Put_Job_Posting_Site_ResponseType Put_Job_Posting_Site(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Posting_Site_RequestType Put_Job_Posting_Site_Request)
		{
			return ((RecruitingPort)this).Put_Job_Posting_Site(new Put_Job_Posting_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Posting_Site_Request = Put_Job_Posting_Site_Request
			}).Put_Job_Posting_Site_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Posting_SiteOutput> RecruitingPort.Put_Job_Posting_SiteAsync(Put_Job_Posting_SiteInput request)
		{
			return base.Channel.Put_Job_Posting_SiteAsync(request);
		}

		public Task<Put_Job_Posting_SiteOutput> Put_Job_Posting_SiteAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Posting_Site_RequestType Put_Job_Posting_Site_Request)
		{
			return ((RecruitingPort)this).Put_Job_Posting_SiteAsync(new Put_Job_Posting_SiteInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Posting_Site_Request = Put_Job_Posting_Site_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Candidate_PhotoOutput RecruitingPort.Put_Candidate_Photo(Put_Candidate_PhotoInput request)
		{
			return base.Channel.Put_Candidate_Photo(request);
		}

		public Put_Candidate_Photos_ResponseType Put_Candidate_Photo(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_Photo_RequestType Put_Candidate_Photo_Request)
		{
			return ((RecruitingPort)this).Put_Candidate_Photo(new Put_Candidate_PhotoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Photo_Request = Put_Candidate_Photo_Request
			}).Put_Candidate_Photos_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Candidate_PhotoOutput> RecruitingPort.Put_Candidate_PhotoAsync(Put_Candidate_PhotoInput request)
		{
			return base.Channel.Put_Candidate_PhotoAsync(request);
		}

		public Task<Put_Candidate_PhotoOutput> Put_Candidate_PhotoAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_Photo_RequestType Put_Candidate_Photo_Request)
		{
			return ((RecruitingPort)this).Put_Candidate_PhotoAsync(new Put_Candidate_PhotoInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Candidate_Photo_Request = Put_Candidate_Photo_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Candidate_PhotosOutput RecruitingPort.Get_Candidate_Photos(Get_Candidate_PhotosInput request)
		{
			return base.Channel.Get_Candidate_Photos(request);
		}

		public Get_Candidate_Photos_ResponseType Get_Candidate_Photos(Workday_Common_HeaderType Workday_Common_Header, Get_Candidate_Photos_RequestType Get_Candidate_Photos_Request)
		{
			return ((RecruitingPort)this).Get_Candidate_Photos(new Get_Candidate_PhotosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidate_Photos_Request = Get_Candidate_Photos_Request
			}).Get_Candidate_Photos_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Candidate_PhotosOutput> RecruitingPort.Get_Candidate_PhotosAsync(Get_Candidate_PhotosInput request)
		{
			return base.Channel.Get_Candidate_PhotosAsync(request);
		}

		public Task<Get_Candidate_PhotosOutput> Get_Candidate_PhotosAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Candidate_Photos_RequestType Get_Candidate_Photos_Request)
		{
			return ((RecruitingPort)this).Get_Candidate_PhotosAsync(new Get_Candidate_PhotosInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Candidate_Photos_Request = Get_Candidate_Photos_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Manage_Job_Requisition_FreezeOutput RecruitingPort.Manage_Job_Requisition_Freeze(Manage_Job_Requisition_FreezeInput request)
		{
			return base.Channel.Manage_Job_Requisition_Freeze(request);
		}

		public Manage_Job_Requisition_Freeze_ResponseType Manage_Job_Requisition_Freeze(Workday_Common_HeaderType Workday_Common_Header, Manage_Job_Requisition_Freeze_RequestType Manage_Job_Requisition_Freeze_Request)
		{
			return ((RecruitingPort)this).Manage_Job_Requisition_Freeze(new Manage_Job_Requisition_FreezeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Job_Requisition_Freeze_Request = Manage_Job_Requisition_Freeze_Request
			}).Manage_Job_Requisition_Freeze_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Manage_Job_Requisition_FreezeOutput> RecruitingPort.Manage_Job_Requisition_FreezeAsync(Manage_Job_Requisition_FreezeInput request)
		{
			return base.Channel.Manage_Job_Requisition_FreezeAsync(request);
		}

		public Task<Manage_Job_Requisition_FreezeOutput> Manage_Job_Requisition_FreezeAsync(Workday_Common_HeaderType Workday_Common_Header, Manage_Job_Requisition_Freeze_RequestType Manage_Job_Requisition_Freeze_Request)
		{
			return ((RecruitingPort)this).Manage_Job_Requisition_FreezeAsync(new Manage_Job_Requisition_FreezeInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Manage_Job_Requisition_Freeze_Request = Manage_Job_Requisition_Freeze_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Background_CheckOutput RecruitingPort.Put_Background_Check(Put_Background_CheckInput request)
		{
			return base.Channel.Put_Background_Check(request);
		}

		public Put_Background_Check_ResponseType Put_Background_Check(Workday_Common_HeaderType Workday_Common_Header, Put_Background_Check_RequestType Put_Background_Check_Request)
		{
			return ((RecruitingPort)this).Put_Background_Check(new Put_Background_CheckInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Background_Check_Request = Put_Background_Check_Request
			}).Put_Background_Check_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Background_CheckOutput> RecruitingPort.Put_Background_CheckAsync(Put_Background_CheckInput request)
		{
			return base.Channel.Put_Background_CheckAsync(request);
		}

		public Task<Put_Background_CheckOutput> Put_Background_CheckAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Background_Check_RequestType Put_Background_Check_Request)
		{
			return ((RecruitingPort)this).Put_Background_CheckAsync(new Put_Background_CheckInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Background_Check_Request = Put_Background_Check_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Background_CheckOutput RecruitingPort.Get_Background_Check(Get_Background_CheckInput request)
		{
			return base.Channel.Get_Background_Check(request);
		}

		public Get_Background_Check_ResponseType Get_Background_Check(Workday_Common_HeaderType Workday_Common_Header, Get_Background_Check_RequestType Get_Background_Check_Request)
		{
			return ((RecruitingPort)this).Get_Background_Check(new Get_Background_CheckInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Background_Check_Request = Get_Background_Check_Request
			}).Get_Background_Check_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Background_CheckOutput> RecruitingPort.Get_Background_CheckAsync(Get_Background_CheckInput request)
		{
			return base.Channel.Get_Background_CheckAsync(request);
		}

		public Task<Get_Background_CheckOutput> Get_Background_CheckAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Background_Check_RequestType Get_Background_Check_Request)
		{
			return ((RecruitingPort)this).Get_Background_CheckAsync(new Get_Background_CheckInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Background_Check_Request = Get_Background_Check_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_PostingsOutput RecruitingPort.Get_Job_Postings(Get_Job_PostingsInput request)
		{
			return base.Channel.Get_Job_Postings(request);
		}

		public Get_Job_Postings_ResponseType Get_Job_Postings(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Postings_RequestType Get_Job_Postings_Request)
		{
			return ((RecruitingPort)this).Get_Job_Postings(new Get_Job_PostingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Postings_Request = Get_Job_Postings_Request
			}).Get_Job_Postings_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_PostingsOutput> RecruitingPort.Get_Job_PostingsAsync(Get_Job_PostingsInput request)
		{
			return base.Channel.Get_Job_PostingsAsync(request);
		}

		public Task<Get_Job_PostingsOutput> Get_Job_PostingsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Postings_RequestType Get_Job_Postings_Request)
		{
			return ((RecruitingPort)this).Get_Job_PostingsAsync(new Get_Job_PostingsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Postings_Request = Get_Job_Postings_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Assess_CandidateOutput RecruitingPort.Get_Assess_Candidate(Get_Assess_CandidateInput request)
		{
			return base.Channel.Get_Assess_Candidate(request);
		}

		public Get_Assess_Candidate_ResponseType Get_Assess_Candidate(Workday_Common_HeaderType Workday_Common_Header, Get_Assess_Candidate_RequestType Get_Assess_Candidate_Request)
		{
			return ((RecruitingPort)this).Get_Assess_Candidate(new Get_Assess_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assess_Candidate_Request = Get_Assess_Candidate_Request
			}).Get_Assess_Candidate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Assess_CandidateOutput> RecruitingPort.Get_Assess_CandidateAsync(Get_Assess_CandidateInput request)
		{
			return base.Channel.Get_Assess_CandidateAsync(request);
		}

		public Task<Get_Assess_CandidateOutput> Get_Assess_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Assess_Candidate_RequestType Get_Assess_Candidate_Request)
		{
			return ((RecruitingPort)this).Get_Assess_CandidateAsync(new Get_Assess_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Assess_Candidate_Request = Get_Assess_Candidate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Assess_CandidateOutput RecruitingPort.Assess_Candidate(Assess_CandidateInput request)
		{
			return base.Channel.Assess_Candidate(request);
		}

		public Assess_Candidate_ResponseType Assess_Candidate(Workday_Common_HeaderType Workday_Common_Header, Assess_Candidate_RequestType Assess_Candidate_Request)
		{
			return ((RecruitingPort)this).Assess_Candidate(new Assess_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assess_Candidate_Request = Assess_Candidate_Request
			}).Assess_Candidate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Assess_CandidateOutput> RecruitingPort.Assess_CandidateAsync(Assess_CandidateInput request)
		{
			return base.Channel.Assess_CandidateAsync(request);
		}

		public Task<Assess_CandidateOutput> Assess_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Assess_Candidate_RequestType Assess_Candidate_Request)
		{
			return ((RecruitingPort)this).Assess_CandidateAsync(new Assess_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Assess_Candidate_Request = Assess_Candidate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Create_Evergreen_RequisitionOutput RecruitingPort.Create_Evergreen_Requisition(Create_Evergreen_RequisitionInput request)
		{
			return base.Channel.Create_Evergreen_Requisition(request);
		}

		public Create_Evergreen_Requisition_ResponseType Create_Evergreen_Requisition(Workday_Common_HeaderType Workday_Common_Header, Create_Evergreen_Requisition_RequestType Create_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Create_Evergreen_Requisition(new Create_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Evergreen_Requisition_Request = Create_Evergreen_Requisition_Request
			}).Create_Evergreen_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Create_Evergreen_RequisitionOutput> RecruitingPort.Create_Evergreen_RequisitionAsync(Create_Evergreen_RequisitionInput request)
		{
			return base.Channel.Create_Evergreen_RequisitionAsync(request);
		}

		public Task<Create_Evergreen_RequisitionOutput> Create_Evergreen_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Create_Evergreen_Requisition_RequestType Create_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Create_Evergreen_RequisitionAsync(new Create_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Create_Evergreen_Requisition_Request = Create_Evergreen_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Evergreen_RequisitionsOutput RecruitingPort.Get_Evergreen_Requisitions(Get_Evergreen_RequisitionsInput request)
		{
			return base.Channel.Get_Evergreen_Requisitions(request);
		}

		public Get_Evergreen_Requisitions_ResponseType Get_Evergreen_Requisitions(Workday_Common_HeaderType Workday_Common_Header, Get_Evergreen_Requisitions_RequestType Get_Evergreen_Requisitions_Request)
		{
			return ((RecruitingPort)this).Get_Evergreen_Requisitions(new Get_Evergreen_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Evergreen_Requisitions_Request = Get_Evergreen_Requisitions_Request
			}).Get_Evergreen_Requisitions_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Evergreen_RequisitionsOutput> RecruitingPort.Get_Evergreen_RequisitionsAsync(Get_Evergreen_RequisitionsInput request)
		{
			return base.Channel.Get_Evergreen_RequisitionsAsync(request);
		}

		public Task<Get_Evergreen_RequisitionsOutput> Get_Evergreen_RequisitionsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Evergreen_Requisitions_RequestType Get_Evergreen_Requisitions_Request)
		{
			return ((RecruitingPort)this).Get_Evergreen_RequisitionsAsync(new Get_Evergreen_RequisitionsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Evergreen_Requisitions_Request = Get_Evergreen_Requisitions_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Evergreen_RequisitionOutput RecruitingPort.Edit_Evergreen_Requisition(Edit_Evergreen_RequisitionInput request)
		{
			return base.Channel.Edit_Evergreen_Requisition(request);
		}

		public Edit_Evergreen_Requisition_ResponseType Edit_Evergreen_Requisition(Workday_Common_HeaderType Workday_Common_Header, Edit_Evergreen_Requisition_RequestType Edit_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Edit_Evergreen_Requisition(new Edit_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Evergreen_Requisition_Request = Edit_Evergreen_Requisition_Request
			}).Edit_Evergreen_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Evergreen_RequisitionOutput> RecruitingPort.Edit_Evergreen_RequisitionAsync(Edit_Evergreen_RequisitionInput request)
		{
			return base.Channel.Edit_Evergreen_RequisitionAsync(request);
		}

		public Task<Edit_Evergreen_RequisitionOutput> Edit_Evergreen_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Evergreen_Requisition_RequestType Edit_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Edit_Evergreen_RequisitionAsync(new Edit_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Evergreen_Requisition_Request = Edit_Evergreen_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Close_Evergreen_RequisitionOutput RecruitingPort.Close_Evergreen_Requisition(Close_Evergreen_RequisitionInput request)
		{
			return base.Channel.Close_Evergreen_Requisition(request);
		}

		public Close_Evergreen_Requisition_ResponseType Close_Evergreen_Requisition(Workday_Common_HeaderType Workday_Common_Header, Close_Evergreen_Requisition_RequestType Close_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Close_Evergreen_Requisition(new Close_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Evergreen_Requisition_Request = Close_Evergreen_Requisition_Request
			}).Close_Evergreen_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Close_Evergreen_RequisitionOutput> RecruitingPort.Close_Evergreen_RequisitionAsync(Close_Evergreen_RequisitionInput request)
		{
			return base.Channel.Close_Evergreen_RequisitionAsync(request);
		}

		public Task<Close_Evergreen_RequisitionOutput> Close_Evergreen_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Close_Evergreen_Requisition_RequestType Close_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Close_Evergreen_RequisitionAsync(new Close_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Close_Evergreen_Requisition_Request = Close_Evergreen_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Move_Job_RequisitionOutput RecruitingPort.Move_Job_Requisition(Move_Job_RequisitionInput request)
		{
			return base.Channel.Move_Job_Requisition(request);
		}

		public Move_Job_Requisition_ResponseType Move_Job_Requisition(Workday_Common_HeaderType Workday_Common_Header, Move_Job_Requisition_RequestType Move_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Job_Requisition(new Move_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Job_Requisition_Request = Move_Job_Requisition_Request
			}).Move_Job_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Move_Job_RequisitionOutput> RecruitingPort.Move_Job_RequisitionAsync(Move_Job_RequisitionInput request)
		{
			return base.Channel.Move_Job_RequisitionAsync(request);
		}

		public Task<Move_Job_RequisitionOutput> Move_Job_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Move_Job_Requisition_RequestType Move_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Job_RequisitionAsync(new Move_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Job_Requisition_Request = Move_Job_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Position_Restrictions_Additional_DataOutput RecruitingPort.Edit_Position_Restrictions_Additional_Data(Edit_Position_Restrictions_Additional_DataInput request)
		{
			return base.Channel.Edit_Position_Restrictions_Additional_Data(request);
		}

		public Edit_Position_Restrictions_Additional_Data_ResponseType Edit_Position_Restrictions_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_Additional_Data_RequestType Edit_Position_Restrictions_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Edit_Position_Restrictions_Additional_Data(new Edit_Position_Restrictions_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Additional_Data_Request = Edit_Position_Restrictions_Additional_Data_Request
			}).Edit_Position_Restrictions_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Position_Restrictions_Additional_DataOutput> RecruitingPort.Edit_Position_Restrictions_Additional_DataAsync(Edit_Position_Restrictions_Additional_DataInput request)
		{
			return base.Channel.Edit_Position_Restrictions_Additional_DataAsync(request);
		}

		public Task<Edit_Position_Restrictions_Additional_DataOutput> Edit_Position_Restrictions_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Position_Restrictions_Additional_Data_RequestType Edit_Position_Restrictions_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Edit_Position_Restrictions_Additional_DataAsync(new Edit_Position_Restrictions_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Position_Restrictions_Additional_Data_Request = Edit_Position_Restrictions_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Edit_Job_Requisition_Additional_DataOutput RecruitingPort.Edit_Job_Requisition_Additional_Data(Edit_Job_Requisition_Additional_DataInput request)
		{
			return base.Channel.Edit_Job_Requisition_Additional_Data(request);
		}

		public Edit_Job_Requisition_Additional_Data_ResponseType Edit_Job_Requisition_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Requisition_Additional_Data_RequestType Edit_Job_Requisition_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Edit_Job_Requisition_Additional_Data(new Edit_Job_Requisition_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Requisition_Additional_Data_Request = Edit_Job_Requisition_Additional_Data_Request
			}).Edit_Job_Requisition_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Edit_Job_Requisition_Additional_DataOutput> RecruitingPort.Edit_Job_Requisition_Additional_DataAsync(Edit_Job_Requisition_Additional_DataInput request)
		{
			return base.Channel.Edit_Job_Requisition_Additional_DataAsync(request);
		}

		public Task<Edit_Job_Requisition_Additional_DataOutput> Edit_Job_Requisition_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Edit_Job_Requisition_Additional_Data_RequestType Edit_Job_Requisition_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Edit_Job_Requisition_Additional_DataAsync(new Edit_Job_Requisition_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Edit_Job_Requisition_Additional_Data_Request = Edit_Job_Requisition_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Move_Candidate_to_Linked_Job_RequisitionOutput RecruitingPort.Move_Candidate_to_Linked_Job_Requisition(Move_Candidate_to_Linked_Job_RequisitionInput request)
		{
			return base.Channel.Move_Candidate_to_Linked_Job_Requisition(request);
		}

		public Move_Candidate_to_Linked_Job_Requisition_ResponseType Move_Candidate_to_Linked_Job_Requisition(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_to_Linked_Job_Requisition_RequestType Move_Candidate_to_Linked_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Candidate_to_Linked_Job_Requisition(new Move_Candidate_to_Linked_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_to_Linked_Job_Requisition_Request = Move_Candidate_to_Linked_Job_Requisition_Request
			}).Move_Candidate_to_Linked_Job_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Move_Candidate_to_Linked_Job_RequisitionOutput> RecruitingPort.Move_Candidate_to_Linked_Job_RequisitionAsync(Move_Candidate_to_Linked_Job_RequisitionInput request)
		{
			return base.Channel.Move_Candidate_to_Linked_Job_RequisitionAsync(request);
		}

		public Task<Move_Candidate_to_Linked_Job_RequisitionOutput> Move_Candidate_to_Linked_Job_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_to_Linked_Job_Requisition_RequestType Move_Candidate_to_Linked_Job_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Candidate_to_Linked_Job_RequisitionAsync(new Move_Candidate_to_Linked_Job_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_to_Linked_Job_Requisition_Request = Move_Candidate_to_Linked_Job_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Primary_PostingOutput RecruitingPort.Put_Primary_Posting(Put_Primary_PostingInput request)
		{
			return base.Channel.Put_Primary_Posting(request);
		}

		public Put_Primary_Posting_ResponseType Put_Primary_Posting(Workday_Common_HeaderType Workday_Common_Header, Put_Primary_Posting_RequestType Put_Primary_Posting_Request)
		{
			return ((RecruitingPort)this).Put_Primary_Posting(new Put_Primary_PostingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Primary_Posting_Request = Put_Primary_Posting_Request
			}).Put_Primary_Posting_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Primary_PostingOutput> RecruitingPort.Put_Primary_PostingAsync(Put_Primary_PostingInput request)
		{
			return base.Channel.Put_Primary_PostingAsync(request);
		}

		public Task<Put_Primary_PostingOutput> Put_Primary_PostingAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Primary_Posting_RequestType Put_Primary_Posting_Request)
		{
			return ((RecruitingPort)this).Put_Primary_PostingAsync(new Put_Primary_PostingInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Primary_Posting_Request = Put_Primary_Posting_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Move_Candidate_to_Linked_Evergreen_RequisitionOutput RecruitingPort.Move_Candidate_to_Linked_Evergreen_Requisition(Move_Candidate_to_Linked_Evergreen_RequisitionInput request)
		{
			return base.Channel.Move_Candidate_to_Linked_Evergreen_Requisition(request);
		}

		public Move_Candidate_to_Linked_Evergreen_Requisition_ResponseType Move_Candidate_to_Linked_Evergreen_Requisition(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_to_Linked_Evergreen_Requisition_RequestType Move_Candidate_to_Linked_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Candidate_to_Linked_Evergreen_Requisition(new Move_Candidate_to_Linked_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_to_Linked_Evergreen_Requisition_Request = Move_Candidate_to_Linked_Evergreen_Requisition_Request
			}).Move_Candidate_to_Linked_Evergreen_Requisition_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Move_Candidate_to_Linked_Evergreen_RequisitionOutput> RecruitingPort.Move_Candidate_to_Linked_Evergreen_RequisitionAsync(Move_Candidate_to_Linked_Evergreen_RequisitionInput request)
		{
			return base.Channel.Move_Candidate_to_Linked_Evergreen_RequisitionAsync(request);
		}

		public Task<Move_Candidate_to_Linked_Evergreen_RequisitionOutput> Move_Candidate_to_Linked_Evergreen_RequisitionAsync(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_to_Linked_Evergreen_Requisition_RequestType Move_Candidate_to_Linked_Evergreen_Requisition_Request)
		{
			return ((RecruitingPort)this).Move_Candidate_to_Linked_Evergreen_RequisitionAsync(new Move_Candidate_to_Linked_Evergreen_RequisitionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_to_Linked_Evergreen_Requisition_Request = Move_Candidate_to_Linked_Evergreen_Requisition_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Job_Application_Additional_DataOutput RecruitingPort.Get_Job_Application_Additional_Data(Get_Job_Application_Additional_DataInput request)
		{
			return base.Channel.Get_Job_Application_Additional_Data(request);
		}

		public Get_Job_Application_Additional_Data_ResponseType Get_Job_Application_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Application_Additional_Data_RequestType Get_Job_Application_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Get_Job_Application_Additional_Data(new Get_Job_Application_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Application_Additional_Data_Request = Get_Job_Application_Additional_Data_Request
			}).Get_Job_Application_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Job_Application_Additional_DataOutput> RecruitingPort.Get_Job_Application_Additional_DataAsync(Get_Job_Application_Additional_DataInput request)
		{
			return base.Channel.Get_Job_Application_Additional_DataAsync(request);
		}

		public Task<Get_Job_Application_Additional_DataOutput> Get_Job_Application_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Application_Additional_Data_RequestType Get_Job_Application_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Get_Job_Application_Additional_DataAsync(new Get_Job_Application_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Job_Application_Additional_Data_Request = Get_Job_Application_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Job_Application_Additional_DataOutput RecruitingPort.Put_Job_Application_Additional_Data(Put_Job_Application_Additional_DataInput request)
		{
			return base.Channel.Put_Job_Application_Additional_Data(request);
		}

		public Put_Job_Application_Additional_Data_ResponseType Put_Job_Application_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Application_Additional_Data_RequestType Put_Job_Application_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Put_Job_Application_Additional_Data(new Put_Job_Application_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Application_Additional_Data_Request = Put_Job_Application_Additional_Data_Request
			}).Put_Job_Application_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Job_Application_Additional_DataOutput> RecruitingPort.Put_Job_Application_Additional_DataAsync(Put_Job_Application_Additional_DataInput request)
		{
			return base.Channel.Put_Job_Application_Additional_DataAsync(request);
		}

		public Task<Put_Job_Application_Additional_DataOutput> Put_Job_Application_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Application_Additional_Data_RequestType Put_Job_Application_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Put_Job_Application_Additional_DataAsync(new Put_Job_Application_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Job_Application_Additional_Data_Request = Put_Job_Application_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Submit_Recruiting_Agency_CandidateOutput RecruitingPort.Submit_Recruiting_Agency_Candidate(Submit_Recruiting_Agency_CandidateInput request)
		{
			return base.Channel.Submit_Recruiting_Agency_Candidate(request);
		}

		public Submit_Recruiting_Agency_Candidate__ResponseType Submit_Recruiting_Agency_Candidate(Workday_Common_HeaderType Workday_Common_Header, Submit_Recruiting_Agency_Candidate_RequestType Submit_Recruiting_Agency_Candidate_Request)
		{
			return ((RecruitingPort)this).Submit_Recruiting_Agency_Candidate(new Submit_Recruiting_Agency_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Recruiting_Agency_Candidate_Request = Submit_Recruiting_Agency_Candidate_Request
			}).Submit_Recruiting_Agency_Candidate__Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Submit_Recruiting_Agency_CandidateOutput> RecruitingPort.Submit_Recruiting_Agency_CandidateAsync(Submit_Recruiting_Agency_CandidateInput request)
		{
			return base.Channel.Submit_Recruiting_Agency_CandidateAsync(request);
		}

		public Task<Submit_Recruiting_Agency_CandidateOutput> Submit_Recruiting_Agency_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Submit_Recruiting_Agency_Candidate_RequestType Submit_Recruiting_Agency_Candidate_Request)
		{
			return ((RecruitingPort)this).Submit_Recruiting_Agency_CandidateAsync(new Submit_Recruiting_Agency_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Submit_Recruiting_Agency_Candidate_Request = Submit_Recruiting_Agency_Candidate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Move_CandidateOutput RecruitingPort.Move_Candidate(Move_CandidateInput request)
		{
			return base.Channel.Move_Candidate(request);
		}

		public Move_Candidate_ResponseType Move_Candidate(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_RequestType Move_Candidate_Request)
		{
			return ((RecruitingPort)this).Move_Candidate(new Move_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_Request = Move_Candidate_Request
			}).Move_Candidate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Move_CandidateOutput> RecruitingPort.Move_CandidateAsync(Move_CandidateInput request)
		{
			return base.Channel.Move_CandidateAsync(request);
		}

		public Task<Move_CandidateOutput> Move_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Move_Candidate_RequestType Move_Candidate_Request)
		{
			return ((RecruitingPort)this).Move_CandidateAsync(new Move_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Move_Candidate_Request = Move_Candidate_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Recruiting_Agency_Additional_DataOutput RecruitingPort.Get_Recruiting_Agency_Additional_Data(Get_Recruiting_Agency_Additional_DataInput request)
		{
			return base.Channel.Get_Recruiting_Agency_Additional_Data(request);
		}

		public Get_Recruiting_Agency_Additional_Data_ResponseType Get_Recruiting_Agency_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Get_Recruiting_Agency_Additional_Data_RequestType Get_Recruiting_Agency_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Get_Recruiting_Agency_Additional_Data(new Get_Recruiting_Agency_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recruiting_Agency_Additional_Data_Request = Get_Recruiting_Agency_Additional_Data_Request
			}).Get_Recruiting_Agency_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Recruiting_Agency_Additional_DataOutput> RecruitingPort.Get_Recruiting_Agency_Additional_DataAsync(Get_Recruiting_Agency_Additional_DataInput request)
		{
			return base.Channel.Get_Recruiting_Agency_Additional_DataAsync(request);
		}

		public Task<Get_Recruiting_Agency_Additional_DataOutput> Get_Recruiting_Agency_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Recruiting_Agency_Additional_Data_RequestType Get_Recruiting_Agency_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Get_Recruiting_Agency_Additional_DataAsync(new Get_Recruiting_Agency_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Recruiting_Agency_Additional_Data_Request = Get_Recruiting_Agency_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Recruiting_Agency_Additional_DataOutput RecruitingPort.Put_Recruiting_Agency_Additional_Data(Put_Recruiting_Agency_Additional_DataInput request)
		{
			return base.Channel.Put_Recruiting_Agency_Additional_Data(request);
		}

		public Put_Recruiting_Agency_Additional_Data_ResponseType Put_Recruiting_Agency_Additional_Data(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Agency_Additional_Data_RequestType Put_Recruiting_Agency_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Put_Recruiting_Agency_Additional_Data(new Put_Recruiting_Agency_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recruiting_Agency_Additional_Data_Request = Put_Recruiting_Agency_Additional_Data_Request
			}).Put_Recruiting_Agency_Additional_Data_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Recruiting_Agency_Additional_DataOutput> RecruitingPort.Put_Recruiting_Agency_Additional_DataAsync(Put_Recruiting_Agency_Additional_DataInput request)
		{
			return base.Channel.Put_Recruiting_Agency_Additional_DataAsync(request);
		}

		public Task<Put_Recruiting_Agency_Additional_DataOutput> Put_Recruiting_Agency_Additional_DataAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Recruiting_Agency_Additional_Data_RequestType Put_Recruiting_Agency_Additional_Data_Request)
		{
			return ((RecruitingPort)this).Put_Recruiting_Agency_Additional_DataAsync(new Put_Recruiting_Agency_Additional_DataInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Recruiting_Agency_Additional_Data_Request = Put_Recruiting_Agency_Additional_Data_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Refer_a_CandidateOutput RecruitingPort.Refer_a_Candidate(Refer_a_CandidateInput request)
		{
			return base.Channel.Refer_a_Candidate(request);
		}

		public Refer_a_Candidate_ResponseType Refer_a_Candidate(Workday_Common_HeaderType Workday_Common_Header, Refer_a_Candidate_RequestType Refer_a_Candidate_Request)
		{
			return ((RecruitingPort)this).Refer_a_Candidate(new Refer_a_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Refer_a_Candidate_Request = Refer_a_Candidate_Request
			}).Refer_a_Candidate_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Refer_a_CandidateOutput> RecruitingPort.Refer_a_CandidateAsync(Refer_a_CandidateInput request)
		{
			return base.Channel.Refer_a_CandidateAsync(request);
		}

		public Task<Refer_a_CandidateOutput> Refer_a_CandidateAsync(Workday_Common_HeaderType Workday_Common_Header, Refer_a_Candidate_RequestType Refer_a_Candidate_Request)
		{
			return ((RecruitingPort)this).Refer_a_CandidateAsync(new Refer_a_CandidateInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Refer_a_Candidate_Request = Refer_a_Candidate_Request
			});
		}
	}
}
