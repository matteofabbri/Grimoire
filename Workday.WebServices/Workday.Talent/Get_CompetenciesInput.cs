using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CompetenciesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Competencies_RequestType Get_Competencies_Request;

		public Get_CompetenciesInput()
		{
		}

		public Get_CompetenciesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Competencies_RequestType Get_Competencies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Competencies_Request = Get_Competencies_Request;
		}
	}
}
