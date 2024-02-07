using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_Pay_GroupsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Pay_Groups_ResponseType Get_External_Pay_Groups_Response;

		public Get_External_Pay_GroupsOutput()
		{
		}

		public Get_External_Pay_GroupsOutput(Get_External_Pay_Groups_ResponseType Get_External_Pay_Groups_Response)
		{
			this.Get_External_Pay_Groups_Response = Get_External_Pay_Groups_Response;
		}
	}
}
