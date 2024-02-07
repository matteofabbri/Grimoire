using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Company_Payment_DatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Company_Payment_Dates_RequestType Get_Company_Payment_Dates_Request;

		public Get_Company_Payment_DatesInput()
		{
		}

		public Get_Company_Payment_DatesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Company_Payment_Dates_RequestType Get_Company_Payment_Dates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Company_Payment_Dates_Request = Get_Company_Payment_Dates_Request;
		}
	}
}
