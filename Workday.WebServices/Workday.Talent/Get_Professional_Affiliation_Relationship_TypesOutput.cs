using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Professional_Affiliation_Relationship_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Professional_Affiliation_Relationship_Types_ResponseType Get_Professional_Affiliation_Relationship_Types_Response;

		public Get_Professional_Affiliation_Relationship_TypesOutput()
		{
		}

		public Get_Professional_Affiliation_Relationship_TypesOutput(Get_Professional_Affiliation_Relationship_Types_ResponseType Get_Professional_Affiliation_Relationship_Types_Response)
		{
			this.Get_Professional_Affiliation_Relationship_Types_Response = Get_Professional_Affiliation_Relationship_Types_Response;
		}
	}
}
