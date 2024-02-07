using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Named_ProfessorshipInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Named_Professorship_RequestType Create_Named_Professorship_Request;

		public Create_Named_ProfessorshipInput()
		{
		}

		public Create_Named_ProfessorshipInput(Workday_Common_HeaderType Workday_Common_Header, Create_Named_Professorship_RequestType Create_Named_Professorship_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Create_Named_Professorship_Request = Create_Named_Professorship_Request;
		}
	}
}
