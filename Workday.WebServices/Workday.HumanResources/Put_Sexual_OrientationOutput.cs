using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Sexual_OrientationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sexual_Orientation_ResponseType Put_Sexual_Orientation_Response;

		public Put_Sexual_OrientationOutput()
		{
		}

		public Put_Sexual_OrientationOutput(Put_Sexual_Orientation_ResponseType Put_Sexual_Orientation_Response)
		{
			this.Put_Sexual_Orientation_Response = Put_Sexual_Orientation_Response;
		}
	}
}
