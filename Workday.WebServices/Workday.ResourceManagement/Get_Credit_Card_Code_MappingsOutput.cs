using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Credit_Card_Code_MappingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Credit_Card_Code_Mappings_ResponseType Get_Credit_Card_Code_Mappings_Response;

		public Get_Credit_Card_Code_MappingsOutput()
		{
		}

		public Get_Credit_Card_Code_MappingsOutput(Get_Credit_Card_Code_Mappings_ResponseType Get_Credit_Card_Code_Mappings_Response)
		{
			this.Get_Credit_Card_Code_Mappings_Response = Get_Credit_Card_Code_Mappings_Response;
		}
	}
}
