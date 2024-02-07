using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Absence_InputsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Absence_Inputs_ResponseType Get_Absence_Inputs_Response;

		public Get_Absence_InputsOutput()
		{
		}

		public Get_Absence_InputsOutput(Get_Absence_Inputs_ResponseType Get_Absence_Inputs_Response)
		{
			this.Get_Absence_Inputs_Response = Get_Absence_Inputs_Response;
		}
	}
}
