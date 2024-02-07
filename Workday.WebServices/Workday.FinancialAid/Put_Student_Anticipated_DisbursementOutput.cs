using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Anticipated_DisbursementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Anticipated_Disbursement_ResponseType Put_Student_Anticipated_Disbursement_Response;

		public Put_Student_Anticipated_DisbursementOutput()
		{
		}

		public Put_Student_Anticipated_DisbursementOutput(Put_Student_Anticipated_Disbursement_ResponseType Put_Student_Anticipated_Disbursement_Response)
		{
			this.Put_Student_Anticipated_Disbursement_Response = Put_Student_Anticipated_Disbursement_Response;
		}
	}
}
