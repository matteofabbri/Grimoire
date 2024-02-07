using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_TrainingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Training_ResponseType Manage_Training_Response;

		public Manage_TrainingOutput()
		{
		}

		public Manage_TrainingOutput(Manage_Training_ResponseType Manage_Training_Response)
		{
			this.Manage_Training_Response = Manage_Training_Response;
		}
	}
}
