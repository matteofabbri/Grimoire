using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_TimesheetsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Timesheets_RequestType Get_Timesheets_Request;

		public Get_TimesheetsInput()
		{
		}

		public Get_TimesheetsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Timesheets_RequestType Get_Timesheets_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Timesheets_Request = Get_Timesheets_Request;
		}
	}
}
