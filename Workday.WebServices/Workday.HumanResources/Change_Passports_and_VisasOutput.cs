using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Passports_and_VisasOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Passports_and_Visas_ResponseType Change_Passports_and_Visas_Response;

		public Change_Passports_and_VisasOutput()
		{
		}

		public Change_Passports_and_VisasOutput(Change_Passports_and_Visas_ResponseType Change_Passports_and_Visas_Response)
		{
			this.Change_Passports_and_Visas_Response = Change_Passports_and_Visas_Response;
		}
	}
}
