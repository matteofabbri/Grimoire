using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Car_Rental_AgencyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Car_Rental_Agency_RequestType Put_Car_Rental_Agency_Request;

		public Put_Car_Rental_AgencyInput()
		{
		}

		public Put_Car_Rental_AgencyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Car_Rental_Agency_RequestType Put_Car_Rental_Agency_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Car_Rental_Agency_Request = Put_Car_Rental_Agency_Request;
		}
	}
}
