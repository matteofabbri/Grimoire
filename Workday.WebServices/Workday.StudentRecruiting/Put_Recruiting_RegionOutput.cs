using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Recruiting_RegionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Recruiting_Region_ResponseType Put_Recruiting_Region_Response;

		public Put_Recruiting_RegionOutput()
		{
		}

		public Put_Recruiting_RegionOutput(Put_Recruiting_Region_ResponseType Put_Recruiting_Region_Response)
		{
			this.Put_Recruiting_Region_Response = Put_Recruiting_Region_Response;
		}
	}
}
