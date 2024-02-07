using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Purchase_Order_AcknowledgementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Purchase_Order_Acknowledgements_ResponseType Get_Purchase_Order_Acknowledgements_Response;

		public Get_Purchase_Order_AcknowledgementOutput()
		{
		}

		public Get_Purchase_Order_AcknowledgementOutput(Get_Purchase_Order_Acknowledgements_ResponseType Get_Purchase_Order_Acknowledgements_Response)
		{
			this.Get_Purchase_Order_Acknowledgements_Response = Get_Purchase_Order_Acknowledgements_Response;
		}
	}
}
