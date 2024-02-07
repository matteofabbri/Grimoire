using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Intercompany_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Intercompany_Profile_ResponseType Put_Intercompany_Profile_Response;

		public Put_Intercompany_ProfileOutput()
		{
		}

		public Put_Intercompany_ProfileOutput(Put_Intercompany_Profile_ResponseType Put_Intercompany_Profile_Response)
		{
			this.Put_Intercompany_Profile_Response = Put_Intercompany_Profile_Response;
		}
	}
}
