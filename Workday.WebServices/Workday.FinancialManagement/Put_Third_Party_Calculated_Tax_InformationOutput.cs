using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Third_Party_Calculated_Tax_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Third_Party_Calculated_Tax_Information_ResponseType Put_Third_Party_Calculated_Tax_Information_Response;

		public Put_Third_Party_Calculated_Tax_InformationOutput()
		{
		}

		public Put_Third_Party_Calculated_Tax_InformationOutput(Put_Third_Party_Calculated_Tax_Information_ResponseType Put_Third_Party_Calculated_Tax_Information_Response)
		{
			this.Put_Third_Party_Calculated_Tax_Information_Response = Put_Third_Party_Calculated_Tax_Information_Response;
		}
	}
}
