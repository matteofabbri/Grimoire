using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Fields_Of_StudyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Fields_Of_Study_ResponseType Get_Fields_Of_Study_Response;

		public Get_Fields_Of_StudyOutput()
		{
		}

		public Get_Fields_Of_StudyOutput(Get_Fields_Of_Study_ResponseType Get_Fields_Of_Study_Response)
		{
			this.Get_Fields_Of_Study_Response = Get_Fields_Of_Study_Response;
		}
	}
}
