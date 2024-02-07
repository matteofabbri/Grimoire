using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Basic_CustomerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Basic_Customer_RequestType Put_Basic_Customer_Request;

		public Put_Basic_CustomerInput()
		{
		}

		public Put_Basic_CustomerInput(Workday_Common_HeaderType Workday_Common_Header, Put_Basic_Customer_RequestType Put_Basic_Customer_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Basic_Customer_Request = Put_Basic_Customer_Request;
		}
	}
}
