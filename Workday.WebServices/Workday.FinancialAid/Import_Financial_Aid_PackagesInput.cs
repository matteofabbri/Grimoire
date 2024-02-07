using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Financial_Aid_PackagesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Financial_Aid_Package_RequestType Import_Financial_Aid_Package_Request;

		public Import_Financial_Aid_PackagesInput()
		{
		}

		public Import_Financial_Aid_PackagesInput(Workday_Common_HeaderType Workday_Common_Header, Import_Financial_Aid_Package_RequestType Import_Financial_Aid_Package_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Financial_Aid_Package_Request = Import_Financial_Aid_Package_Request;
		}
	}
}
