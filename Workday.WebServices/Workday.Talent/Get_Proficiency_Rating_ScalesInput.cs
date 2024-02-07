using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Proficiency_Rating_ScalesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Proficiency_Rating_Scales_RequestType Get_Proficiency_Rating_Scales_Request;

		public Get_Proficiency_Rating_ScalesInput()
		{
		}

		public Get_Proficiency_Rating_ScalesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Proficiency_Rating_Scales_RequestType Get_Proficiency_Rating_Scales_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Proficiency_Rating_Scales_Request = Get_Proficiency_Rating_Scales_Request;
		}
	}
}
