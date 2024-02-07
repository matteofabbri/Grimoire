using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_Worktag_MappingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_Worktag_Mapping_ResponseType Put_Integration_Worktag_Mapping_Response;

		public Put_Integration_Worktag_MappingOutput()
		{
		}

		public Put_Integration_Worktag_MappingOutput(Put_Integration_Worktag_Mapping_ResponseType Put_Integration_Worktag_Mapping_Response)
		{
			this.Put_Integration_Worktag_Mapping_Response = Put_Integration_Worktag_Mapping_Response;
		}
	}
}
