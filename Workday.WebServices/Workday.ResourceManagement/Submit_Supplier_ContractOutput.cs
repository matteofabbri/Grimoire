using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_ContractOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Contract_ResponseType Submit_Supplier_Contract_Response;

		public Submit_Supplier_ContractOutput()
		{
		}

		public Submit_Supplier_ContractOutput(Submit_Supplier_Contract_ResponseType Submit_Supplier_Contract_Response)
		{
			this.Submit_Supplier_Contract_Response = Submit_Supplier_Contract_Response;
		}
	}
}
