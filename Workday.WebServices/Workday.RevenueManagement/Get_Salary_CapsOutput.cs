using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Salary_CapsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Salary_Caps_ResponseType Get_Salary_Caps_Response;

		public Get_Salary_CapsOutput()
		{
		}

		public Get_Salary_CapsOutput(Get_Salary_Caps_ResponseType Get_Salary_Caps_Response)
		{
			this.Get_Salary_Caps_Response = Get_Salary_Caps_Response;
		}
	}
}
