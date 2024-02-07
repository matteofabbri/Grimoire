using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Bank_Statement_Custom_Code_SetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Bank_Statement_Custom_Code_Set_ResponseType Put_Bank_Statement_Custom_Code_Set_Response;

		public Put_Bank_Statement_Custom_Code_SetOutput()
		{
		}

		public Put_Bank_Statement_Custom_Code_SetOutput(Put_Bank_Statement_Custom_Code_Set_ResponseType Put_Bank_Statement_Custom_Code_Set_Response)
		{
			this.Put_Bank_Statement_Custom_Code_Set_Response = Put_Bank_Statement_Custom_Code_Set_Response;
		}
	}
}
