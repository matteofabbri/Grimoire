using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Study_Abroad_OfferingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Study_Abroad_Offering_ResponseType Put_Study_Abroad_Offering_Response;

		public Put_Study_Abroad_OfferingOutput()
		{
		}

		public Put_Study_Abroad_OfferingOutput(Put_Study_Abroad_Offering_ResponseType Put_Study_Abroad_Offering_Response)
		{
			this.Put_Study_Abroad_Offering_Response = Put_Study_Abroad_Offering_Response;
		}
	}
}
