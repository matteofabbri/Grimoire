using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Worker_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Worker_ProfileType Worker_Profile;

		public Get_Worker_ProfileOutput()
		{
		}

		public Get_Worker_ProfileOutput(Worker_ProfileType Worker_Profile)
		{
			this.Worker_Profile = Worker_Profile;
		}
	}
}
