using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Multiple_Worksite_ReportInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Multiple_Worksite_Report_RequestType Get_Multiple_Worksite_Report_Request;

		public Get_Multiple_Worksite_ReportInput()
		{
		}

		public Get_Multiple_Worksite_ReportInput(Workday_Common_HeaderType Workday_Common_Header, Get_Multiple_Worksite_Report_RequestType Get_Multiple_Worksite_Report_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Multiple_Worksite_Report_Request = Get_Multiple_Worksite_Report_Request;
		}
	}
}
