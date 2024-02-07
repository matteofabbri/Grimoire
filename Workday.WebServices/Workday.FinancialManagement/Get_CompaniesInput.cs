using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CompaniesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Companies_RequestType Get_Companies_Request;

		public Get_CompaniesInput()
		{
		}

		public Get_CompaniesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Companies_RequestType Get_Companies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Companies_Request = Get_Companies_Request;
		}
	}
}
