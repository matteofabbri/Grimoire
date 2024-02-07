using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_StudentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Students_ResponseType Get_Students_Response;

		public Get_StudentsOutput()
		{
		}

		public Get_StudentsOutput(Get_Students_ResponseType Get_Students_Response)
		{
			this.Get_Students_Response = Get_Students_Response;
		}
	}
}
