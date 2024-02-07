using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Related_Worktags_for_WorktagsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Related_Worktags_for_Worktags_ResponseType Get_Related_Worktags_for_Worktags_Response;

		public Get_Related_Worktags_for_WorktagsOutput()
		{
		}

		public Get_Related_Worktags_for_WorktagsOutput(Get_Related_Worktags_for_Worktags_ResponseType Get_Related_Worktags_for_Worktags_Response)
		{
			this.Get_Related_Worktags_for_Worktags_Response = Get_Related_Worktags_for_Worktags_Response;
		}
	}
}
