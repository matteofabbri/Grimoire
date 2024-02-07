using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Personnel_ResponsibilityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Personnel_Responsibility_ResponseType Put_Award_Personnel_Responsibility_Response;

		public Put_Award_Personnel_ResponsibilityOutput()
		{
		}

		public Put_Award_Personnel_ResponsibilityOutput(Put_Award_Personnel_Responsibility_ResponseType Put_Award_Personnel_Responsibility_Response)
		{
			this.Put_Award_Personnel_Responsibility_Response = Put_Award_Personnel_Responsibility_Response;
		}
	}
}
