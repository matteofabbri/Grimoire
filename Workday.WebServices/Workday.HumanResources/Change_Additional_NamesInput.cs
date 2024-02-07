using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Additional_NamesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Additional_Names_RequestType Change_Additional_Names_Request;

		public Change_Additional_NamesInput()
		{
		}

		public Change_Additional_NamesInput(Workday_Common_HeaderType Workday_Common_Header, Change_Additional_Names_RequestType Change_Additional_Names_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Additional_Names_Request = Change_Additional_Names_Request;
		}
	}
}
