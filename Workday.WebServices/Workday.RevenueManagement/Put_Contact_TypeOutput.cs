using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contact_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contact_Type_ResponseType Put_Contact_Type_Response;

		public Put_Contact_TypeOutput()
		{
		}

		public Put_Contact_TypeOutput(Put_Contact_Type_ResponseType Put_Contact_Type_Response)
		{
			this.Put_Contact_Type_Response = Put_Contact_Type_Response;
		}
	}
}
