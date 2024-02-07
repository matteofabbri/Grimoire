using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payment_TermInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payment_Term_RequestType Put_Payment_Term_Request;

		public Put_Payment_TermInput()
		{
		}

		public Put_Payment_TermInput(Workday_Common_HeaderType Workday_Common_Header, Put_Payment_Term_RequestType Put_Payment_Term_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Payment_Term_Request = Put_Payment_Term_Request;
		}
	}
}
