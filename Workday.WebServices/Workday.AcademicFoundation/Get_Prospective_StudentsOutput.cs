using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prospective_StudentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prospective_Students_ResponseType Get_Prospective_Students_Response;

		public Get_Prospective_StudentsOutput()
		{
		}

		public Get_Prospective_StudentsOutput(Get_Prospective_Students_ResponseType Get_Prospective_Students_Response)
		{
			this.Get_Prospective_Students_Response = Get_Prospective_Students_Response;
		}
	}
}
