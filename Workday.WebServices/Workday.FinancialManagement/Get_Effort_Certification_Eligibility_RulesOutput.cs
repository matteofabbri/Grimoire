using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Effort_Certification_Eligibility_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Effort_Certification_Eligibility_Rules_ResponseType Get_Effort_Certification_Eligibility_Rules_Response;

		public Get_Effort_Certification_Eligibility_RulesOutput()
		{
		}

		public Get_Effort_Certification_Eligibility_RulesOutput(Get_Effort_Certification_Eligibility_Rules_ResponseType Get_Effort_Certification_Eligibility_Rules_Response)
		{
			this.Get_Effort_Certification_Eligibility_Rules_Response = Get_Effort_Certification_Eligibility_Rules_Response;
		}
	}
}
