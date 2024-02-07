using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Catalog_LoadOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Catalog_Load_ResponseType Submit_Catalog_Load_Response;

		public Submit_Catalog_LoadOutput()
		{
		}

		public Submit_Catalog_LoadOutput(Submit_Catalog_Load_ResponseType Submit_Catalog_Load_Response)
		{
			this.Submit_Catalog_Load_Response = Submit_Catalog_Load_Response;
		}
	}
}
