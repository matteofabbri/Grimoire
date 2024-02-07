using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_OrientationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Orientations_ResponseType Get_Orientations_Response;

		public Get_OrientationsOutput()
		{
		}

		public Get_OrientationsOutput(Get_Orientations_ResponseType Get_Orientations_Response)
		{
			this.Get_Orientations_Response = Get_Orientations_Response;
		}
	}
}
