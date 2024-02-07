using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Resource_PlansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Resource_Plans_ResponseType Get_Resource_Plans_Response;

		public Get_Resource_PlansOutput()
		{
		}

		public Get_Resource_PlansOutput(Get_Resource_Plans_ResponseType Get_Resource_Plans_Response)
		{
			this.Get_Resource_Plans_Response = Get_Resource_Plans_Response;
		}
	}
}
