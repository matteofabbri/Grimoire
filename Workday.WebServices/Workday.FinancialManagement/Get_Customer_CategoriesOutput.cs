using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Categories_ResponseType Get_Customer_Categories_Response;

		public Get_Customer_CategoriesOutput()
		{
		}

		public Get_Customer_CategoriesOutput(Get_Customer_Categories_ResponseType Get_Customer_Categories_Response)
		{
			this.Get_Customer_Categories_Response = Get_Customer_Categories_Response;
		}
	}
}
