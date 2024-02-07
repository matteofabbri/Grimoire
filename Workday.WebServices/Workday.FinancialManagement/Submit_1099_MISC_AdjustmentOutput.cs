using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_1099_MISC_AdjustmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_1099_MISC_Adjustment_ResponseType Submit_1099_MISC_Adjustment_Response;

		public Submit_1099_MISC_AdjustmentOutput()
		{
		}

		public Submit_1099_MISC_AdjustmentOutput(Submit_1099_MISC_Adjustment_ResponseType Submit_1099_MISC_Adjustment_Response)
		{
			this.Submit_1099_MISC_Adjustment_Response = Submit_1099_MISC_Adjustment_Response;
		}
	}
}
