using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Grant_HierarchiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Grant_Hierarchies_ResponseType Get_Grant_Hierarchies_Response;

		public Get_Grant_HierarchiesOutput()
		{
		}

		public Get_Grant_HierarchiesOutput(Get_Grant_Hierarchies_ResponseType Get_Grant_Hierarchies_Response)
		{
			this.Get_Grant_Hierarchies_Response = Get_Grant_Hierarchies_Response;
		}
	}
}
