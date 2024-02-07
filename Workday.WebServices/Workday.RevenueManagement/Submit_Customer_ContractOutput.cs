using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Customer_ContractOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Customer_Contract_ResponseType Submit_Customer_Contract_Response;

		public Submit_Customer_ContractOutput()
		{
		}

		public Submit_Customer_ContractOutput(Submit_Customer_Contract_ResponseType Submit_Customer_Contract_Response)
		{
			this.Submit_Customer_Contract_Response = Submit_Customer_Contract_Response;
		}
	}
}
