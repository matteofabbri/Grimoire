using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Spend_Category_HierarchiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Spend_Category_Hierarchies_ResponseType Get_Spend_Category_Hierarchies_Response;

		public Get_Spend_Category_HierarchiesOutput()
		{
		}

		public Get_Spend_Category_HierarchiesOutput(Get_Spend_Category_Hierarchies_ResponseType Get_Spend_Category_Hierarchies_Response)
		{
			this.Get_Spend_Category_Hierarchies_Response = Get_Spend_Category_Hierarchies_Response;
		}
	}
}
