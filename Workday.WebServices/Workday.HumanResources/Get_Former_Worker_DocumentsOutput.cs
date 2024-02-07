using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Former_Worker_DocumentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Former_Worker_Documents_ResponseType Get_Former_Worker_Documents_Response;

		public Get_Former_Worker_DocumentsOutput()
		{
		}

		public Get_Former_Worker_DocumentsOutput(Get_Former_Worker_Documents_ResponseType Get_Former_Worker_Documents_Response)
		{
			this.Get_Former_Worker_Documents_Response = Get_Former_Worker_Documents_Response;
		}
	}
}
