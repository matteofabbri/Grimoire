using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_TimesheetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Timesheet_RequestType Cancel_Timesheet_Request;

		public Cancel_TimesheetInput()
		{
		}

		public Cancel_TimesheetInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Timesheet_RequestType Cancel_Timesheet_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Timesheet_Request = Cancel_Timesheet_Request;
		}
	}
}
