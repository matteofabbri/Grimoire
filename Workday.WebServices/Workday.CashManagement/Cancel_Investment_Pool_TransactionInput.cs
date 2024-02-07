using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Investment_Pool_TransactionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Investment_Pool_Transaction_RequestType Cancel_Investment_Pool_Transaction_Request;

		public Cancel_Investment_Pool_TransactionInput()
		{
		}

		public Cancel_Investment_Pool_TransactionInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Investment_Pool_Transaction_RequestType Cancel_Investment_Pool_Transaction_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Investment_Pool_Transaction_Request = Cancel_Investment_Pool_Transaction_Request;
		}
	}
}
