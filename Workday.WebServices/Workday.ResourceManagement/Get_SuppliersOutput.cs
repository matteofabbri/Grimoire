using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SuppliersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Suppliers_ResponseType Get_Suppliers_Response;

		public Get_SuppliersOutput()
		{
		}

		public Get_SuppliersOutput(Get_Suppliers_ResponseType Get_Suppliers_Response)
		{
			this.Get_Suppliers_Response = Get_Suppliers_Response;
		}
	}
}
