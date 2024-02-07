using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Evidence_of_InsurabilityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Evidence_of_Insurability_RequestType Put_Evidence_of_Insurability_Request;

		public Put_Evidence_of_InsurabilityInput()
		{
		}

		public Put_Evidence_of_InsurabilityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Evidence_of_Insurability_RequestType Put_Evidence_of_Insurability_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Evidence_of_Insurability_Request = Put_Evidence_of_Insurability_Request;
		}
	}
}
