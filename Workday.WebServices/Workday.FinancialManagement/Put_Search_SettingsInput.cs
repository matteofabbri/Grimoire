using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Search_SettingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Search_Settings_RequestType Put_Search_Settings_Request;

		public Put_Search_SettingsInput()
		{
		}

		public Put_Search_SettingsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Search_Settings_RequestType Put_Search_Settings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Search_Settings_Request = Put_Search_Settings_Request;
		}
	}
}
