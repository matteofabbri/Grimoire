using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Transfer_Asset_To_Different_CompanyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Transfer_Asset_To_Different_Company_ResponseType Transfer_Asset_To_Different_Company_Response;

		public Transfer_Asset_To_Different_CompanyOutput()
		{
		}

		public Transfer_Asset_To_Different_CompanyOutput(Transfer_Asset_To_Different_Company_ResponseType Transfer_Asset_To_Different_Company_Response)
		{
			this.Transfer_Asset_To_Different_Company_Response = Transfer_Asset_To_Different_Company_Response;
		}
	}
}
