using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Integration_Worktag_Mapping_Source_SystemsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Integration_Worktag_Mapping_Source_Systems_RequestType Get_Integration_Worktag_Mapping_Source_Systems_Request;

		public Get_Integration_Worktag_Mapping_Source_SystemsInput()
		{
		}

		public Get_Integration_Worktag_Mapping_Source_SystemsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Integration_Worktag_Mapping_Source_Systems_RequestType Get_Integration_Worktag_Mapping_Source_Systems_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Integration_Worktag_Mapping_Source_Systems_Request = Get_Integration_Worktag_Mapping_Source_Systems_Request;
		}
	}
}
