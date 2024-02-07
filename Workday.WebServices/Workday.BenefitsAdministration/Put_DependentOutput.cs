using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_DependentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Dependent_ResponseType Put_Dependent_Response;

		public Put_DependentOutput()
		{
		}

		public Put_DependentOutput(Put_Dependent_ResponseType Put_Dependent_Response)
		{
			this.Put_Dependent_Response = Put_Dependent_Response;
		}
	}
}
