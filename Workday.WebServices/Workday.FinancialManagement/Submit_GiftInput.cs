using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_GiftInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Gift_RequestType Submit_Gift_Request;

		public Submit_GiftInput()
		{
		}

		public Submit_GiftInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Gift_RequestType Submit_Gift_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Gift_Request = Submit_Gift_Request;
		}
	}
}
