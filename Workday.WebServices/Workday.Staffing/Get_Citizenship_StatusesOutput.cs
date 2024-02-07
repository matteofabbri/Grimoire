using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Citizenship_StatusesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Citizenship_Statuses_ResponseType Get_Citizenship_Statuses_Response;

		public Get_Citizenship_StatusesOutput()
		{
		}

		public Get_Citizenship_StatusesOutput(Get_Citizenship_Statuses_ResponseType Get_Citizenship_Statuses_Response)
		{
			this.Get_Citizenship_Statuses_Response = Get_Citizenship_Statuses_Response;
		}
	}
}
