using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Catalog_LoadsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Catalog_Loads_ResponseType Get_Catalog_Loads_Response;

		public Get_Catalog_LoadsOutput()
		{
		}

		public Get_Catalog_LoadsOutput(Get_Catalog_Loads_ResponseType Get_Catalog_Loads_Response)
		{
			this.Get_Catalog_Loads_Response = Get_Catalog_Loads_Response;
		}
	}
}
