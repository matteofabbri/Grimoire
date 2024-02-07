using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prepaid_Spend_AmortizationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prepaid_Spend_Amortizations_RequestType Get_Prepaid_Spend_Amortizations_Request;

		public Get_Prepaid_Spend_AmortizationsInput()
		{
		}

		public Get_Prepaid_Spend_AmortizationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Prepaid_Spend_Amortizations_RequestType Get_Prepaid_Spend_Amortizations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Prepaid_Spend_Amortizations_Request = Get_Prepaid_Spend_Amortizations_Request;
		}
	}
}
