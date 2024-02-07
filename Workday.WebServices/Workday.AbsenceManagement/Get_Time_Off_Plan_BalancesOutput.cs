using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Time_Off_Plan_BalancesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Time_Off_Plan_Balances_ResponseType Get_Time_Off_Plan_Balances_Response;

		public Get_Time_Off_Plan_BalancesOutput()
		{
		}

		public Get_Time_Off_Plan_BalancesOutput(Get_Time_Off_Plan_Balances_ResponseType Get_Time_Off_Plan_Balances_Response)
		{
			this.Get_Time_Off_Plan_Balances_Response = Get_Time_Off_Plan_Balances_Response;
		}
	}
}
