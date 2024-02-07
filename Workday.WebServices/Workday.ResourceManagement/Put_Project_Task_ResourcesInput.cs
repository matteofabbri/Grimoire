using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_Task_ResourcesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Task_Resources_RequestType Put_Project_Task_Resources_Request;

		public Put_Project_Task_ResourcesInput()
		{
		}

		public Put_Project_Task_ResourcesInput(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Task_Resources_RequestType Put_Project_Task_Resources_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Project_Task_Resources_Request = Put_Project_Task_Resources_Request;
		}
	}
}
