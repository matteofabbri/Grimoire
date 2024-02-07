using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_Worktag_Mapping_Source_SystemOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_Worktag_Mapping_Source_System_ResponseType Put_Integration_Worktag_Mapping_Source_System_Response;

		public Put_Integration_Worktag_Mapping_Source_SystemOutput()
		{
		}

		public Put_Integration_Worktag_Mapping_Source_SystemOutput(Put_Integration_Worktag_Mapping_Source_System_ResponseType Put_Integration_Worktag_Mapping_Source_System_Response)
		{
			this.Put_Integration_Worktag_Mapping_Source_System_Response = Put_Integration_Worktag_Mapping_Source_System_Response;
		}
	}
}
