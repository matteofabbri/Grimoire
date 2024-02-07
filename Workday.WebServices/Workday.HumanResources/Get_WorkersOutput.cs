using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_WorkersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Workers_ResponseRootType Get_Workers_Response;

		public Get_WorkersOutput()
		{
		}

		public Get_WorkersOutput(Get_Workers_ResponseRootType Get_Workers_Response)
		{
			this.Get_Workers_Response = Get_Workers_Response;
		}
	}
}
