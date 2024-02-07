using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AirportsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Airports_RequestType Get_Airports_Request;

		public Get_AirportsInput()
		{
		}

		public Get_AirportsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Airports_RequestType Get_Airports_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Airports_Request = Get_Airports_Request;
		}
	}
}
