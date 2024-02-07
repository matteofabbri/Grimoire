using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payment_TermsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payment_Terms_RequestType Get_Payment_Terms_Request;

		public Get_Payment_TermsInput()
		{
		}

		public Get_Payment_TermsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Payment_Terms_RequestType Get_Payment_Terms_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Payment_Terms_Request = Get_Payment_Terms_Request;
		}
	}
}
