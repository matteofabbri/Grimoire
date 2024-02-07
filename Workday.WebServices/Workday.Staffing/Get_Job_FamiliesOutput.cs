using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_FamiliesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Families_ResponseType Get_Job_Families_Response;

		public Get_Job_FamiliesOutput()
		{
		}

		public Get_Job_FamiliesOutput(Get_Job_Families_ResponseType Get_Job_Families_Response)
		{
			this.Get_Job_Families_Response = Get_Job_Families_Response;
		}
	}
}
