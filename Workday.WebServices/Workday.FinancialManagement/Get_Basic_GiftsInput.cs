using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Basic_GiftsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Basic_Gifts_RequestType Get_Basic_Gifts_Request;

		public Get_Basic_GiftsInput()
		{
		}

		public Get_Basic_GiftsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Basic_Gifts_RequestType Get_Basic_Gifts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Basic_Gifts_Request = Get_Basic_Gifts_Request;
		}
	}
}
