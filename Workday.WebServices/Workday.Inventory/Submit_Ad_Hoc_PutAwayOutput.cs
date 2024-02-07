using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_PutAwayOutput
	{
		[MessageBodyMember(Name = "Submit_Ad_Hoc_Put-Away_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Submit_Ad_Hoc_Put-Away_Response")]
		public Submit_Ad_Hoc_PutAway_ResponseType Submit_Ad_Hoc_PutAway_Response;

		public Submit_Ad_Hoc_PutAwayOutput()
		{
		}

		public Submit_Ad_Hoc_PutAwayOutput(Submit_Ad_Hoc_PutAway_ResponseType Submit_Ad_Hoc_PutAway_Response)
		{
			this.Submit_Ad_Hoc_PutAway_Response = Submit_Ad_Hoc_PutAway_Response;
		}
	}
}
