using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Relocation_PreferencesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Relocation_Preferences_ResponseType Manage_Relocation_Preferences_Response;

		public Edit_Relocation_PreferencesOutput()
		{
		}

		public Edit_Relocation_PreferencesOutput(Manage_Relocation_Preferences_ResponseType Manage_Relocation_Preferences_Response)
		{
			this.Manage_Relocation_Preferences_Response = Manage_Relocation_Preferences_Response;
		}
	}
}
