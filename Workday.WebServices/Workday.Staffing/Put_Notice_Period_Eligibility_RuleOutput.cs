using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Notice_Period_Eligibility_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Notice_Period_Eligibility_Rule_ResponseType Put_Notice_Period_Eligibility_Rule_Response;

		public Put_Notice_Period_Eligibility_RuleOutput()
		{
		}

		public Put_Notice_Period_Eligibility_RuleOutput(Put_Notice_Period_Eligibility_Rule_ResponseType Put_Notice_Period_Eligibility_Rule_Response)
		{
			this.Put_Notice_Period_Eligibility_Rule_Response = Put_Notice_Period_Eligibility_Rule_Response;
		}
	}
}
