using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Account_SetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Account_Set_ResponseType Put_Account_Set_Response;

		public Put_Account_SetOutput()
		{
		}

		public Put_Account_SetOutput(Put_Account_Set_ResponseType Put_Account_Set_Response)
		{
			this.Put_Account_Set_Response = Put_Account_Set_Response;
		}
	}
}
