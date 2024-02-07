using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Receivable_Writeoff_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Receivable_Writeoff_Categories_ResponseType Get_Receivable_Writeoff_Categories_Response;

		public Get_Receivable_Writeoff_CategoriesOutput()
		{
		}

		public Get_Receivable_Writeoff_CategoriesOutput(Get_Receivable_Writeoff_Categories_ResponseType Get_Receivable_Writeoff_Categories_Response)
		{
			this.Get_Receivable_Writeoff_Categories_Response = Get_Receivable_Writeoff_Categories_Response;
		}
	}
}
