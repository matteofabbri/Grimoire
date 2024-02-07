using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_Project_Hierarchies_without_DependenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Project_Hierarchies_without_Dependencies_ResponseType Get_Workday_Project_Hierarchies_without_Dependencies_Response;

		public Get_Workday_Project_Hierarchies_without_DependenciesOutput()
		{
		}

		public Get_Workday_Project_Hierarchies_without_DependenciesOutput(Get_Workday_Project_Hierarchies_without_Dependencies_ResponseType Get_Workday_Project_Hierarchies_without_Dependencies_Response)
		{
			this.Get_Workday_Project_Hierarchies_without_Dependencies_Response = Get_Workday_Project_Hierarchies_without_Dependencies_Response;
		}
	}
}
