using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_PutAwayInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Submit_Put-Away_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Submit_Put-Away_Request")]
		public Submit_PutAway_RequestType Submit_PutAway_Request;

		public Submit_PutAwayInput()
		{
		}

		public Submit_PutAwayInput(Workday_Common_HeaderType Workday_Common_Header, Submit_PutAway_RequestType Submit_PutAway_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_PutAway_Request = Submit_PutAway_Request;
		}
	}
}
