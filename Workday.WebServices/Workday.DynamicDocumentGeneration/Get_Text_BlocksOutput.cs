using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Text_BlocksOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Text_Blocks_ResponseType Get_Text_Blocks_Response;

		public Get_Text_BlocksOutput()
		{
		}

		public Get_Text_BlocksOutput(Get_Text_Blocks_ResponseType Get_Text_Blocks_Response)
		{
			this.Get_Text_Blocks_Response = Get_Text_Blocks_Response;
		}
	}
}
