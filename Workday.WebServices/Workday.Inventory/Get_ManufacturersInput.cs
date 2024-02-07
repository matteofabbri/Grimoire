using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ManufacturersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Manufacturers_RequestType Get_Manufacturers_Request;

		public Get_ManufacturersInput()
		{
		}

		public Get_ManufacturersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Manufacturers_RequestType Get_Manufacturers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Manufacturers_Request = Get_Manufacturers_Request;
		}
	}
}
