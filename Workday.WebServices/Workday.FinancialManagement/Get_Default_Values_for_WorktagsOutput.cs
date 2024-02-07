using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Default_Values_for_WorktagsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Default_Values_for_Worktags_ResponseType Get_Default_Values_for_Worktags_Response;

		public Get_Default_Values_for_WorktagsOutput()
		{
		}

		public Get_Default_Values_for_WorktagsOutput(Get_Default_Values_for_Worktags_ResponseType Get_Default_Values_for_Worktags_Response)
		{
			this.Get_Default_Values_for_Worktags_Response = Get_Default_Values_for_Worktags_Response;
		}
	}
}
