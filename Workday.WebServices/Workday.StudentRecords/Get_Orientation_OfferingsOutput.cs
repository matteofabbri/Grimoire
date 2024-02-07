using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Orientation_OfferingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Orientation_Offerings_ResponseType Get_Orientation_Offerings_Response;

		public Get_Orientation_OfferingsOutput()
		{
		}

		public Get_Orientation_OfferingsOutput(Get_Orientation_Offerings_ResponseType Get_Orientation_Offerings_Response)
		{
			this.Get_Orientation_Offerings_Response = Get_Orientation_Offerings_Response;
		}
	}
}
