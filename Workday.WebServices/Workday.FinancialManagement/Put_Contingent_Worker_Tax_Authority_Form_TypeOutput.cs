using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contingent_Worker_Tax_Authority_Form_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contingent_Worker_Tax_Authority_Form_Type_ResponseType Put_Contingent_Worker_Tax_Authority_Form_Type_Response;

		public Put_Contingent_Worker_Tax_Authority_Form_TypeOutput()
		{
		}

		public Put_Contingent_Worker_Tax_Authority_Form_TypeOutput(Put_Contingent_Worker_Tax_Authority_Form_Type_ResponseType Put_Contingent_Worker_Tax_Authority_Form_Type_Response)
		{
			this.Put_Contingent_Worker_Tax_Authority_Form_Type_Response = Put_Contingent_Worker_Tax_Authority_Form_Type_Response;
		}
	}
}
