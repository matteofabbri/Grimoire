using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Tag_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Tag_Categories_ResponseType Get_Student_Tag_Categories_Response;

		public Get_Student_Tag_CategoriesOutput()
		{
		}

		public Get_Student_Tag_CategoriesOutput(Get_Student_Tag_Categories_ResponseType Get_Student_Tag_Categories_Response)
		{
			this.Get_Student_Tag_Categories_Response = Get_Student_Tag_Categories_Response;
		}
	}
}
