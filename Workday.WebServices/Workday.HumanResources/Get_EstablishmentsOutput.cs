using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_EstablishmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Establishments_ResponseType Get_Establishments_Response;

		public Get_EstablishmentsOutput()
		{
		}

		public Get_EstablishmentsOutput(Get_Establishments_ResponseType Get_Establishments_Response)
		{
			this.Get_Establishments_Response = Get_Establishments_Response;
		}
	}
}
