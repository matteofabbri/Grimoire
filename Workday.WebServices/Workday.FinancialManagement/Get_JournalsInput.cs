using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_JournalsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Journals_RequestType Get_Journals_Request;

		public Get_JournalsInput()
		{
		}

		public Get_JournalsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Journals_RequestType Get_Journals_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Journals_Request = Get_Journals_Request;
		}
	}
}
