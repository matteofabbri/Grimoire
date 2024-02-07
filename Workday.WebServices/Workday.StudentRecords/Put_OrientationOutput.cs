using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_OrientationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Orientation_ResponseType Put_Orientation_Response;

		public Put_OrientationOutput()
		{
		}

		public Put_OrientationOutput(Put_Orientation_ResponseType Put_Orientation_Response)
		{
			this.Put_Orientation_Response = Put_Orientation_Response;
		}
	}
}
