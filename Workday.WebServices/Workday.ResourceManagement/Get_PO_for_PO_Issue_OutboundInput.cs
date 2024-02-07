using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PO_for_PO_Issue_OutboundInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_PO_Outbound_RequestType Get_PO_Outbound_Request;

		public Get_PO_for_PO_Issue_OutboundInput()
		{
		}

		public Get_PO_for_PO_Issue_OutboundInput(Workday_Common_HeaderType Workday_Common_Header, Get_PO_Outbound_RequestType Get_PO_Outbound_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_PO_Outbound_Request = Get_PO_Outbound_Request;
		}
	}
}
