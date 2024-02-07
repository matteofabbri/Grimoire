using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Transcript_OrderInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Transcript_Order_RequestType Put_Transcript_Order_Request;

		public Put_Transcript_OrderInput()
		{
		}

		public Put_Transcript_OrderInput(Workday_Common_HeaderType Workday_Common_Header, Put_Transcript_Order_RequestType Put_Transcript_Order_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Transcript_Order_Request = Put_Transcript_Order_Request;
		}
	}
}
