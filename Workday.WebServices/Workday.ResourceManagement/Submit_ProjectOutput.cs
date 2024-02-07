using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_ProjectOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Project_ResponseType Submit_Project_Response;

		public Submit_ProjectOutput()
		{
		}

		public Submit_ProjectOutput(Submit_Project_ResponseType Submit_Project_Response)
		{
			this.Submit_Project_Response = Submit_Project_Response;
		}
	}
}
