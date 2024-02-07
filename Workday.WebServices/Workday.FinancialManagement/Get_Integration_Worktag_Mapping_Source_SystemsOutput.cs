using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Integration_Worktag_Mapping_Source_SystemsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Integration_Worktag_Mapping_Source_Systems_ResponseType Get_Integration_Worktag_Mapping_Source_Systems_Response;

		public Get_Integration_Worktag_Mapping_Source_SystemsOutput()
		{
		}

		public Get_Integration_Worktag_Mapping_Source_SystemsOutput(Get_Integration_Worktag_Mapping_Source_Systems_ResponseType Get_Integration_Worktag_Mapping_Source_Systems_Response)
		{
			this.Get_Integration_Worktag_Mapping_Source_Systems_Response = Get_Integration_Worktag_Mapping_Source_Systems_Response;
		}
	}
}
