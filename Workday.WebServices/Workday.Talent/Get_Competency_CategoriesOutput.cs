using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Competency_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Competency_Categories_ResponseType Get_Competency_Categories_Response;

		public Get_Competency_CategoriesOutput()
		{
		}

		public Get_Competency_CategoriesOutput(Get_Competency_Categories_ResponseType Get_Competency_Categories_Response)
		{
			this.Get_Competency_Categories_Response = Get_Competency_Categories_Response;
		}
	}
}
