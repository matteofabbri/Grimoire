using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Suspense_Account_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Suspense_Account_Rule_ResponseType Put_Suspense_Account_Rule_Response;

		public Put_Suspense_Account_RuleOutput()
		{
		}

		public Put_Suspense_Account_RuleOutput(Put_Suspense_Account_Rule_ResponseType Put_Suspense_Account_Rule_Response)
		{
			this.Put_Suspense_Account_Rule_Response = Put_Suspense_Account_Rule_Response;
		}
	}
}
