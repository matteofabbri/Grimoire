using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payment_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Type_ResponseType Put_Payment_Type_Response;

		public Put_Payment_TypeOutput()
		{
		}

		public Put_Payment_TypeOutput(Put_Payment_Type_ResponseType Put_Payment_Type_Response)
		{
			this.Put_Payment_Type_Response = Put_Payment_Type_Response;
		}
	}
}
