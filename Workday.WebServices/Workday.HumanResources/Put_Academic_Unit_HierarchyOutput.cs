using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Academic_Unit_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Academic_Unit_Hierarchy_ResponseType Put_Academic_Unit_Hierarchy_Response;

		public Put_Academic_Unit_HierarchyOutput()
		{
		}

		public Put_Academic_Unit_HierarchyOutput(Put_Academic_Unit_Hierarchy_ResponseType Put_Academic_Unit_Hierarchy_Response)
		{
			this.Put_Academic_Unit_Hierarchy_Response = Put_Academic_Unit_Hierarchy_Response;
		}
	}
}
