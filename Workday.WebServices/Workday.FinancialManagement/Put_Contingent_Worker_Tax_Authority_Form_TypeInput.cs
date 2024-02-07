using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Contingent_Worker_Tax_Authority_Form_TypeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Contingent_Worker_Tax_Authority_Form_Type_RequestType Put_Contingent_Worker_Tax_Authority_Form_Type_Request;

		public Put_Contingent_Worker_Tax_Authority_Form_TypeInput()
		{
		}

		public Put_Contingent_Worker_Tax_Authority_Form_TypeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Contingent_Worker_Tax_Authority_Form_Type_RequestType Put_Contingent_Worker_Tax_Authority_Form_Type_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Contingent_Worker_Tax_Authority_Form_Type_Request = Put_Contingent_Worker_Tax_Authority_Form_Type_Request;
		}
	}
}
