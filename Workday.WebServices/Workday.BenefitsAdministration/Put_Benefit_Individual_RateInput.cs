using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Benefit_Individual_RateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Benefit_Individual_Rate_RequestType Put_Benefit_Individual_Rate_Request;

		public Put_Benefit_Individual_RateInput()
		{
		}

		public Put_Benefit_Individual_RateInput(Workday_Common_HeaderType Workday_Common_Header, Put_Benefit_Individual_Rate_RequestType Put_Benefit_Individual_Rate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Benefit_Individual_Rate_Request = Put_Benefit_Individual_Rate_Request;
		}
	}
}
