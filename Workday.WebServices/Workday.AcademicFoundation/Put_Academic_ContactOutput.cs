using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Academic_ContactOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Academic_Contact_ResponseType Put_Academic_Contact_Response;

		public Put_Academic_ContactOutput()
		{
		}

		public Put_Academic_ContactOutput(Put_Academic_Contact_ResponseType Put_Academic_Contact_Response)
		{
			this.Put_Academic_Contact_Response = Put_Academic_Contact_Response;
		}
	}
}
