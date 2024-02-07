using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_Entity_ContactsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts_Response;

		public Get_Business_Entity_ContactsOutput()
		{
		}

		public Get_Business_Entity_ContactsOutput(Get_Business_Entity_Contacts_ResponseType Get_Business_Entity_Contacts_Response)
		{
			this.Get_Business_Entity_Contacts_Response = Get_Business_Entity_Contacts_Response;
		}
	}
}
