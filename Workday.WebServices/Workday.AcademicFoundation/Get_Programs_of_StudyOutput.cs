using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Programs_of_StudyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Programs_of_Study_ResponseType Get_Programs_of_Study_Response;

		public Get_Programs_of_StudyOutput()
		{
		}

		public Get_Programs_of_StudyOutput(Get_Programs_of_Study_ResponseType Get_Programs_of_Study_Response)
		{
			this.Get_Programs_of_Study_Response = Get_Programs_of_Study_Response;
		}
	}
}
