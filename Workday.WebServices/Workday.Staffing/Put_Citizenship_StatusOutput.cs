using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Citizenship_StatusOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Citizenship_Status_ResponseType Put_Citizenship_Status_Response;

		public Put_Citizenship_StatusOutput()
		{
		}

		public Put_Citizenship_StatusOutput(Put_Citizenship_Status_ResponseType Put_Citizenship_Status_Response)
		{
			this.Put_Citizenship_Status_Response = Put_Citizenship_Status_Response;
		}
	}
}
