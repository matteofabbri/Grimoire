using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Course_Equivalency_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Course_Equivalency_Group_ResponseType Put_Course_Equivalency_Group_Response;

		public Put_Course_Equivalency_GroupOutput()
		{
		}

		public Put_Course_Equivalency_GroupOutput(Put_Course_Equivalency_Group_ResponseType Put_Course_Equivalency_Group_Response)
		{
			this.Put_Course_Equivalency_Group_Response = Put_Course_Equivalency_Group_Response;
		}
	}
}
