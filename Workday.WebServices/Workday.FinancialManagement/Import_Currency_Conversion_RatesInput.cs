using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Currency_Conversion_RatesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Currency_Conversion_Rates_RequestType Import_Currency_Conversion_Rates_Request;

		public Import_Currency_Conversion_RatesInput()
		{
		}

		public Import_Currency_Conversion_RatesInput(Workday_Common_HeaderType Workday_Common_Header, Import_Currency_Conversion_Rates_RequestType Import_Currency_Conversion_Rates_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Currency_Conversion_Rates_Request = Import_Currency_Conversion_Rates_Request;
		}
	}
}
