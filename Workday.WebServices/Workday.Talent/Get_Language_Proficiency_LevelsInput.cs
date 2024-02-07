using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Language_Proficiency_LevelsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Language_Proficiency_Levels_RequestType Get_Language_Proficiency_Levels_Request;

		public Get_Language_Proficiency_LevelsInput()
		{
		}

		public Get_Language_Proficiency_LevelsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Language_Proficiency_Levels_RequestType Get_Language_Proficiency_Levels_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Language_Proficiency_Levels_Request = Get_Language_Proficiency_Levels_Request;
		}
	}
}
