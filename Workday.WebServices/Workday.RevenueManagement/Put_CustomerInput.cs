using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CustomerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Customer_RequestType Put_Customer_Request;

		public Put_CustomerInput()
		{
		}

		public Put_CustomerInput(Workday_Common_HeaderType Workday_Common_Header, Put_Customer_RequestType Put_Customer_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Customer_Request = Put_Customer_Request;
		}
	}
}
