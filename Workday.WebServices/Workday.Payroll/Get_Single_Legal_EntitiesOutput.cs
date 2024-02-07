using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Single_Legal_EntitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Single_Legal_Entities_ResponseType Get_Single_Legal_Entities_Response;

		public Get_Single_Legal_EntitiesOutput()
		{
		}

		public Get_Single_Legal_EntitiesOutput(Get_Single_Legal_Entities_ResponseType Get_Single_Legal_Entities_Response)
		{
			this.Get_Single_Legal_Entities_Response = Get_Single_Legal_Entities_Response;
		}
	}
}
