using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Administration_Rate_AgreementInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Administration_Rate_Agreement_RequestType Put_Facilities_and_Administration_Rate_Agreement_Request;

		public Put_Facilities_and_Administration_Rate_AgreementInput()
		{
		}

		public Put_Facilities_and_Administration_Rate_AgreementInput(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Rate_Agreement_RequestType Put_Facilities_and_Administration_Rate_Agreement_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Facilities_and_Administration_Rate_Agreement_Request = Put_Facilities_and_Administration_Rate_Agreement_Request;
		}
	}
}
