using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Investment_Pool_AdjustmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Investment_Pool_Adjustment_RequestType Submit_Investment_Pool_Adjustment_Request;

		public Submit_Investment_Pool_AdjustmentInput()
		{
		}

		public Submit_Investment_Pool_AdjustmentInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Adjustment_RequestType Submit_Investment_Pool_Adjustment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Investment_Pool_Adjustment_Request = Submit_Investment_Pool_Adjustment_Request;
		}
	}
}
