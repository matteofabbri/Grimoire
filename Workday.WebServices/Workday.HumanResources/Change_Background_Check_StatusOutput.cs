using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Background_Check_StatusOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Background_Check_Status_ResponseType Change_Background_Check_Status_Response;

		public Change_Background_Check_StatusOutput()
		{
		}

		public Change_Background_Check_StatusOutput(Change_Background_Check_Status_ResponseType Change_Background_Check_Status_Response)
		{
			this.Change_Background_Check_Status_Response = Change_Background_Check_Status_Response;
		}
	}
}
