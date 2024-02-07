using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Maintain_Notice_Periods_for_CountryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Maintain_Notice_Periods_for_Country_RequestType Put_Maintain_Notice_Periods_for_Country_Request;

		public Put_Maintain_Notice_Periods_for_CountryInput()
		{
		}

		public Put_Maintain_Notice_Periods_for_CountryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Maintain_Notice_Periods_for_Country_RequestType Put_Maintain_Notice_Periods_for_Country_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Maintain_Notice_Periods_for_Country_Request = Put_Maintain_Notice_Periods_for_Country_Request;
		}
	}
}
