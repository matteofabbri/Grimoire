using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LGBT_IdentificationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_LGBT_Identifications_ResponseType Get_LGBT_Identifications_Response;

		public Get_LGBT_IdentificationsOutput()
		{
		}

		public Get_LGBT_IdentificationsOutput(Get_LGBT_Identifications_ResponseType Get_LGBT_Identifications_Response)
		{
			this.Get_LGBT_Identifications_Response = Get_LGBT_Identifications_Response;
		}
	}
}
