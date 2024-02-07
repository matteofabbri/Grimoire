using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Categories_ResponseType Get_Tax_Categories_Response;

		public Get_Tax_CategoriesOutput()
		{
		}

		public Get_Tax_CategoriesOutput(Get_Tax_Categories_ResponseType Get_Tax_Categories_Response)
		{
			this.Get_Tax_Categories_Response = Get_Tax_Categories_Response;
		}
	}
}
