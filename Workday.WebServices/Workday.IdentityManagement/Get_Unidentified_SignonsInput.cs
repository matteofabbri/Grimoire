using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Unidentified_SignonsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Unidentified_Signons_RequestType Get_Unidentified_Signons_Request;

		public Get_Unidentified_SignonsInput()
		{
		}

		public Get_Unidentified_SignonsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Unidentified_Signons_RequestType Get_Unidentified_Signons_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Unidentified_Signons_Request = Get_Unidentified_Signons_Request;
		}
	}
}
