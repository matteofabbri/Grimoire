using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Orientation_OfferingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Orientation_Offerings_RequestType Get_Orientation_Offerings_Request;

		public Get_Orientation_OfferingsInput()
		{
		}

		public Get_Orientation_OfferingsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Orientation_Offerings_RequestType Get_Orientation_Offerings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Orientation_Offerings_Request = Get_Orientation_Offerings_Request;
		}
	}
}
