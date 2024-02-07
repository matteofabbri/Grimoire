using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_TimesheetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Timesheet_ResponseType Cancel_Timesheet_Response;

		public Cancel_TimesheetOutput()
		{
		}

		public Cancel_TimesheetOutput(Cancel_Timesheet_ResponseType Cancel_Timesheet_Response)
		{
			this.Cancel_Timesheet_Response = Cancel_Timesheet_Response;
		}
	}
}
