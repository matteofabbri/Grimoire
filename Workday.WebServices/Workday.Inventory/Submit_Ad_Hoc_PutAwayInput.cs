using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_PutAwayInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Submit_Ad_Hoc_Put-Away_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Submit_Ad_Hoc_Put-Away_Request")]
		public Submit_Ad_Hoc_PutAway_RequestType Submit_Ad_Hoc_PutAway_Request;

		public Submit_Ad_Hoc_PutAwayInput()
		{
		}

		public Submit_Ad_Hoc_PutAwayInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_PutAway_RequestType Submit_Ad_Hoc_PutAway_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Ad_Hoc_PutAway_Request = Submit_Ad_Hoc_PutAway_Request;
		}
	}
}
