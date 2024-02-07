using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_ROE_Prior_Period_History_ResultsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_ROE_Prior_Period_History_Results_RequestType Import_ROE_Prior_Period_History_Results_Request;

		public Import_ROE_Prior_Period_History_ResultsInput()
		{
		}

		public Import_ROE_Prior_Period_History_ResultsInput(Workday_Common_HeaderType Workday_Common_Header, Import_ROE_Prior_Period_History_Results_RequestType Import_ROE_Prior_Period_History_Results_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_ROE_Prior_Period_History_Results_Request = Import_ROE_Prior_Period_History_Results_Request;
		}
	}
}
