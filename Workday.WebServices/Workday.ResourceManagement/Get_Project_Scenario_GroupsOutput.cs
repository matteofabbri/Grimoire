using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_Scenario_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Scenario_Groups_ResponseType Get_Project_Scenario_Groups_Response;

		public Get_Project_Scenario_GroupsOutput()
		{
		}

		public Get_Project_Scenario_GroupsOutput(Get_Project_Scenario_Groups_ResponseType Get_Project_Scenario_Groups_Response)
		{
			this.Get_Project_Scenario_Groups_Response = Get_Project_Scenario_Groups_Response;
		}
	}
}
