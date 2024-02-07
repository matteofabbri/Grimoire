using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Text_BlockInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Text_Block_RequestType Put_Text_Block_Request;

		public Put_Text_BlockInput()
		{
		}

		public Put_Text_BlockInput(Workday_Common_HeaderType Workday_Common_Header, Put_Text_Block_RequestType Put_Text_Block_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Text_Block_Request = Put_Text_Block_Request;
		}
	}
}
