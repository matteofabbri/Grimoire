using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Previous_System_Job_HistoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Previous_System_Job_History_RequestType Get_Previous_System_Job_History_Request;

		public Get_Previous_System_Job_HistoryInput()
		{
		}

		public Get_Previous_System_Job_HistoryInput(Workday_Common_HeaderType Workday_Common_Header, Get_Previous_System_Job_History_RequestType Get_Previous_System_Job_History_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Previous_System_Job_History_Request = Get_Previous_System_Job_History_Request;
		}
	}
}
