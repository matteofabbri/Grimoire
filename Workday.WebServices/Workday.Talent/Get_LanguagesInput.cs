using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LanguagesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Languages_RequestType Get_Languages_Request;

		public Get_LanguagesInput()
		{
		}

		public Get_LanguagesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Languages_RequestType Get_Languages_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Languages_Request = Get_Languages_Request;
		}
	}
}
