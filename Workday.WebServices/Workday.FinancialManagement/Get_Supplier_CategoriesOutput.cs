using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Categories_ResponseType Get_Supplier_Categories_Response;

		public Get_Supplier_CategoriesOutput()
		{
		}

		public Get_Supplier_CategoriesOutput(Get_Supplier_Categories_ResponseType Get_Supplier_Categories_Response)
		{
			this.Get_Supplier_Categories_Response = Get_Supplier_Categories_Response;
		}
	}
}
