using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Search_SettingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Search_Settings_ResponseType Put_Search_Settings_Response;

		public Put_Search_SettingsOutput()
		{
		}

		public Put_Search_SettingsOutput(Put_Search_Settings_ResponseType Put_Search_Settings_Response)
		{
			this.Put_Search_Settings_Response = Put_Search_Settings_Response;
		}
	}
}
