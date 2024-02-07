using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Headcount_PlanInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Headcount_Plan_RequestType Get_Headcount_Plan_Request;

		public Get_Headcount_PlanInput()
		{
		}

		public Get_Headcount_PlanInput(Workday_Common_HeaderType Workday_Common_Header, Get_Headcount_Plan_RequestType Get_Headcount_Plan_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Headcount_Plan_Request = Get_Headcount_Plan_Request;
		}
	}
}
