using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PO_for_PO_Issue_OutboundOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Issue_Purchase_Order_OutboundType Issue_Purchase_Order_Outbound;

		public Get_PO_for_PO_Issue_OutboundOutput()
		{
		}

		public Get_PO_for_PO_Issue_OutboundOutput(Issue_Purchase_Order_OutboundType Issue_Purchase_Order_Outbound)
		{
			this.Issue_Purchase_Order_Outbound = Issue_Purchase_Order_Outbound;
		}
	}
}
