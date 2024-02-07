using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ManufacturersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Manufacturers_ResponseType Get_Manufacturers_Response;

		public Get_ManufacturersOutput()
		{
		}

		public Get_ManufacturersOutput(Get_Manufacturers_ResponseType Get_Manufacturers_Response)
		{
			this.Get_Manufacturers_Response = Get_Manufacturers_Response;
		}
	}
}
