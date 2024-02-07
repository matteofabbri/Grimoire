using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Revenue_Category_HierarchiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Revenue_Category_Hierarchies_ResponseType Get_Revenue_Category_Hierarchies_Response;

		public Get_Revenue_Category_HierarchiesOutput()
		{
		}

		public Get_Revenue_Category_HierarchiesOutput(Get_Revenue_Category_Hierarchies_ResponseType Get_Revenue_Category_Hierarchies_Response)
		{
			this.Get_Revenue_Category_Hierarchies_Response = Get_Revenue_Category_Hierarchies_Response;
		}
	}
}
