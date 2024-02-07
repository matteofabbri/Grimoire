using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Service_Center_Representative_Workday_AccountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Service_Center_Representative_Workday_Accounts_ResponseType Get_Service_Center_Representative_Workday_Accounts_Response;

		public Get_Service_Center_Representative_Workday_AccountsOutput()
		{
		}

		public Get_Service_Center_Representative_Workday_AccountsOutput(Get_Service_Center_Representative_Workday_Accounts_ResponseType Get_Service_Center_Representative_Workday_Accounts_Response)
		{
			this.Get_Service_Center_Representative_Workday_Accounts_Response = Get_Service_Center_Representative_Workday_Accounts_Response;
		}
	}
}
