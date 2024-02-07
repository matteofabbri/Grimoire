using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_DegreeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Degree_ResponseType Put_Degree_Response;

		public Put_DegreeOutput()
		{
		}

		public Put_DegreeOutput(Put_Degree_ResponseType Put_Degree_Response)
		{
			this.Put_Degree_Response = Put_Degree_Response;
		}
	}
}
