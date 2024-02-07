using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Application_Requirement_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Application_Requirement_Assignment_ResponseType Put_Student_Application_Requirement_Assignment_Response;

		public Put_Student_Application_Requirement_AssignmentOutput()
		{
		}

		public Put_Student_Application_Requirement_AssignmentOutput(Put_Student_Application_Requirement_Assignment_ResponseType Put_Student_Application_Requirement_Assignment_Response)
		{
			this.Put_Student_Application_Requirement_Assignment_Response = Put_Student_Application_Requirement_Assignment_Response;
		}
	}
}
