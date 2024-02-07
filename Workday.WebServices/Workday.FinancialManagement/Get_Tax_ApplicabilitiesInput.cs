using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_ApplicabilitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Applicabilities_RequestType Get_Tax_Applicabilities_Request;

		public Get_Tax_ApplicabilitiesInput()
		{
		}

		public Get_Tax_ApplicabilitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Applicabilities_RequestType Get_Tax_Applicabilities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Tax_Applicabilities_Request = Get_Tax_Applicabilities_Request;
		}
	}
}
