using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Currency_Conversion_RateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Currency_Conversion_Rate_RequestType Put_Currency_Conversion_Rate_Request;

		public Put_Currency_Conversion_RateInput()
		{
		}

		public Put_Currency_Conversion_RateInput(Workday_Common_HeaderType Workday_Common_Header, Put_Currency_Conversion_Rate_RequestType Put_Currency_Conversion_Rate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Currency_Conversion_Rate_Request = Put_Currency_Conversion_Rate_Request;
		}
	}
}
