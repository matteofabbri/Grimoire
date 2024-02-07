using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Financial_Aid_PackagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Financial_Aid_Packages_ResponseType Get_Financial_Aid_Packages_Response;

		public Get_Financial_Aid_PackagesOutput()
		{
		}

		public Get_Financial_Aid_PackagesOutput(Get_Financial_Aid_Packages_ResponseType Get_Financial_Aid_Packages_Response)
		{
			this.Get_Financial_Aid_Packages_Response = Get_Financial_Aid_Packages_Response;
		}
	}
}
