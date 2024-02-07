using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Change_Program_of_StudyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Change_Program_of_Study_ResponseType Submit_Change_Program_of_Study_Response;

		public Submit_Change_Program_of_StudyOutput()
		{
		}

		public Submit_Change_Program_of_StudyOutput(Submit_Change_Program_of_Study_ResponseType Submit_Change_Program_of_Study_Response)
		{
			this.Submit_Change_Program_of_Study_Response = Submit_Change_Program_of_Study_Response;
		}
	}
}
