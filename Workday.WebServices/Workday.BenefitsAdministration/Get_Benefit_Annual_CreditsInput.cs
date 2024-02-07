using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Benefit_Annual_CreditsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Benefit_Annual_Credits_RequestType Get_Benefit_Annual_Credits_Request;

		public Get_Benefit_Annual_CreditsInput()
		{
		}

		public Get_Benefit_Annual_CreditsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Benefit_Annual_Credits_RequestType Get_Benefit_Annual_Credits_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Benefit_Annual_Credits_Request = Get_Benefit_Annual_Credits_Request;
		}
	}
}
