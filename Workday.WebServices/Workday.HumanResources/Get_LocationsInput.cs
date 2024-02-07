using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LocationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Locations_RequestType Get_Locations_Request;

		public Get_LocationsInput()
		{
		}

		public Get_LocationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Locations_RequestType Get_Locations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Locations_Request = Get_Locations_Request;
		}
	}
}
