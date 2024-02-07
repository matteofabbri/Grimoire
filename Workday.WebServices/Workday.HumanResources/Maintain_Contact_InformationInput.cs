using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Contact_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Contact_Information_for_Person_Event_RequestType Maintain_Contact_Information_for_Person_Event_Request;

		public Maintain_Contact_InformationInput()
		{
		}

		public Maintain_Contact_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Maintain_Contact_Information_for_Person_Event_RequestType Maintain_Contact_Information_for_Person_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Maintain_Contact_Information_for_Person_Event_Request = Maintain_Contact_Information_for_Person_Event_Request;
		}
	}
}
