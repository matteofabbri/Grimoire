using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Custom_Validation_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Custom_Validation_Rules_ResponseType Get_Custom_Validation_Rules_Response;

		public Get_Custom_Validation_RulesOutput()
		{
		}

		public Get_Custom_Validation_RulesOutput(Get_Custom_Validation_Rules_ResponseType Get_Custom_Validation_Rules_Response)
		{
			this.Get_Custom_Validation_Rules_Response = Get_Custom_Validation_Rules_Response;
		}
	}
}
