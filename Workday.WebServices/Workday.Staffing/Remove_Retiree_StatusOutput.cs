using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Remove_Retiree_StatusOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Remove_Retiree_Status_ResponseType Remove_Retiree_Status_Response;

		public Remove_Retiree_StatusOutput()
		{
		}

		public Remove_Retiree_StatusOutput(Remove_Retiree_Status_ResponseType Remove_Retiree_Status_Response)
		{
			this.Remove_Retiree_Status_Response = Remove_Retiree_Status_Response;
		}
	}
}
