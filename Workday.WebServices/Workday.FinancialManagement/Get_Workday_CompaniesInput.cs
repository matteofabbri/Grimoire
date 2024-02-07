using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Workday_CompaniesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workday_Companies_RequestType Get_Workday_Companies_Request;

		public Get_Workday_CompaniesInput()
		{
		}

		public Get_Workday_CompaniesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Workday_Companies_RequestType Get_Workday_Companies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Workday_Companies_Request = Get_Workday_Companies_Request;
		}
	}
}
