using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Catalog_ItemsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Catalog_Items_ResponseType Get_Catalog_Items_Response;

		public Get_Catalog_ItemsOutput()
		{
		}

		public Get_Catalog_ItemsOutput(Get_Catalog_Items_ResponseType Get_Catalog_Items_Response)
		{
			this.Get_Catalog_Items_Response = Get_Catalog_Items_Response;
		}
	}
}
