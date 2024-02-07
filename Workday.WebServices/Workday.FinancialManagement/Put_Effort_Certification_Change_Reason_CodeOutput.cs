using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Effort_Certification_Change_Reason_CodeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Effort_Certification_Change_Reason_Code_ResponseType Put_Effort_Certification_Change_Reason_Code_Response;

		public Put_Effort_Certification_Change_Reason_CodeOutput()
		{
		}

		public Put_Effort_Certification_Change_Reason_CodeOutput(Put_Effort_Certification_Change_Reason_Code_ResponseType Put_Effort_Certification_Change_Reason_Code_Response)
		{
			this.Put_Effort_Certification_Change_Reason_Code_Response = Put_Effort_Certification_Change_Reason_Code_Response;
		}
	}
}
