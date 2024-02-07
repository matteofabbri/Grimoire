using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Currency_Rate_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Currency_Rate_Types_ResponseType Get_Currency_Rate_Types_Response;

		public Get_Currency_Rate_TypesOutput()
		{
		}

		public Get_Currency_Rate_TypesOutput(Get_Currency_Rate_Types_ResponseType Get_Currency_Rate_Types_Response)
		{
			this.Get_Currency_Rate_Types_Response = Get_Currency_Rate_Types_Response;
		}
	}
}
