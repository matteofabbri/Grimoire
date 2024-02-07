using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Customer_ContractOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Customer_Contract_ResponseType Cancel_Customer_Contract_Response;

		public Cancel_Customer_ContractOutput()
		{
		}

		public Cancel_Customer_ContractOutput(Cancel_Customer_Contract_ResponseType Cancel_Customer_Contract_Response)
		{
			this.Cancel_Customer_Contract_Response = Cancel_Customer_Contract_Response;
		}
	}
}
