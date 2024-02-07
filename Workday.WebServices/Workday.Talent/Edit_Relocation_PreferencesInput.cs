using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Relocation_PreferencesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Relocation_Preferences_RequestType Edit_Relocation_Preferences_Request;

		public Edit_Relocation_PreferencesInput()
		{
		}

		public Edit_Relocation_PreferencesInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Relocation_Preferences_RequestType Edit_Relocation_Preferences_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Relocation_Preferences_Request = Edit_Relocation_Preferences_Request;
		}
	}
}
