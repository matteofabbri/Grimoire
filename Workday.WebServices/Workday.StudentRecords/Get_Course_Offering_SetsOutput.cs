using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Course_Offering_SetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Course_Offering_Sets_ResponseType Get_Course_Offering_Sets_Response;

		public Get_Course_Offering_SetsOutput()
		{
		}

		public Get_Course_Offering_SetsOutput(Get_Course_Offering_Sets_ResponseType Get_Course_Offering_Sets_Response)
		{
			this.Get_Course_Offering_Sets_Response = Get_Course_Offering_Sets_Response;
		}
	}
}
