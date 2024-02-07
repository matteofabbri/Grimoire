using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Currency_Rate_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Currency_Rate_Type_ResponseType Put_Currency_Rate_Type_Response;

		public Put_Currency_Rate_TypeOutput()
		{
		}

		public Put_Currency_Rate_TypeOutput(Put_Currency_Rate_Type_ResponseType Put_Currency_Rate_Type_Response)
		{
			this.Put_Currency_Rate_Type_Response = Put_Currency_Rate_Type_Response;
		}
	}
}
