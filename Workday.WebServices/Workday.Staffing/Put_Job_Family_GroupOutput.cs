using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_Family_GroupOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Family_Group_ResponseType Put_Job_Family_Group_Response;

		public Put_Job_Family_GroupOutput()
		{
		}

		public Put_Job_Family_GroupOutput(Put_Job_Family_Group_ResponseType Put_Job_Family_Group_Response)
		{
			this.Put_Job_Family_Group_Response = Put_Job_Family_Group_Response;
		}
	}
}
