using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_ContractsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Contracts_ResponseType Get_Supplier_Contracts_Response;

		public Get_Supplier_ContractsOutput()
		{
		}

		public Get_Supplier_ContractsOutput(Get_Supplier_Contracts_ResponseType Get_Supplier_Contracts_Response)
		{
			this.Get_Supplier_Contracts_Response = Get_Supplier_Contracts_Response;
		}
	}
}
