using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Credit_Card_AuthorizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Credit_Card_Authorization_RequestType Get_Credit_Card_Authorization_Request;

		public Get_Credit_Card_AuthorizationInput()
		{
		}

		public Get_Credit_Card_AuthorizationInput(Workday_Common_HeaderType Workday_Common_Header, Get_Credit_Card_Authorization_RequestType Get_Credit_Card_Authorization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Credit_Card_Authorization_Request = Get_Credit_Card_Authorization_Request;
		}
	}
}
