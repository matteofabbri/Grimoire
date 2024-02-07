using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transcript_OrdersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Transcript_Orders_RequestType Get_Transcript_Orders_Request;

		public Get_Transcript_OrdersInput()
		{
		}

		public Get_Transcript_OrdersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Transcript_Orders_RequestType Get_Transcript_Orders_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Transcript_Orders_Request = Get_Transcript_Orders_Request;
		}
	}
}
