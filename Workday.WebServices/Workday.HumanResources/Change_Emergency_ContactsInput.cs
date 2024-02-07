using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Emergency_ContactsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Emergency_Contacts_RequestType Change_Emergency_Contacts_Request;

		public Change_Emergency_ContactsInput()
		{
		}

		public Change_Emergency_ContactsInput(Workday_Common_HeaderType Workday_Common_Header, Change_Emergency_Contacts_RequestType Change_Emergency_Contacts_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Emergency_Contacts_Request = Change_Emergency_Contacts_Request;
		}
	}
}
