using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Course_MaterialOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Course_Material_ResponseType Put_Student_Course_Material_Response;

		public Put_Student_Course_MaterialOutput()
		{
		}

		public Put_Student_Course_MaterialOutput(Put_Student_Course_Material_ResponseType Put_Student_Course_Material_Response)
		{
			this.Put_Student_Course_Material_Response = Put_Student_Course_Material_Response;
		}
	}
}
