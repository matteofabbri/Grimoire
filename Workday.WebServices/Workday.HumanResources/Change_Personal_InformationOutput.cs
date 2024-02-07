using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Personal_InformationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Personal_Information_ResponseType Change_Personal_Information_Response;

		public Change_Personal_InformationOutput()
		{
		}

		public Change_Personal_InformationOutput(Change_Personal_Information_ResponseType Change_Personal_Information_Response)
		{
			this.Change_Personal_Information_Response = Change_Personal_Information_Response;
		}
	}
}
