using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Personnel_ResponsibilitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Personnel_Responsibilities_ResponseType Get_Award_Personnel_Responsibilities_Response;

		public Get_Award_Personnel_ResponsibilitiesOutput()
		{
		}

		public Get_Award_Personnel_ResponsibilitiesOutput(Get_Award_Personnel_Responsibilities_ResponseType Get_Award_Personnel_Responsibilities_Response)
		{
			this.Get_Award_Personnel_Responsibilities_Response = Get_Award_Personnel_Responsibilities_Response;
		}
	}
}
