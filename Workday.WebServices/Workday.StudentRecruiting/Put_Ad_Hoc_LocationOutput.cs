using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ad_Hoc_LocationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ad_Hoc_Location_ResponseType Put_Ad_Hoc_Location_Response;

		public Put_Ad_Hoc_LocationOutput()
		{
		}

		public Put_Ad_Hoc_LocationOutput(Put_Ad_Hoc_Location_ResponseType Put_Ad_Hoc_Location_Response)
		{
			this.Put_Ad_Hoc_Location_Response = Put_Ad_Hoc_Location_Response;
		}
	}
}
