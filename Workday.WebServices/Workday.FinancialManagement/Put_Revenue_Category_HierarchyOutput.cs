using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Revenue_Category_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Revenue_Category_Hierarchy_ResponseType Put_Revenue_Category_Hierarchy_Response;

		public Put_Revenue_Category_HierarchyOutput()
		{
		}

		public Put_Revenue_Category_HierarchyOutput(Put_Revenue_Category_Hierarchy_ResponseType Put_Revenue_Category_Hierarchy_Response)
		{
			this.Put_Revenue_Category_Hierarchy_Response = Put_Revenue_Category_Hierarchy_Response;
		}
	}
}
