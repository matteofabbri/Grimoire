using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Maintain_Notice_Periods_for_CountryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Maintain_Notice_Periods_for_Country_ResponseType Put_Maintain_Notice_Periods_for_Country_Response;

		public Put_Maintain_Notice_Periods_for_CountryOutput()
		{
		}

		public Put_Maintain_Notice_Periods_for_CountryOutput(Put_Maintain_Notice_Periods_for_Country_ResponseType Put_Maintain_Notice_Periods_for_Country_Response)
		{
			this.Put_Maintain_Notice_Periods_for_Country_Response = Put_Maintain_Notice_Periods_for_Country_Response;
		}
	}
}
