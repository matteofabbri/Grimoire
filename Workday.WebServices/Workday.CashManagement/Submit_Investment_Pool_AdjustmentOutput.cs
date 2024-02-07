using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Investment_Pool_AdjustmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Investment_Pool_Adjustment_ResponseType Submit_Investment_Pool_Adjustment_Response;

		public Submit_Investment_Pool_AdjustmentOutput()
		{
		}

		public Submit_Investment_Pool_AdjustmentOutput(Submit_Investment_Pool_Adjustment_ResponseType Submit_Investment_Pool_Adjustment_Response)
		{
			this.Submit_Investment_Pool_Adjustment_Response = Submit_Investment_Pool_Adjustment_Response;
		}
	}
}
