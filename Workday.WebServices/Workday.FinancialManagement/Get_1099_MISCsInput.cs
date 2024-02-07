using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_1099_MISCsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_1099_Miscs_RequestType Get_1099_Miscs_Request;

		public Get_1099_MISCsInput()
		{
		}

		public Get_1099_MISCsInput(Workday_Common_HeaderType Workday_Common_Header, Get_1099_Miscs_RequestType Get_1099_Miscs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_1099_Miscs_Request = Get_1099_Miscs_Request;
		}
	}
}
