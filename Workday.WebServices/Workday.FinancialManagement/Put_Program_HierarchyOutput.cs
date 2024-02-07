using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Program_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Program_Hierarchy_ResponseType Put_Program_Hierarchy_Response;

		public Put_Program_HierarchyOutput()
		{
		}

		public Put_Program_HierarchyOutput(Put_Program_Hierarchy_ResponseType Put_Program_Hierarchy_Response)
		{
			this.Put_Program_Hierarchy_Response = Put_Program_Hierarchy_Response;
		}
	}
}
