using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Preferred_NameOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Preferred_Name_ResponseType Change_Preferred_Name_Response;

		public Change_Preferred_NameOutput()
		{
		}

		public Change_Preferred_NameOutput(Change_Preferred_Name_ResponseType Change_Preferred_Name_Response)
		{
			this.Change_Preferred_Name_Response = Change_Preferred_Name_Response;
		}
	}
}
