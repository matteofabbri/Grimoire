using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_SSP_HistoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_SSP_History_RequestType Get_Payroll_SSP_History_Request;

		public Get_Payroll_SSP_HistoryInput()
		{
		}

		public Get_Payroll_SSP_HistoryInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payroll_SSP_History_RequestType Get_Payroll_SSP_History_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payroll_SSP_History_Request = Get_Payroll_SSP_History_Request;
		}
	}
}
