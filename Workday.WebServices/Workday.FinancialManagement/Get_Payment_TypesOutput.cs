using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Types_ResponseType Get_Payment_Types_Response;

		public Get_Payment_TypesOutput()
		{
		}

		public Get_Payment_TypesOutput(Get_Payment_Types_ResponseType Get_Payment_Types_Response)
		{
			this.Get_Payment_Types_Response = Get_Payment_Types_Response;
		}
	}
}
