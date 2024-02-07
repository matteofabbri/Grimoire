using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_DependentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Dependent_ResponseType Edit_Dependent_Response;

		public Edit_DependentOutput()
		{
		}

		public Edit_DependentOutput(Edit_Dependent_ResponseType Edit_Dependent_Response)
		{
			this.Edit_Dependent_Response = Edit_Dependent_Response;
		}
	}
}
