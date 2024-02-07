using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Internal_CatalogsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Internal_Catalogs_ResponseType Get_Internal_Catalogs_Response;

		public Get_Internal_CatalogsOutput()
		{
		}

		public Get_Internal_CatalogsOutput(Get_Internal_Catalogs_ResponseType Get_Internal_Catalogs_Response)
		{
			this.Get_Internal_Catalogs_Response = Get_Internal_Catalogs_Response;
		}
	}
}
