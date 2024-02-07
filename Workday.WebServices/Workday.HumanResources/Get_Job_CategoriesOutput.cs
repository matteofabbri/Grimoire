using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Categories_ResponseType Get_Job_Categories_Response;

		public Get_Job_CategoriesOutput()
		{
		}

		public Get_Job_CategoriesOutput(Get_Job_Categories_ResponseType Get_Job_Categories_Response)
		{
			this.Get_Job_Categories_Response = Get_Job_Categories_Response;
		}
	}
}
