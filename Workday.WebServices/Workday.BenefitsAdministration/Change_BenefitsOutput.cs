using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_BenefitsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Benefits_ResponseType Change_Benefits_Response;

		public Change_BenefitsOutput()
		{
		}

		public Change_BenefitsOutput(Change_Benefits_ResponseType Change_Benefits_Response)
		{
			this.Change_Benefits_Response = Change_Benefits_Response;
		}
	}
}
