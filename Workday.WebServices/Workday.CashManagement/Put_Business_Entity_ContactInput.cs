using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Business_Entity_ContactInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request;

		public Put_Business_Entity_ContactInput()
		{
		}

		public Put_Business_Entity_ContactInput(Workday_Common_HeaderType Workday_Common_Header, Put_Business_Entity_Contact_RequestType Put_Business_Entity_Contact_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Business_Entity_Contact_Request = Put_Business_Entity_Contact_Request;
		}
	}
}
