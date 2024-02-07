using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Absence_InputOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Absence_Input_ResponseType Put_Absence_Input_Response;

		public Put_Absence_InputOutput()
		{
		}

		public Put_Absence_InputOutput(Put_Absence_Input_ResponseType Put_Absence_Input_Response)
		{
			this.Put_Absence_Input_Response = Put_Absence_Input_Response;
		}
	}
}
