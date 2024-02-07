using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Veteran_Status_IdentificationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Veteran_Status_Identification_RequestType Change_Veteran_Status_Identification_Request;

		public Change_Veteran_Status_IdentificationInput()
		{
		}

		public Change_Veteran_Status_IdentificationInput(Workday_Common_HeaderType Workday_Common_Header, Change_Veteran_Status_Identification_RequestType Change_Veteran_Status_Identification_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Veteran_Status_Identification_Request = Change_Veteran_Status_Identification_Request;
		}
	}
}
