using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_ChargesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Charges_ResponseType Get_Student_Charges_Response;

		public Get_Student_ChargesOutput()
		{
		}

		public Get_Student_ChargesOutput(Get_Student_Charges_ResponseType Get_Student_Charges_Response)
		{
			this.Get_Student_Charges_Response = Get_Student_Charges_Response;
		}
	}
}
