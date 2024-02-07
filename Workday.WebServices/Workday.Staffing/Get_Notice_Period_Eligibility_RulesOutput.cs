using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Notice_Period_Eligibility_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Notice_Period_Eligibility_Rules_ResponseType Get_Notice_Period_Eligibility_Rules_Response;

		public Get_Notice_Period_Eligibility_RulesOutput()
		{
		}

		public Get_Notice_Period_Eligibility_RulesOutput(Get_Notice_Period_Eligibility_Rules_ResponseType Get_Notice_Period_Eligibility_Rules_Response)
		{
			this.Get_Notice_Period_Eligibility_Rules_Response = Get_Notice_Period_Eligibility_Rules_Response;
		}
	}
}
