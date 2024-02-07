using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PronounsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Pronouns_RequestType Get_Pronouns_Request;

		public Get_PronounsInput()
		{
		}

		public Get_PronounsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Pronouns_RequestType Get_Pronouns_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Pronouns_Request = Get_Pronouns_Request;
		}
	}
}
