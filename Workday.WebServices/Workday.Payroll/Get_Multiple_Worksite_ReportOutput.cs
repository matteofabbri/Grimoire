using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Multiple_Worksite_ReportOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Multiple_Worksite_Report_ResponseType Get_Multiple_Worksite_Report_Response;

		public Get_Multiple_Worksite_ReportOutput()
		{
		}

		public Get_Multiple_Worksite_ReportOutput(Get_Multiple_Worksite_Report_ResponseType Get_Multiple_Worksite_Report_Response)
		{
			this.Get_Multiple_Worksite_Report_Response = Get_Multiple_Worksite_Report_Response;
		}
	}
}
