using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SupplierOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Supplier_ResponseType Put_Supplier_Response;

		public Put_SupplierOutput()
		{
		}

		public Put_SupplierOutput(Put_Supplier_ResponseType Put_Supplier_Response)
		{
			this.Put_Supplier_Response = Put_Supplier_Response;
		}
	}
}
