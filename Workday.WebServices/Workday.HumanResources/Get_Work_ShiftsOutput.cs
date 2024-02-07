using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_ShiftsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Shifts_ResponseType Get_Work_Shifts_Response;

		public Get_Work_ShiftsOutput()
		{
		}

		public Get_Work_ShiftsOutput(Get_Work_Shifts_ResponseType Get_Work_Shifts_Response)
		{
			this.Get_Work_Shifts_Response = Get_Work_Shifts_Response;
		}
	}
}
