using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Course_Section_RelationshipInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Course_Section_Relationship_RequestType Get_Course_Section_Relationship_Request;

		public Get_Course_Section_RelationshipInput()
		{
		}

		public Get_Course_Section_RelationshipInput(Workday_Common_HeaderType Workday_Common_Header, Get_Course_Section_Relationship_RequestType Get_Course_Section_Relationship_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Course_Section_Relationship_Request = Get_Course_Section_Relationship_Request;
		}
	}
}
