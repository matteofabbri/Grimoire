using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Former_Worker_DocumentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Former_Worker_Document_ResponseType Put_Former_Worker_Document_Response;

		public Put_Former_Worker_DocumentOutput()
		{
		}

		public Put_Former_Worker_DocumentOutput(Put_Former_Worker_Document_ResponseType Put_Former_Worker_Document_Response)
		{
			this.Put_Former_Worker_Document_Response = Put_Former_Worker_Document_Response;
		}
	}
}
