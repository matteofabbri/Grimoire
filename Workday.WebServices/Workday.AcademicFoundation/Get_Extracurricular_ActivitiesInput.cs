using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Extracurricular_ActivitiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Extracurricular_Activities_RequestType Get_Extracurricular_Activities_Request;

		public Get_Extracurricular_ActivitiesInput()
		{
		}

		public Get_Extracurricular_ActivitiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Extracurricular_Activities_RequestType Get_Extracurricular_Activities_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Extracurricular_Activities_Request = Get_Extracurricular_Activities_Request;
		}
	}
}
