using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Difficulty_to_FillOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Difficulty_to_Fill_ResponseType Get_Difficulty_to_Fill_Response;

		public Get_Difficulty_to_FillOutput()
		{
		}

		public Get_Difficulty_to_FillOutput(Get_Difficulty_to_Fill_ResponseType Get_Difficulty_to_Fill_Response)
		{
			this.Get_Difficulty_to_Fill_Response = Get_Difficulty_to_Fill_Response;
		}
	}
}
