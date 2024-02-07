using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Government_IDsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Government_IDs_ResponseType Change_Government_IDs_Response;

		public Change_Government_IDsOutput()
		{
		}

		public Change_Government_IDsOutput(Change_Government_IDs_ResponseType Change_Government_IDs_Response)
		{
			this.Change_Government_IDs_Response = Change_Government_IDs_Response;
		}
	}
}
