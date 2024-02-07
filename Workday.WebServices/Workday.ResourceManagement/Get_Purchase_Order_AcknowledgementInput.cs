using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Purchase_Order_AcknowledgementInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Purchase_Order_Acknowledgements_RequestType Get_Purchase_Order_Acknowledgements_Request;

		public Get_Purchase_Order_AcknowledgementInput()
		{
		}

		public Get_Purchase_Order_AcknowledgementInput(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Order_Acknowledgements_RequestType Get_Purchase_Order_Acknowledgements_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Purchase_Order_Acknowledgements_Request = Get_Purchase_Order_Acknowledgements_Request;
		}
	}
}
