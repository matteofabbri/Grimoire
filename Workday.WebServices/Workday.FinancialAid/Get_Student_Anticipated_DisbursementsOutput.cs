using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Anticipated_DisbursementsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Anticipated_Disbursements_ResponseType Get_Student_Anticipated_Disbursements_Response;

		public Get_Student_Anticipated_DisbursementsOutput()
		{
		}

		public Get_Student_Anticipated_DisbursementsOutput(Get_Student_Anticipated_Disbursements_ResponseType Get_Student_Anticipated_Disbursements_Response)
		{
			this.Get_Student_Anticipated_Disbursements_Response = Get_Student_Anticipated_Disbursements_Response;
		}
	}
}
