using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Provisioning_Group_AssignmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Provisioning_Group_Assignment_RequestType Put_Provisioning_Group_Assignment_Request;

		public Put_Provisioning_Group_AssignmentInput()
		{
		}

		public Put_Provisioning_Group_AssignmentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Provisioning_Group_Assignment_RequestType Put_Provisioning_Group_Assignment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Provisioning_Group_Assignment_Request = Put_Provisioning_Group_Assignment_Request;
		}
	}
}
