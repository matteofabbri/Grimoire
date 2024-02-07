using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_DonorsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Donors_RequestType Get_Donors_Request;

		public Get_DonorsInput()
		{
		}

		public Get_DonorsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Donors_RequestType Get_Donors_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Donors_Request = Get_Donors_Request;
		}
	}
}
