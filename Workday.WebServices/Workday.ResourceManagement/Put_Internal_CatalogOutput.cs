using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Internal_CatalogOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Internal_Catalog_ResponseType Put_Internal_Catalog_Response;

		public Put_Internal_CatalogOutput()
		{
		}

		public Put_Internal_CatalogOutput(Put_Internal_Catalog_ResponseType Put_Internal_Catalog_Response)
		{
			this.Put_Internal_Catalog_Response = Put_Internal_Catalog_Response;
		}
	}
}
