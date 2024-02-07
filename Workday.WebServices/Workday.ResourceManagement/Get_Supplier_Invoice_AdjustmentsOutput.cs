using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Invoice_AdjustmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Invoice_Adjustments_ResponseType Get_Supplier_Invoice_Adjustments_Response;

		public Get_Supplier_Invoice_AdjustmentsOutput()
		{
		}

		public Get_Supplier_Invoice_AdjustmentsOutput(Get_Supplier_Invoice_Adjustments_ResponseType Get_Supplier_Invoice_Adjustments_Response)
		{
			this.Get_Supplier_Invoice_Adjustments_Response = Get_Supplier_Invoice_Adjustments_Response;
		}
	}
}
