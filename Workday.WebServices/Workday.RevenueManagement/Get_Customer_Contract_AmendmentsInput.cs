using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_Contract_AmendmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Contract_Amendments_RequestType Get_Customer_Contract_Amendments_Request;

		public Get_Customer_Contract_AmendmentsInput()
		{
		}

		public Get_Customer_Contract_AmendmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Customer_Contract_Amendments_RequestType Get_Customer_Contract_Amendments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Customer_Contract_Amendments_Request = Get_Customer_Contract_Amendments_Request;
		}
	}
}
