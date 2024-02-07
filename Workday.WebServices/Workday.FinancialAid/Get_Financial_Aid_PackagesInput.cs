using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Financial_Aid_PackagesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Financial_Aid_Packages_RequestType Get_Financial_Aid_Packages_Request;

		public Get_Financial_Aid_PackagesInput()
		{
		}

		public Get_Financial_Aid_PackagesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Financial_Aid_Packages_RequestType Get_Financial_Aid_Packages_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Financial_Aid_Packages_Request = Get_Financial_Aid_Packages_Request;
		}
	}
}
