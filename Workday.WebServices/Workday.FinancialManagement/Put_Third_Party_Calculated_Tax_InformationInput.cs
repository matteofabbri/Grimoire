using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Third_Party_Calculated_Tax_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Third_Party_Calculated_Tax_Information_RequestType Put_Third_Party_Calculated_Tax_Information_Request;

		public Put_Third_Party_Calculated_Tax_InformationInput()
		{
		}

		public Put_Third_Party_Calculated_Tax_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Third_Party_Calculated_Tax_Information_RequestType Put_Third_Party_Calculated_Tax_Information_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Third_Party_Calculated_Tax_Information_Request = Put_Third_Party_Calculated_Tax_Information_Request;
		}
	}
}
