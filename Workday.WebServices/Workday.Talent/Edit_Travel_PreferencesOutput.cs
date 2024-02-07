using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Travel_PreferencesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Travel_Preferences_ResponseType Edit_Travel_Preferences_Response;

		public Edit_Travel_PreferencesOutput()
		{
		}

		public Edit_Travel_PreferencesOutput(Edit_Travel_Preferences_ResponseType Edit_Travel_Preferences_Response)
		{
			this.Edit_Travel_Preferences_Response = Edit_Travel_Preferences_Response;
		}
	}
}
