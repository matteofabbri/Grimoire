using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_FamilyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Family_ResponseType Put_Job_Family_Response;

		public Put_Job_FamilyOutput()
		{
		}

		public Put_Job_FamilyOutput(Put_Job_Family_ResponseType Put_Job_Family_Response)
		{
			this.Put_Job_Family_Response = Put_Job_Family_Response;
		}
	}
}
