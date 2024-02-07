using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Search_Service_DefinitionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Search_Service_Definitions_ResponseType Get_Search_Service_Definitions_Response;

		public Get_Search_Service_DefinitionsOutput()
		{
		}

		public Get_Search_Service_DefinitionsOutput(Get_Search_Service_Definitions_ResponseType Get_Search_Service_Definitions_Response)
		{
			this.Get_Search_Service_Definitions_Response = Get_Search_Service_Definitions_Response;
		}
	}
}
