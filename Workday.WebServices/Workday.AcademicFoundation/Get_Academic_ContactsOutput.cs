using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Academic_ContactsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Academic_Contacts_ResponseType Get_Academic_Contacts_Response;

		public Get_Academic_ContactsOutput()
		{
		}

		public Get_Academic_ContactsOutput(Get_Academic_Contacts_ResponseType Get_Academic_Contacts_Response)
		{
			this.Get_Academic_Contacts_Response = Get_Academic_Contacts_Response;
		}
	}
}
