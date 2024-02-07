using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Awards_and_ActivitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Awards_and_Activities_ResponseType Manage_Awards_and_Activities_Response;

		public Manage_Awards_and_ActivitiesOutput()
		{
		}

		public Manage_Awards_and_ActivitiesOutput(Manage_Awards_and_Activities_ResponseType Manage_Awards_and_Activities_Response)
		{
			this.Manage_Awards_and_Activities_Response = Manage_Awards_and_Activities_Response;
		}
	}
}
