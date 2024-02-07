using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_TasksInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Tasks_RequestType Get_Award_Tasks_Request;

		public Get_Award_TasksInput()
		{
		}

		public Get_Award_TasksInput(Workday_Common_HeaderType Workday_Common_Header, Get_Award_Tasks_RequestType Get_Award_Tasks_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Award_Tasks_Request = Get_Award_Tasks_Request;
		}
	}
}
