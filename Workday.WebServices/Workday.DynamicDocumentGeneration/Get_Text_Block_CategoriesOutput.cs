using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Text_Block_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Text_Block_Categories_ResponseType Get_Text_Block_Categories_Response;

		public Get_Text_Block_CategoriesOutput()
		{
		}

		public Get_Text_Block_CategoriesOutput(Get_Text_Block_Categories_ResponseType Get_Text_Block_Categories_Response)
		{
			this.Get_Text_Block_Categories_Response = Get_Text_Block_Categories_Response;
		}
	}
}
