using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Move_Candidate_to_Linked_Job_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Move_Candidate_to_Linked_Job_Requisition_ResponseType Move_Candidate_to_Linked_Job_Requisition_Response;

		public Move_Candidate_to_Linked_Job_RequisitionOutput()
		{
		}

		public Move_Candidate_to_Linked_Job_RequisitionOutput(Move_Candidate_to_Linked_Job_Requisition_ResponseType Move_Candidate_to_Linked_Job_Requisition_Response)
		{
			this.Move_Candidate_to_Linked_Job_Requisition_Response = Move_Candidate_to_Linked_Job_Requisition_Response;
		}
	}
}
