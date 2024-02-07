using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Employee_Collective_Agreement_EventInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Employee_Collective_Agreement_Event_RequestType Assign_Employee_Collective_Agreement_Event_Request;

		public Assign_Employee_Collective_Agreement_EventInput()
		{
		}

		public Assign_Employee_Collective_Agreement_EventInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Employee_Collective_Agreement_Event_RequestType Assign_Employee_Collective_Agreement_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Employee_Collective_Agreement_Event_Request = Assign_Employee_Collective_Agreement_Event_Request;
		}
	}
}
