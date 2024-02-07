using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Fund_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Fund_Hierarchy_ResponseType Put_Fund_Hierarchy_Response;

		public Put_Fund_HierarchyOutput()
		{
		}

		public Put_Fund_HierarchyOutput(Put_Fund_Hierarchy_ResponseType Put_Fund_Hierarchy_Response)
		{
			this.Put_Fund_Hierarchy_Response = Put_Fund_Hierarchy_Response;
		}
	}
}
