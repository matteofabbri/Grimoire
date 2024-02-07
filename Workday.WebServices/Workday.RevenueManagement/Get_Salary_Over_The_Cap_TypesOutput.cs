using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Salary_Over_The_Cap_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Salary_Over_The_Cap_Types_ResponseType Get_Salary_Over_The_Cap_Types_Response;

		public Get_Salary_Over_The_Cap_TypesOutput()
		{
		}

		public Get_Salary_Over_The_Cap_TypesOutput(Get_Salary_Over_The_Cap_Types_ResponseType Get_Salary_Over_The_Cap_Types_Response)
		{
			this.Get_Salary_Over_The_Cap_Types_Response = Get_Salary_Over_The_Cap_Types_Response;
		}
	}
}
