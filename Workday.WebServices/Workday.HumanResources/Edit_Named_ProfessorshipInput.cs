using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Named_ProfessorshipInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Named_Professorship_RequestType Edit_Named_Professorship_Request;

		public Edit_Named_ProfessorshipInput()
		{
		}

		public Edit_Named_ProfessorshipInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Named_Professorship_RequestType Edit_Named_Professorship_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Named_Professorship_Request = Edit_Named_Professorship_Request;
		}
	}
}
