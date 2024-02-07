using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Time_Off_Plan_BalancesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Time_Off_Plan_Balances_RequestType Get_Time_Off_Plan_Balances_Request;

		public Get_Time_Off_Plan_BalancesInput()
		{
		}

		public Get_Time_Off_Plan_BalancesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Time_Off_Plan_Balances_RequestType Get_Time_Off_Plan_Balances_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Time_Off_Plan_Balances_Request = Get_Time_Off_Plan_Balances_Request;
		}
	}
}
