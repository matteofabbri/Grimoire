using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Work_ShiftOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Work_Shift_ResponseType Put_Work_Shift_Response;

		public Put_Work_ShiftOutput()
		{
		}

		public Put_Work_ShiftOutput(Put_Work_Shift_ResponseType Put_Work_Shift_Response)
		{
			this.Put_Work_Shift_Response = Put_Work_Shift_Response;
		}
	}
}
