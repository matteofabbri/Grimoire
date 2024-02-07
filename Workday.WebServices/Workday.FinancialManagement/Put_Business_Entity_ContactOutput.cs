using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Business_Entity_ContactOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact_Response;

		public Put_Business_Entity_ContactOutput()
		{
		}

		public Put_Business_Entity_ContactOutput(Put_Business_Entity_Contact_ResponseType Put_Business_Entity_Contact_Response)
		{
			this.Put_Business_Entity_Contact_Response = Put_Business_Entity_Contact_Response;
		}
	}
}
