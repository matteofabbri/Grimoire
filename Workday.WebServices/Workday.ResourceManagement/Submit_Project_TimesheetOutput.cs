using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Project_TimesheetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Project_Timesheet_ResponseType Submit_Project_Timesheet_Response;

		public Submit_Project_TimesheetOutput()
		{
		}

		public Submit_Project_TimesheetOutput(Submit_Project_Timesheet_ResponseType Submit_Project_Timesheet_Response)
		{
			this.Submit_Project_Timesheet_Response = Submit_Project_Timesheet_Response;
		}
	}
}
