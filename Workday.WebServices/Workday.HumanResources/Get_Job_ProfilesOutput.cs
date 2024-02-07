using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_ProfilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Profiles_ResponseType Get_Job_Profiles_Response;

		public Get_Job_ProfilesOutput()
		{
		}

		public Get_Job_ProfilesOutput(Get_Job_Profiles_ResponseType Get_Job_Profiles_Response)
		{
			this.Get_Job_Profiles_Response = Get_Job_Profiles_Response;
		}
	}
}
