using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ManufacturerOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Manufacturer_ResponseType Put_Manufacturer_Response;

		public Put_ManufacturerOutput()
		{
		}

		public Put_ManufacturerOutput(Put_Manufacturer_ResponseType Put_Manufacturer_Response)
		{
			this.Put_Manufacturer_Response = Put_Manufacturer_Response;
		}
	}
}
