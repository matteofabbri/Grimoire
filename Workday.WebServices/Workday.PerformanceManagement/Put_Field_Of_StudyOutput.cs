using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Field_Of_StudyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Field_Of_Study_ResponseType Put_Field_Of_Study_Response;

		public Put_Field_Of_StudyOutput()
		{
		}

		public Put_Field_Of_StudyOutput(Put_Field_Of_Study_ResponseType Put_Field_Of_Study_Response)
		{
			this.Put_Field_Of_Study_Response = Put_Field_Of_Study_Response;
		}
	}
}
