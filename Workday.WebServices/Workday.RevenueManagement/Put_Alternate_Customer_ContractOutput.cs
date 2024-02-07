using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Alternate_Customer_ContractOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Alternate_Customer_Contract_ResponseType Put_Alternate_Customer_Contract_Response;

		public Put_Alternate_Customer_ContractOutput()
		{
		}

		public Put_Alternate_Customer_ContractOutput(Put_Alternate_Customer_Contract_ResponseType Put_Alternate_Customer_Contract_Response)
		{
			this.Put_Alternate_Customer_Contract_Response = Put_Alternate_Customer_Contract_Response;
		}
	}
}
