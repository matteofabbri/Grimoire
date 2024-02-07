using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
	public class AdmissionsPortClient : ClientBase<AdmissionsPort>, AdmissionsPort
	{
		public AdmissionsPortClient()
		{
		}

		public AdmissionsPortClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		public AdmissionsPortClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public AdmissionsPortClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		public AdmissionsPortClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Application_Admission_ResponseOutput AdmissionsPort.Put_Student_Application_Admission_Response(Put_Student_Application_Admission_ResponseInput request)
		{
			return base.Channel.Put_Student_Application_Admission_Response(request);
		}

		public Put_Student_Application_Admission_Response_ResponseType Put_Student_Application_Admission_Response(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Admission_Response_RequestType Put_Student_Application_Admission_Response_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_Admission_Response(new Put_Student_Application_Admission_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Admission_Response_Request = Put_Student_Application_Admission_Response_Request
			}).Put_Student_Application_Admission_Response_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Application_Admission_ResponseOutput> AdmissionsPort.Put_Student_Application_Admission_ResponseAsync(Put_Student_Application_Admission_ResponseInput request)
		{
			return base.Channel.Put_Student_Application_Admission_ResponseAsync(request);
		}

		public Task<Put_Student_Application_Admission_ResponseOutput> Put_Student_Application_Admission_ResponseAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Admission_Response_RequestType Put_Student_Application_Admission_Response_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_Admission_ResponseAsync(new Put_Student_Application_Admission_ResponseInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Admission_Response_Request = Put_Student_Application_Admission_Response_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Application_Admission_ResponsesOutput AdmissionsPort.Get_Student_Application_Admission_Responses(Get_Student_Application_Admission_ResponsesInput request)
		{
			return base.Channel.Get_Student_Application_Admission_Responses(request);
		}

		public Get_Student_Application_Admission_Responses_ResponseType Get_Student_Application_Admission_Responses(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Admission_Responses_RequestType Get_Student_Application_Admission_Responses_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_Admission_Responses(new Get_Student_Application_Admission_ResponsesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Admission_Responses_Request = Get_Student_Application_Admission_Responses_Request
			}).Get_Student_Application_Admission_Responses_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Application_Admission_ResponsesOutput> AdmissionsPort.Get_Student_Application_Admission_ResponsesAsync(Get_Student_Application_Admission_ResponsesInput request)
		{
			return base.Channel.Get_Student_Application_Admission_ResponsesAsync(request);
		}

		public Task<Get_Student_Application_Admission_ResponsesOutput> Get_Student_Application_Admission_ResponsesAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Admission_Responses_RequestType Get_Student_Application_Admission_Responses_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_Admission_ResponsesAsync(new Get_Student_Application_Admission_ResponsesInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Admission_Responses_Request = Get_Student_Application_Admission_Responses_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Application_Requirement_AssignmentOutput AdmissionsPort.Put_Student_Application_Requirement_Assignment(Put_Student_Application_Requirement_AssignmentInput request)
		{
			return base.Channel.Put_Student_Application_Requirement_Assignment(request);
		}

		public Put_Student_Application_Requirement_Assignment_ResponseType Put_Student_Application_Requirement_Assignment(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Requirement_Assignment_RequestType Put_Student_Application_Requirement_Assignment_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_Requirement_Assignment(new Put_Student_Application_Requirement_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Requirement_Assignment_Request = Put_Student_Application_Requirement_Assignment_Request
			}).Put_Student_Application_Requirement_Assignment_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Application_Requirement_AssignmentOutput> AdmissionsPort.Put_Student_Application_Requirement_AssignmentAsync(Put_Student_Application_Requirement_AssignmentInput request)
		{
			return base.Channel.Put_Student_Application_Requirement_AssignmentAsync(request);
		}

		public Task<Put_Student_Application_Requirement_AssignmentOutput> Put_Student_Application_Requirement_AssignmentAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Requirement_Assignment_RequestType Put_Student_Application_Requirement_Assignment_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_Requirement_AssignmentAsync(new Put_Student_Application_Requirement_AssignmentInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Requirement_Assignment_Request = Put_Student_Application_Requirement_Assignment_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Application_Requirement_AssignmentsOutput AdmissionsPort.Get_Student_Application_Requirement_Assignments(Get_Student_Application_Requirement_AssignmentsInput request)
		{
			return base.Channel.Get_Student_Application_Requirement_Assignments(request);
		}

		public Get_Student_Application_Requirement_Assignments_ResponseType Get_Student_Application_Requirement_Assignments(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Requirement_Assignments_RequestType Get_Student_Application_Requirement_Assignments_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_Requirement_Assignments(new Get_Student_Application_Requirement_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Requirement_Assignments_Request = Get_Student_Application_Requirement_Assignments_Request
			}).Get_Student_Application_Requirement_Assignments_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Application_Requirement_AssignmentsOutput> AdmissionsPort.Get_Student_Application_Requirement_AssignmentsAsync(Get_Student_Application_Requirement_AssignmentsInput request)
		{
			return base.Channel.Get_Student_Application_Requirement_AssignmentsAsync(request);
		}

		public Task<Get_Student_Application_Requirement_AssignmentsOutput> Get_Student_Application_Requirement_AssignmentsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Requirement_Assignments_RequestType Get_Student_Application_Requirement_Assignments_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_Requirement_AssignmentsAsync(new Get_Student_Application_Requirement_AssignmentsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Requirement_Assignments_Request = Get_Student_Application_Requirement_Assignments_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_External_Student_TranscriptOutput AdmissionsPort.Put_External_Student_Transcript(Put_External_Student_TranscriptInput request)
		{
			return base.Channel.Put_External_Student_Transcript(request);
		}

		public Put_External_Student_Transcript_ResponseType Put_External_Student_Transcript(Workday_Common_HeaderType Workday_Common_Header, Put_External_Student_Transcript_RequestType Put_External_Student_Transcript_Request)
		{
			return ((AdmissionsPort)this).Put_External_Student_Transcript(new Put_External_Student_TranscriptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Student_Transcript_Request = Put_External_Student_Transcript_Request
			}).Put_External_Student_Transcript_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_External_Student_TranscriptOutput> AdmissionsPort.Put_External_Student_TranscriptAsync(Put_External_Student_TranscriptInput request)
		{
			return base.Channel.Put_External_Student_TranscriptAsync(request);
		}

		public Task<Put_External_Student_TranscriptOutput> Put_External_Student_TranscriptAsync(Workday_Common_HeaderType Workday_Common_Header, Put_External_Student_Transcript_RequestType Put_External_Student_Transcript_Request)
		{
			return ((AdmissionsPort)this).Put_External_Student_TranscriptAsync(new Put_External_Student_TranscriptInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_External_Student_Transcript_Request = Put_External_Student_Transcript_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_External_Student_TranscriptsOutput AdmissionsPort.Get_External_Student_Transcripts(Get_External_Student_TranscriptsInput request)
		{
			return base.Channel.Get_External_Student_Transcripts(request);
		}

		public Get_External_Student_Transcripts_ResponseType Get_External_Student_Transcripts(Workday_Common_HeaderType Workday_Common_Header, Get_External_Student_Transcripts_RequestType Get_External_Student_Transcripts_Request)
		{
			return ((AdmissionsPort)this).Get_External_Student_Transcripts(new Get_External_Student_TranscriptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Student_Transcripts_Request = Get_External_Student_Transcripts_Request
			}).Get_External_Student_Transcripts_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_External_Student_TranscriptsOutput> AdmissionsPort.Get_External_Student_TranscriptsAsync(Get_External_Student_TranscriptsInput request)
		{
			return base.Channel.Get_External_Student_TranscriptsAsync(request);
		}

		public Task<Get_External_Student_TranscriptsOutput> Get_External_Student_TranscriptsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_External_Student_Transcripts_RequestType Get_External_Student_Transcripts_Request)
		{
			return ((AdmissionsPort)this).Get_External_Student_TranscriptsAsync(new Get_External_Student_TranscriptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_External_Student_Transcripts_Request = Get_External_Student_Transcripts_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_ApplicationsOutput AdmissionsPort.Get_Student_Applications(Get_Student_ApplicationsInput request)
		{
			return base.Channel.Get_Student_Applications(request);
		}

		public Get_Student_Applications_ResponseType Get_Student_Applications(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Applications_RequestType Get_Student_Applications_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Applications(new Get_Student_ApplicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Applications_Request = Get_Student_Applications_Request
			}).Get_Student_Applications_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_ApplicationsOutput> AdmissionsPort.Get_Student_ApplicationsAsync(Get_Student_ApplicationsInput request)
		{
			return base.Channel.Get_Student_ApplicationsAsync(request);
		}

		public Task<Get_Student_ApplicationsOutput> Get_Student_ApplicationsAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Applications_RequestType Get_Student_Applications_Request)
		{
			return ((AdmissionsPort)this).Get_Student_ApplicationsAsync(new Get_Student_ApplicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Applications_Request = Get_Student_Applications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_ApplicationOutput AdmissionsPort.Put_Student_Application(Put_Student_ApplicationInput request)
		{
			return base.Channel.Put_Student_Application(request);
		}

		public Put_Student_Application_ResponseType Put_Student_Application(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_RequestType Put_Student_Application_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application(new Put_Student_ApplicationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Request = Put_Student_Application_Request
			}).Put_Student_Application_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_ApplicationOutput> AdmissionsPort.Put_Student_ApplicationAsync(Put_Student_ApplicationInput request)
		{
			return base.Channel.Put_Student_ApplicationAsync(request);
		}

		public Task<Put_Student_ApplicationOutput> Put_Student_ApplicationAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_RequestType Put_Student_Application_Request)
		{
			return ((AdmissionsPort)this).Put_Student_ApplicationAsync(new Put_Student_ApplicationInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Request = Put_Student_Application_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Put_Student_Application_ResidencyOutput AdmissionsPort.Put_Student_Application_Residency(Put_Student_Application_ResidencyInput request)
		{
			return base.Channel.Put_Student_Application_Residency(request);
		}

		public Put_Student_Application_Residency_ResponseType Put_Student_Application_Residency(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Residency_RequestType Put_Student_Application_Residency_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_Residency(new Put_Student_Application_ResidencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Residency_Request = Put_Student_Application_Residency_Request
			}).Put_Student_Application_Residency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Put_Student_Application_ResidencyOutput> AdmissionsPort.Put_Student_Application_ResidencyAsync(Put_Student_Application_ResidencyInput request)
		{
			return base.Channel.Put_Student_Application_ResidencyAsync(request);
		}

		public Task<Put_Student_Application_ResidencyOutput> Put_Student_Application_ResidencyAsync(Workday_Common_HeaderType Workday_Common_Header, Put_Student_Application_Residency_RequestType Put_Student_Application_Residency_Request)
		{
			return ((AdmissionsPort)this).Put_Student_Application_ResidencyAsync(new Put_Student_Application_ResidencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Put_Student_Application_Residency_Request = Put_Student_Application_Residency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Get_Student_Application_ResidencyOutput AdmissionsPort.Get_Student_Application_Residency(Get_Student_Application_ResidencyInput request)
		{
			return base.Channel.Get_Student_Application_Residency(request);
		}

		public Get_Student_Application_Residency_ResponseType Get_Student_Application_Residency(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Residency_RequestType Get_Student_Application_Residency_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_Residency(new Get_Student_Application_ResidencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Residency_Request = Get_Student_Application_Residency_Request
			}).Get_Student_Application_Residency_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Get_Student_Application_ResidencyOutput> AdmissionsPort.Get_Student_Application_ResidencyAsync(Get_Student_Application_ResidencyInput request)
		{
			return base.Channel.Get_Student_Application_ResidencyAsync(request);
		}

		public Task<Get_Student_Application_ResidencyOutput> Get_Student_Application_ResidencyAsync(Workday_Common_HeaderType Workday_Common_Header, Get_Student_Application_Residency_RequestType Get_Student_Application_Residency_Request)
		{
			return ((AdmissionsPort)this).Get_Student_Application_ResidencyAsync(new Get_Student_Application_ResidencyInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Get_Student_Application_Residency_Request = Get_Student_Application_Residency_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_External_Student_TranscriptsOutput AdmissionsPort.Import_External_Student_Transcripts(Import_External_Student_TranscriptsInput request)
		{
			return base.Channel.Import_External_Student_Transcripts(request);
		}

		public Put_Import_Process_ResponseType Import_External_Student_Transcripts(Workday_Common_HeaderType Workday_Common_Header, Import_External_Student_Transcript_RequestType Import_External_Student_Transcript_Request)
		{
			return ((AdmissionsPort)this).Import_External_Student_Transcripts(new Import_External_Student_TranscriptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_External_Student_Transcript_Request = Import_External_Student_Transcript_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_External_Student_TranscriptsOutput> AdmissionsPort.Import_External_Student_TranscriptsAsync(Import_External_Student_TranscriptsInput request)
		{
			return base.Channel.Import_External_Student_TranscriptsAsync(request);
		}

		public Task<Import_External_Student_TranscriptsOutput> Import_External_Student_TranscriptsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_External_Student_Transcript_RequestType Import_External_Student_Transcript_Request)
		{
			return ((AdmissionsPort)this).Import_External_Student_TranscriptsAsync(new Import_External_Student_TranscriptsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_External_Student_Transcript_Request = Import_External_Student_Transcript_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_External_Student_TranscriptsOutput AdmissionsPort.Import_Student_Applications(Import_Student_ApplicationsInput request)
		{
			return base.Channel.Import_Student_Applications(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Applications(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Applications_RequestType Import_Student_Applications_Request)
		{
			return ((AdmissionsPort)this).Import_Student_Applications(new Import_Student_ApplicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Applications_Request = Import_Student_Applications_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_External_Student_TranscriptsOutput> AdmissionsPort.Import_Student_ApplicationsAsync(Import_Student_ApplicationsInput request)
		{
			return base.Channel.Import_Student_ApplicationsAsync(request);
		}

		public Task<Import_External_Student_TranscriptsOutput> Import_Student_ApplicationsAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Applications_RequestType Import_Student_Applications_Request)
		{
			return ((AdmissionsPort)this).Import_Student_ApplicationsAsync(new Import_Student_ApplicationsInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Applications_Request = Import_Student_Applications_Request
			});
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Import_External_Student_TranscriptsOutput AdmissionsPort.Import_Student_Application_Admission_Decision(Import_Student_Application_Admission_DecisionInput request)
		{
			return base.Channel.Import_Student_Application_Admission_Decision(request);
		}

		public Put_Import_Process_ResponseType Import_Student_Application_Admission_Decision(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Application_Admission_Decision_RequestType Import_Student_Application_Admission_Decision_Request)
		{
			return ((AdmissionsPort)this).Import_Student_Application_Admission_Decision(new Import_Student_Application_Admission_DecisionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Application_Admission_Decision_Request = Import_Student_Application_Admission_Decision_Request
			}).Put_Import_Process_Response;
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Task<Import_External_Student_TranscriptsOutput> AdmissionsPort.Import_Student_Application_Admission_DecisionAsync(Import_Student_Application_Admission_DecisionInput request)
		{
			return base.Channel.Import_Student_Application_Admission_DecisionAsync(request);
		}

		public Task<Import_External_Student_TranscriptsOutput> Import_Student_Application_Admission_DecisionAsync(Workday_Common_HeaderType Workday_Common_Header, Import_Student_Application_Admission_Decision_RequestType Import_Student_Application_Admission_Decision_Request)
		{
			return ((AdmissionsPort)this).Import_Student_Application_Admission_DecisionAsync(new Import_Student_Application_Admission_DecisionInput
			{
				Workday_Common_Header = Workday_Common_Header,
				Import_Student_Application_Admission_Decision_Request = Import_Student_Application_Admission_Decision_Request
			});
		}
	}
}
