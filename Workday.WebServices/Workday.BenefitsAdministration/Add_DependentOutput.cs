using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_DependentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Dependent_ResponseType Add_Dependent_Response;

		public Add_DependentOutput()
		{
		}

		public Add_DependentOutput(Add_Dependent_ResponseType Add_Dependent_Response)
		{
			this.Add_Dependent_Response = Add_Dependent_Response;
		}
	}
}
