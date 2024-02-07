using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Related_Worktags_for_WorktagOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Related_Worktags_for_Worktag_ResponseType Put_Related_Worktags_for_Worktag_Response;

		public Put_Related_Worktags_for_WorktagOutput()
		{
		}

		public Put_Related_Worktags_for_WorktagOutput(Put_Related_Worktags_for_Worktag_ResponseType Put_Related_Worktags_for_Worktag_Response)
		{
			this.Put_Related_Worktags_for_Worktag_Response = Put_Related_Worktags_for_Worktag_Response;
		}
	}
}
