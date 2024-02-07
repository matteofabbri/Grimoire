using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_Rate_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Rate_Categories_ResponseType Get_Project_Rate_Categories_Response;

		public Get_Project_Rate_CategoriesOutput()
		{
		}

		public Get_Project_Rate_CategoriesOutput(Get_Project_Rate_Categories_ResponseType Get_Project_Rate_Categories_Response)
		{
			this.Get_Project_Rate_Categories_Response = Get_Project_Rate_Categories_Response;
		}
	}
}
