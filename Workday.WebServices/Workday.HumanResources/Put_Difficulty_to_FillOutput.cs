using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Difficulty_to_FillOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Difficulty_to_Fill_ResponseType Put_Difficulty_to_Fill_Response;

		public Put_Difficulty_to_FillOutput()
		{
		}

		public Put_Difficulty_to_FillOutput(Put_Difficulty_to_Fill_ResponseType Put_Difficulty_to_Fill_Response)
		{
			this.Put_Difficulty_to_Fill_Response = Put_Difficulty_to_Fill_Response;
		}
	}
}
