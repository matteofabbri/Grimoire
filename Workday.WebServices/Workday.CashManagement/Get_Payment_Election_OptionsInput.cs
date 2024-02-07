using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_Election_OptionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Election_Options_RequestType Get_Payment_Election_Options_Request;

		public Get_Payment_Election_OptionsInput()
		{
		}

		public Get_Payment_Election_OptionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Election_Options_RequestType Get_Payment_Election_Options_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payment_Election_Options_Request = Get_Payment_Election_Options_Request;
		}
	}
}
