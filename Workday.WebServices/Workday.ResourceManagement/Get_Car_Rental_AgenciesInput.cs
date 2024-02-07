using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Car_Rental_AgenciesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Car_Rental_Agencies_RequestType Get_Car_Rental_Agencies_Request;

		public Get_Car_Rental_AgenciesInput()
		{
		}

		public Get_Car_Rental_AgenciesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Car_Rental_Agencies_RequestType Get_Car_Rental_Agencies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Car_Rental_Agencies_Request = Get_Car_Rental_Agencies_Request;
		}
	}
}
