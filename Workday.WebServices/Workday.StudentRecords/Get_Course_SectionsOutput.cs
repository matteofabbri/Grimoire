using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Course_SectionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Course_Sections_ResponseType Get_Course_Sections_Response;

		public Get_Course_SectionsOutput()
		{
		}

		public Get_Course_SectionsOutput(Get_Course_Sections_ResponseType Get_Course_Sections_Response)
		{
			this.Get_Course_Sections_Response = Get_Course_Sections_Response;
		}
	}
}
