using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Maintain_Notice_Periods_For_CountryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Maintain_Notice_Periods_For_Country_ResponseType Get_Maintain_Notice_Periods_For_Country_Response;

		public Get_Maintain_Notice_Periods_For_CountryOutput()
		{
		}

		public Get_Maintain_Notice_Periods_For_CountryOutput(Get_Maintain_Notice_Periods_For_Country_ResponseType Get_Maintain_Notice_Periods_For_Country_Response)
		{
			this.Get_Maintain_Notice_Periods_For_Country_Response = Get_Maintain_Notice_Periods_For_Country_Response;
		}
	}
}
