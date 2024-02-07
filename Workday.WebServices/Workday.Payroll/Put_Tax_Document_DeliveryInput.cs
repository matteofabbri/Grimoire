using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Tax_Document_DeliveryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Document_Delivery_RequestType Put_Tax_Document_Delivery_Request;

		public Put_Tax_Document_DeliveryInput()
		{
		}

		public Put_Tax_Document_DeliveryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Tax_Document_Delivery_RequestType Put_Tax_Document_Delivery_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Tax_Document_Delivery_Request = Put_Tax_Document_Delivery_Request;
		}
	}
}
