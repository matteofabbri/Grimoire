using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_BeneficiaryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Beneficiary_RequestType Change_Beneficiary_Request;

		public Change_BeneficiaryInput()
		{
		}

		public Change_BeneficiaryInput(Workday_Common_HeaderType Workday_Common_Header, Change_Beneficiary_RequestType Change_Beneficiary_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Beneficiary_Request = Change_Beneficiary_Request;
		}
	}
}
