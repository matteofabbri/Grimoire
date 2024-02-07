using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contract_Rate_SheetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contract_Rate_Sheet_ResponseType Put_Contract_Rate_Sheet_Response;

		public Put_Contract_Rate_SheetOutput()
		{
		}

		public Put_Contract_Rate_SheetOutput(Put_Contract_Rate_Sheet_ResponseType Put_Contract_Rate_Sheet_Response)
		{
			this.Put_Contract_Rate_Sheet_Response = Put_Contract_Rate_Sheet_Response;
		}
	}
}
