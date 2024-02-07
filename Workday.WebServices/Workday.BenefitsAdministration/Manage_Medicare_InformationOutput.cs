using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Medicare_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Medicare_Information_ResponseType Manage_Medicare_Information_Response;

		public Manage_Medicare_InformationOutput()
		{
		}

		public Manage_Medicare_InformationOutput(Manage_Medicare_Information_ResponseType Manage_Medicare_Information_Response)
		{
			this.Manage_Medicare_Information_Response = Manage_Medicare_Information_Response;
		}
	}
}
