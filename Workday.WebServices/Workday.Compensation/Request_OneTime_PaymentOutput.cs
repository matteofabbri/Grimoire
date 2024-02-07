using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_OneTime_PaymentOutput
	{
		[MessageBodyMember(Name = "Request_One-Time_Payment_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Request_One-Time_Payment_Response")]
		public Request_OneTime_Payment_ResponseType Request_OneTime_Payment_Response;

		public Request_OneTime_PaymentOutput()
		{
		}

		public Request_OneTime_PaymentOutput(Request_OneTime_Payment_ResponseType Request_OneTime_Payment_Response)
		{
			this.Request_OneTime_Payment_Response = Request_OneTime_Payment_Response;
		}
	}
}
