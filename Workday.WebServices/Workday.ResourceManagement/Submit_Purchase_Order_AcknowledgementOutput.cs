using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Purchase_Order_AcknowledgementOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Purchase_Order_Acknowledgement_ResponseType Submit_Purchase_Order_Acknowledgement_Response;

		public Submit_Purchase_Order_AcknowledgementOutput()
		{
		}

		public Submit_Purchase_Order_AcknowledgementOutput(Submit_Purchase_Order_Acknowledgement_ResponseType Submit_Purchase_Order_Acknowledgement_Response)
		{
			this.Submit_Purchase_Order_Acknowledgement_Response = Submit_Purchase_Order_Acknowledgement_Response;
		}
	}
}
