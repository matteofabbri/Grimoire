using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Intercompany_ProfilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Intercompany_Profiles_RequestType Get_Intercompany_Profiles_Request;

		public Get_Intercompany_ProfilesInput()
		{
		}

		public Get_Intercompany_ProfilesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Intercompany_Profiles_RequestType Get_Intercompany_Profiles_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Intercompany_Profiles_Request = Get_Intercompany_Profiles_Request;
		}
	}
}
