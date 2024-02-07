using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Notice_PeriodsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Notice_Periods_for_Notice_Period_Target_ResponseType Get_Notice_Periods_for_Notice_Period_Target_Response;

		public Get_Notice_PeriodsOutput()
		{
		}

		public Get_Notice_PeriodsOutput(Get_Notice_Periods_for_Notice_Period_Target_ResponseType Get_Notice_Periods_for_Notice_Period_Target_Response)
		{
			this.Get_Notice_Periods_for_Notice_Period_Target_Response = Get_Notice_Periods_for_Notice_Period_Target_Response;
		}
	}
}
