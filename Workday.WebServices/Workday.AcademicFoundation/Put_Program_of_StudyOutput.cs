using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Program_of_StudyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Program_of_Study_ResponseType Put_Program_of_Study_Response;

		public Put_Program_of_StudyOutput()
		{
		}

		public Put_Program_of_StudyOutput(Put_Program_of_Study_ResponseType Put_Program_of_Study_Response)
		{
			this.Put_Program_of_Study_Response = Put_Program_of_Study_Response;
		}
	}
}
