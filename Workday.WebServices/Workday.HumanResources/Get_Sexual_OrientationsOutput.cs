using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sexual_OrientationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sexual_Orientations_ResponseType Get_Sexual_Orientations_Response;

		public Get_Sexual_OrientationsOutput()
		{
		}

		public Get_Sexual_OrientationsOutput(Get_Sexual_Orientations_ResponseType Get_Sexual_Orientations_Response)
		{
			this.Get_Sexual_Orientations_Response = Get_Sexual_Orientations_Response;
		}
	}
}
