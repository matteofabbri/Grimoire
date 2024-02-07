using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Override_BalancesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Override_Balances_ResponseType Get_Override_Balances_Response;

		public Get_Override_BalancesOutput()
		{
		}

		public Get_Override_BalancesOutput(Get_Override_Balances_ResponseType Get_Override_Balances_Response)
		{
			this.Get_Override_Balances_Response = Get_Override_Balances_Response;
		}
	}
}
