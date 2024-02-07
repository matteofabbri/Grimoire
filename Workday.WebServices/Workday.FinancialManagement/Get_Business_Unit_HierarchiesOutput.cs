using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_Unit_HierarchiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Unit_Hierarchies_ResponseType Get_Business_Unit_Hierarchies_Response;

		public Get_Business_Unit_HierarchiesOutput()
		{
		}

		public Get_Business_Unit_HierarchiesOutput(Get_Business_Unit_Hierarchies_ResponseType Get_Business_Unit_Hierarchies_Response)
		{
			this.Get_Business_Unit_Hierarchies_Response = Get_Business_Unit_Hierarchies_Response;
		}
	}
}
