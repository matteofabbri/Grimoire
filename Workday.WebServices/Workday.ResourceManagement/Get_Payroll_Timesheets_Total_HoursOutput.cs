using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Timesheets_Total_HoursOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Timesheets_Total_Hours_ResponseType Get_Payroll_Timesheets_Total_Hours_Response;

		public Get_Payroll_Timesheets_Total_HoursOutput()
		{
		}

		public Get_Payroll_Timesheets_Total_HoursOutput(Get_Payroll_Timesheets_Total_Hours_ResponseType Get_Payroll_Timesheets_Total_Hours_Response)
		{
			this.Get_Payroll_Timesheets_Total_Hours_Response = Get_Payroll_Timesheets_Total_Hours_Response;
		}
	}
}
