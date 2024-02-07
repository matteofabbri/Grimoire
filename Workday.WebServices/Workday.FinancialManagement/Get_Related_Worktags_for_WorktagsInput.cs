using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Related_Worktags_for_WorktagsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Related_Worktags_for_Worktags_RequestType Get_Related_Worktags_for_Worktags_Request;

		public Get_Related_Worktags_for_WorktagsInput()
		{
		}

		public Get_Related_Worktags_for_WorktagsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Related_Worktags_for_Worktags_RequestType Get_Related_Worktags_for_Worktags_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Related_Worktags_for_Worktags_Request = Get_Related_Worktags_for_Worktags_Request;
		}
	}
}
