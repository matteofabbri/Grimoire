using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ManufacturerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Manufacturer_RequestType Put_Manufacturer_Request;

		public Put_ManufacturerInput()
		{
		}

		public Put_ManufacturerInput(Workday_Common_HeaderType Workday_Common_Header, Put_Manufacturer_RequestType Put_Manufacturer_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Manufacturer_Request = Put_Manufacturer_Request;
		}
	}
}
