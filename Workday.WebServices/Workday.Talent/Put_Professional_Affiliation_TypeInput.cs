using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Professional_Affiliation_TypeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Professional_Affiliation_Type_RequestType Put_Professional_Affiliation_Type_Request;

		public Put_Professional_Affiliation_TypeInput()
		{
		}

		public Put_Professional_Affiliation_TypeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Professional_Affiliation_Type_RequestType Put_Professional_Affiliation_Type_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Professional_Affiliation_Type_Request = Put_Professional_Affiliation_Type_Request;
		}
	}
}
