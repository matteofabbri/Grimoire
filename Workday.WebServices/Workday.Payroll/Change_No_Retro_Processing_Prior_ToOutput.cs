using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_No_Retro_Processing_Prior_ToOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_No_Retro_Processing_Prior_To_ResponseType Change_No_Retro_Processing_Prior_To_Response;

		public Change_No_Retro_Processing_Prior_ToOutput()
		{
		}

		public Change_No_Retro_Processing_Prior_ToOutput(Change_No_Retro_Processing_Prior_To_ResponseType Change_No_Retro_Processing_Prior_To_Response)
		{
			this.Change_No_Retro_Processing_Prior_To_Response = Change_No_Retro_Processing_Prior_To_Response;
		}
	}
}
