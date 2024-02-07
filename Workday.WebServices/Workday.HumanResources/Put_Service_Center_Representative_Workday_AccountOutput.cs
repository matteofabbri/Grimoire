using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Service_Center_Representative_Workday_AccountOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Service_Center_Representative_Workday_Account_ResponseType Put_Service_Center_Representative_Workday_Account_Response;

		public Put_Service_Center_Representative_Workday_AccountOutput()
		{
		}

		public Put_Service_Center_Representative_Workday_AccountOutput(Put_Service_Center_Representative_Workday_Account_ResponseType Put_Service_Center_Representative_Workday_Account_Response)
		{
			this.Put_Service_Center_Representative_Workday_Account_Response = Put_Service_Center_Representative_Workday_Account_Response;
		}
	}
}
