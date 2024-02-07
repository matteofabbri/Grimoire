using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_PlansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Plans_ResponseType Get_Project_Plans_Response;

		public Get_Project_PlansOutput()
		{
		}

		public Get_Project_PlansOutput(Get_Project_Plans_ResponseType Get_Project_Plans_Response)
		{
			this.Get_Project_Plans_Response = Get_Project_Plans_Response;
		}
	}
}
