using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Worker_DocumentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Worker_Document_ResponseType Put_Worker_Document_Response;

		public Put_Worker_DocumentOutput()
		{
		}

		public Put_Worker_DocumentOutput(Put_Worker_Document_ResponseType Put_Worker_Document_Response)
		{
			this.Put_Worker_Document_Response = Put_Worker_Document_Response;
		}
	}
}
