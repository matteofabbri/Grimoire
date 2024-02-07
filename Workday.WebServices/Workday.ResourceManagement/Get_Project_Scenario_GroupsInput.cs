using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_Scenario_GroupsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Scenario_Groups_RequestType Get_Project_Scenario_Groups_Request;

		public Get_Project_Scenario_GroupsInput()
		{
		}

		public Get_Project_Scenario_GroupsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Project_Scenario_Groups_RequestType Get_Project_Scenario_Groups_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Project_Scenario_Groups_Request = Get_Project_Scenario_Groups_Request;
		}
	}
}
