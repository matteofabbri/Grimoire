using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_Account_SignonsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Account_Signons_ResponseType Get_Workday_Account_Signons_Response;

		public Get_Workday_Account_SignonsOutput()
		{
		}

		public Get_Workday_Account_SignonsOutput(Get_Workday_Account_Signons_ResponseType Get_Workday_Account_Signons_Response)
		{
			this.Get_Workday_Account_Signons_Response = Get_Workday_Account_Signons_Response;
		}
	}
}
