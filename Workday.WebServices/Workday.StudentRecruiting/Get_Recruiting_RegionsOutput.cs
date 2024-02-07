using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Recruiting_RegionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Recruiting_Regions_ResponseType Get_Recruiting_Regions_Response;

		public Get_Recruiting_RegionsOutput()
		{
		}

		public Get_Recruiting_RegionsOutput(Get_Recruiting_Regions_ResponseType Get_Recruiting_Regions_Response)
		{
			this.Get_Recruiting_Regions_Response = Get_Recruiting_Regions_Response;
		}
	}
}
