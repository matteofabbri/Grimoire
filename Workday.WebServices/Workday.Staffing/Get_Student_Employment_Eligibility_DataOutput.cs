using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Employment_Eligibility_DataOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Employment_Eligibility_Data_ResponseType Get_Student_Employment_Eligibility_Data_Response;

		public Get_Student_Employment_Eligibility_DataOutput()
		{
		}

		public Get_Student_Employment_Eligibility_DataOutput(Get_Student_Employment_Eligibility_Data_ResponseType Get_Student_Employment_Eligibility_Data_Response)
		{
			this.Get_Student_Employment_Eligibility_Data_Response = Get_Student_Employment_Eligibility_Data_Response;
		}
	}
}
