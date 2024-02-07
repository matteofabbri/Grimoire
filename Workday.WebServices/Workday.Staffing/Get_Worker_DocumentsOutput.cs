using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_DocumentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Worker_Documents_ResponseType Get_Worker_Documents_Response;

		public Get_Worker_DocumentsOutput()
		{
		}

		public Get_Worker_DocumentsOutput(Get_Worker_Documents_ResponseType Get_Worker_Documents_Response)
		{
			this.Get_Worker_Documents_Response = Get_Worker_Documents_Response;
		}
	}
}
