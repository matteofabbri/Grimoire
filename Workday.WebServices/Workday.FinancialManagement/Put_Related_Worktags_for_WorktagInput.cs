using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Related_Worktags_for_WorktagInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Related_Worktags_for_Worktag_RequestType Put_Related_Worktags_for_Worktag_Request;

		public Put_Related_Worktags_for_WorktagInput()
		{
		}

		public Put_Related_Worktags_for_WorktagInput(Workday_Common_HeaderType Workday_Common_Header, Put_Related_Worktags_for_Worktag_RequestType Put_Related_Worktags_for_Worktag_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Related_Worktags_for_Worktag_Request = Put_Related_Worktags_for_Worktag_Request;
		}
	}
}
