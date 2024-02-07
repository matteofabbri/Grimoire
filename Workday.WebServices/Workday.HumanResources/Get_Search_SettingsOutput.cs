using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Search_SettingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Search_Settings_ResponseType Get_Search_Settings_Response;

		public Get_Search_SettingsOutput()
		{
		}

		public Get_Search_SettingsOutput(Get_Search_Settings_ResponseType Get_Search_Settings_Response)
		{
			this.Get_Search_Settings_Response = Get_Search_Settings_Response;
		}
	}
}
