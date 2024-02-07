using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Single_Legal_EntityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Single_Legal_Entity_ResponseType Put_Single_Legal_Entity_Response;

		public Put_Single_Legal_EntityOutput()
		{
		}

		public Put_Single_Legal_EntityOutput(Put_Single_Legal_Entity_ResponseType Put_Single_Legal_Entity_Response)
		{
			this.Put_Single_Legal_Entity_Response = Put_Single_Legal_Entity_Response;
		}
	}
}
