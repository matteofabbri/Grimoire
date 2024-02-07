using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Text_BlockOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Text_Block_ResponseType Put_Text_Block_Response;

		public Put_Text_BlockOutput()
		{
		}

		public Put_Text_BlockOutput(Put_Text_Block_ResponseType Put_Text_Block_Response)
		{
			this.Put_Text_Block_Response = Put_Text_Block_Response;
		}
	}
}
