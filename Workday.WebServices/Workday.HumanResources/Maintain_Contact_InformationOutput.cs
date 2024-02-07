using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Contact_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Contact_Information_for_Person_Event_ResponseType Maintain_Contact_Information_for_Person_Event_Response;

		public Maintain_Contact_InformationOutput()
		{
		}

		public Maintain_Contact_InformationOutput(Maintain_Contact_Information_for_Person_Event_ResponseType Maintain_Contact_Information_for_Person_Event_Response)
		{
			this.Maintain_Contact_Information_for_Person_Event_Response = Maintain_Contact_Information_for_Person_Event_Response;
		}
	}
}
