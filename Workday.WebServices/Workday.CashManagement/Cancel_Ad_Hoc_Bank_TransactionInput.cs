using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Ad_Hoc_Bank_TransactionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Ad_hoc_Bank_Transaction_RequestType Cancel_Ad_hoc_Bank_Transaction_Request;

		public Cancel_Ad_Hoc_Bank_TransactionInput()
		{
		}

		public Cancel_Ad_Hoc_Bank_TransactionInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Ad_hoc_Bank_Transaction_RequestType Cancel_Ad_hoc_Bank_Transaction_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Ad_hoc_Bank_Transaction_Request = Cancel_Ad_hoc_Bank_Transaction_Request;
		}
	}
}
