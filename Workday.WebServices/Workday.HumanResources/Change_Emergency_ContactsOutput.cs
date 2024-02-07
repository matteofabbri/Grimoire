using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Emergency_ContactsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Emergency_Contacts_ResponseType Change_Emergency_Contacts_Response;

		public Change_Emergency_ContactsOutput()
		{
		}

		public Change_Emergency_ContactsOutput(Change_Emergency_Contacts_ResponseType Change_Emergency_Contacts_Response)
		{
			this.Change_Emergency_Contacts_Response = Change_Emergency_Contacts_Response;
		}
	}
}
