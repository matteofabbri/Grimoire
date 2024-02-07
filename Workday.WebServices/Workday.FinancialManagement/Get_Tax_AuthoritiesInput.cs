using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Tax_AuthoritiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Authorities_RequestType Get_Tax_Authorities_Request;

		public Get_Tax_AuthoritiesInput()
		{
		}

		public Get_Tax_AuthoritiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Tax_Authorities_RequestType Get_Tax_Authorities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Tax_Authorities_Request = Get_Tax_Authorities_Request;
		}
	}
}
