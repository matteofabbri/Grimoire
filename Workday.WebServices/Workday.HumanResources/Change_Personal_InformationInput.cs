using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Personal_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Personal_Information_RequestType Change_Personal_Information_Request;

		public Change_Personal_InformationInput()
		{
		}

		public Change_Personal_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Change_Personal_Information_RequestType Change_Personal_Information_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Personal_Information_Request = Change_Personal_Information_Request;
		}
	}
}
