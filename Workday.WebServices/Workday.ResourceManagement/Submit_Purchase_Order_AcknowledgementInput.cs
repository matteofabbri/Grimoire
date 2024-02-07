using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Purchase_Order_AcknowledgementInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Purchase_Order_Acknowledgement_RequestType Submit_Purchase_Order_Acknowledgement_Request;

		public Submit_Purchase_Order_AcknowledgementInput()
		{
		}

		public Submit_Purchase_Order_AcknowledgementInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Purchase_Order_Acknowledgement_RequestType Submit_Purchase_Order_Acknowledgement_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Purchase_Order_Acknowledgement_Request = Submit_Purchase_Order_Acknowledgement_Request;
		}
	}
}
