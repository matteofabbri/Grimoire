using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ad_Hoc_PayeeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ad_Hoc_Payee_RequestType Put_Ad_Hoc_Payee_Request;

		public Put_Ad_Hoc_PayeeInput()
		{
		}

		public Put_Ad_Hoc_PayeeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Ad_Hoc_Payee_RequestType Put_Ad_Hoc_Payee_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Ad_Hoc_Payee_Request = Put_Ad_Hoc_Payee_Request;
		}
	}
}
