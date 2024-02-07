using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Business_Unit_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Business_Unit_Hierarchy_ResponseType Put_Business_Unit_Hierarchy_Response;

		public Put_Business_Unit_HierarchyOutput()
		{
		}

		public Put_Business_Unit_HierarchyOutput(Put_Business_Unit_Hierarchy_ResponseType Put_Business_Unit_Hierarchy_Response)
		{
			this.Put_Business_Unit_Hierarchy_Response = Put_Business_Unit_Hierarchy_Response;
		}
	}
}
