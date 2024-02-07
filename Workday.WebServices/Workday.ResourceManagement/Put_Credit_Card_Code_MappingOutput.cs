using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Credit_Card_Code_MappingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Credit_Card_Code_Mapping_ResponseType Put_Credit_Card_Code_Mapping_Response;

		public Put_Credit_Card_Code_MappingOutput()
		{
		}

		public Put_Credit_Card_Code_MappingOutput(Put_Credit_Card_Code_Mapping_ResponseType Put_Credit_Card_Code_Mapping_Response)
		{
			this.Put_Credit_Card_Code_Mapping_Response = Put_Credit_Card_Code_Mapping_Response;
		}
	}
}
