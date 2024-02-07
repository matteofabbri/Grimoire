using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Veteran_Status_IdentificationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Veteran_Status_Identification_ResponseType Change_Veteran_Status_Identification_Response;

		public Change_Veteran_Status_IdentificationOutput()
		{
		}

		public Change_Veteran_Status_IdentificationOutput(Change_Veteran_Status_Identification_ResponseType Change_Veteran_Status_Identification_Response)
		{
			this.Change_Veteran_Status_Identification_Response = Change_Veteran_Status_Identification_Response;
		}
	}
}
