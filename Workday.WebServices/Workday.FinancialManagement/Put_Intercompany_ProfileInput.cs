using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Intercompany_ProfileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Intercompany_Profile_RequestType Put_Intercompany_Profile_Request;

		public Put_Intercompany_ProfileInput()
		{
		}

		public Put_Intercompany_ProfileInput(Workday_Common_HeaderType Workday_Common_Header, Put_Intercompany_Profile_RequestType Put_Intercompany_Profile_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Intercompany_Profile_Request = Put_Intercompany_Profile_Request;
		}
	}
}
