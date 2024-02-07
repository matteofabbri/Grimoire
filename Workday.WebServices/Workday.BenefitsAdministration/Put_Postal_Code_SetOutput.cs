using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Postal_Code_SetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Postal_Code_Set_ResponseType Put_Postal_Code_Set_Response;

		public Put_Postal_Code_SetOutput()
		{
		}

		public Put_Postal_Code_SetOutput(Put_Postal_Code_Set_ResponseType Put_Postal_Code_Set_Response)
		{
			this.Put_Postal_Code_Set_Response = Put_Postal_Code_Set_Response;
		}
	}
}
