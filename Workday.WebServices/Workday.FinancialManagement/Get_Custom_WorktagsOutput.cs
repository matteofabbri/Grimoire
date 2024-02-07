using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Custom_WorktagsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Custom_Worktags_ResponseType Get_Custom_Worktags_Response;

		public Get_Custom_WorktagsOutput()
		{
		}

		public Get_Custom_WorktagsOutput(Get_Custom_Worktags_ResponseType Get_Custom_Worktags_Response)
		{
			this.Get_Custom_Worktags_Response = Get_Custom_Worktags_Response;
		}
	}
}
