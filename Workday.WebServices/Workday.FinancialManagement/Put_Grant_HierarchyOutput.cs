using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Grant_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Grant_Hierarchy_ResponseType Put_Grant_Hierarchy_Response;

		public Put_Grant_HierarchyOutput()
		{
		}

		public Put_Grant_HierarchyOutput(Put_Grant_Hierarchy_ResponseType Put_Grant_Hierarchy_Response)
		{
			this.Put_Grant_Hierarchy_Response = Put_Grant_Hierarchy_Response;
		}
	}
}
