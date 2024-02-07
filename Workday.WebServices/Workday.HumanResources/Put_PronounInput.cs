using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_PronounInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Pronoun_RequestType Put_Pronoun_Request;

		public Put_PronounInput()
		{
		}

		public Put_PronounInput(Workday_Common_HeaderType Workday_Common_Header, Put_Pronoun_RequestType Put_Pronoun_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Pronoun_Request = Put_Pronoun_Request;
		}
	}
}
