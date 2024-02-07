using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Other_IDsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Other_IDs_RequestType Change_Other_IDs_Request;

		public Change_Other_IDsInput()
		{
		}

		public Change_Other_IDsInput(Workday_Common_HeaderType Workday_Common_Header, Change_Other_IDs_RequestType Change_Other_IDs_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Other_IDs_Request = Change_Other_IDs_Request;
		}
	}
}
