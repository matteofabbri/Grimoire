using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Basic_SuppliersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Basic_Suppliers_ResponseType Get_Basic_Suppliers_Response;

		public Get_Basic_SuppliersOutput()
		{
		}

		public Get_Basic_SuppliersOutput(Get_Basic_Suppliers_ResponseType Get_Basic_Suppliers_Response)
		{
			this.Get_Basic_Suppliers_Response = Get_Basic_Suppliers_Response;
		}
	}
}
