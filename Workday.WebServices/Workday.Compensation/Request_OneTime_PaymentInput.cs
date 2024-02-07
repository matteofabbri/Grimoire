using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_OneTime_PaymentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Request_One-Time_Payment_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Request_One-Time_Payment_Request")]
		public Request_OneTime_Payment_RequestType Request_OneTime_Payment_Request;

		public Request_OneTime_PaymentInput()
		{
		}

		public Request_OneTime_PaymentInput(Workday_Common_HeaderType Workday_Common_Header, Request_OneTime_Payment_RequestType Request_OneTime_Payment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_OneTime_Payment_Request = Request_OneTime_Payment_Request;
		}
	}
}
