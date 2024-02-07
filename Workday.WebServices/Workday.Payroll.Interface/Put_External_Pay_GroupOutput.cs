using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Pay_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Pay_Group_ResponseType Put_External_Pay_Group_Response;

		public Put_External_Pay_GroupOutput()
		{
		}

		public Put_External_Pay_GroupOutput(Put_External_Pay_Group_ResponseType Put_External_Pay_Group_Response)
		{
			this.Put_External_Pay_Group_Response = Put_External_Pay_Group_Response;
		}
	}
}
