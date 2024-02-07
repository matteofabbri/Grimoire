using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Project_ScenarioOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Project_Scenario_ResponseType Submit_Project_Scenario_Response;

		public Submit_Project_ScenarioOutput()
		{
		}

		public Submit_Project_ScenarioOutput(Submit_Project_Scenario_ResponseType Submit_Project_Scenario_Response)
		{
			this.Submit_Project_Scenario_Response = Submit_Project_Scenario_Response;
		}
	}
}
