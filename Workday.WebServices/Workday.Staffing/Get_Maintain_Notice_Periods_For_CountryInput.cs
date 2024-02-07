using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Maintain_Notice_Periods_For_CountryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Maintain_Notice_Periods_For_Country_RequestType Get_Maintain_Notice_Periods_For_Country_Request;

		public Get_Maintain_Notice_Periods_For_CountryInput()
		{
		}

		public Get_Maintain_Notice_Periods_For_CountryInput(Workday_Common_HeaderType Workday_Common_Header, Get_Maintain_Notice_Periods_For_Country_RequestType Get_Maintain_Notice_Periods_For_Country_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Maintain_Notice_Periods_For_Country_Request = Get_Maintain_Notice_Periods_For_Country_Request;
		}
	}
}
