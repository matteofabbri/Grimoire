using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Spend_Category_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Spend_Category_Hierarchy_ResponseType Put_Spend_Category_Hierarchy_Response;

		public Put_Spend_Category_HierarchyOutput()
		{
		}

		public Put_Spend_Category_HierarchyOutput(Put_Spend_Category_Hierarchy_ResponseType Put_Spend_Category_Hierarchy_Response)
		{
			this.Put_Spend_Category_Hierarchy_Response = Put_Spend_Category_Hierarchy_Response;
		}
	}
}
