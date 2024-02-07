using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_AccountOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Account_ResponseType Get_Workday_Account_Response;

		public Get_Workday_AccountOutput()
		{
		}

		public Get_Workday_AccountOutput(Get_Workday_Account_ResponseType Get_Workday_Account_Response)
		{
			this.Get_Workday_Account_Response = Get_Workday_Account_Response;
		}
	}
}
