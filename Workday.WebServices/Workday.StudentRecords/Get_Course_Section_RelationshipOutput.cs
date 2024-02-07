using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Course_Section_RelationshipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Course_Section_Relationship_ResponseType Get_Course_Section_Relationship_Response;

		public Get_Course_Section_RelationshipOutput()
		{
		}

		public Get_Course_Section_RelationshipOutput(Get_Course_Section_Relationship_ResponseType Get_Course_Section_Relationship_Response)
		{
			this.Get_Course_Section_Relationship_Response = Get_Course_Section_Relationship_Response;
		}
	}
}
