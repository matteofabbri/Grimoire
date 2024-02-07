using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Activity_Registration_RecordsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Activity_Registration_Records_ResponseType Get_Student_Activity_Registration_Records_Response;

		public Get_Student_Activity_Registration_RecordsOutput()
		{
		}

		public Get_Student_Activity_Registration_RecordsOutput(Get_Student_Activity_Registration_Records_ResponseType Get_Student_Activity_Registration_Records_Response)
		{
			this.Get_Student_Activity_Registration_Records_Response = Get_Student_Activity_Registration_Records_Response;
		}
	}
}
