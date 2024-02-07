using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Salary_CapOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Salary_Cap_ResponseType Put_Salary_Cap_Response;

		public Put_Salary_CapOutput()
		{
		}

		public Put_Salary_CapOutput(Put_Salary_Cap_ResponseType Put_Salary_Cap_Response)
		{
			this.Put_Salary_Cap_Response = Put_Salary_Cap_Response;
		}
	}
}
