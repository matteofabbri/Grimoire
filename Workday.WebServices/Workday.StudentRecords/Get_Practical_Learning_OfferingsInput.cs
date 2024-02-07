using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Practical_Learning_OfferingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Practical_Learning_Offerings_RequestType Get_Practical_Learning_Offerings_Request;

		public Get_Practical_Learning_OfferingsInput()
		{
		}

		public Get_Practical_Learning_OfferingsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Practical_Learning_Offerings_RequestType Get_Practical_Learning_Offerings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Practical_Learning_Offerings_Request = Get_Practical_Learning_Offerings_Request;
		}
	}
}
