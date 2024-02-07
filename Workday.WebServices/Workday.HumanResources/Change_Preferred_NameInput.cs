using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Preferred_NameInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Preferred_Name_RequestType Change_Preferred_Name_Request;

		public Change_Preferred_NameInput()
		{
		}

		public Change_Preferred_NameInput(Workday_Common_HeaderType Workday_Common_Header, Change_Preferred_Name_RequestType Change_Preferred_Name_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Preferred_Name_Request = Change_Preferred_Name_Request;
		}
	}
}
