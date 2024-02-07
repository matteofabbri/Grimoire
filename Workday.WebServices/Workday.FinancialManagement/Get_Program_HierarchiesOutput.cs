using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Program_HierarchiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Program_Hierarchies_ResponseType Get_Program_Hierarchies_Response;

		public Get_Program_HierarchiesOutput()
		{
		}

		public Get_Program_HierarchiesOutput(Get_Program_Hierarchies_ResponseType Get_Program_Hierarchies_Response)
		{
			this.Get_Program_Hierarchies_Response = Get_Program_Hierarchies_Response;
		}
	}
}
