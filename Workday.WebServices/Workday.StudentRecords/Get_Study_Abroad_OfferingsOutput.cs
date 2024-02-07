using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Study_Abroad_OfferingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Study_Abroad_Offerings_ResponseType Get_Study_Abroad_Offerings_Response;

		public Get_Study_Abroad_OfferingsOutput()
		{
		}

		public Get_Study_Abroad_OfferingsOutput(Get_Study_Abroad_Offerings_ResponseType Get_Study_Abroad_Offerings_Response)
		{
			this.Get_Study_Abroad_Offerings_Response = Get_Study_Abroad_Offerings_Response;
		}
	}
}
