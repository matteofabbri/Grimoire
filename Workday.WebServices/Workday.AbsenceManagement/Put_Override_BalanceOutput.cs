using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Override_BalanceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Override_Balance_ResponseType Put_Override_Balance_Response;

		public Put_Override_BalanceOutput()
		{
		}

		public Put_Override_BalanceOutput(Put_Override_Balance_ResponseType Put_Override_Balance_Response)
		{
			this.Put_Override_Balance_Response = Put_Override_Balance_Response;
		}
	}
}
