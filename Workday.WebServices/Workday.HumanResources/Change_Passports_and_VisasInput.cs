using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Passports_and_VisasInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Passports_and_Visas_RequestType Change_Passports_and_Visas_Request;

		public Change_Passports_and_VisasInput()
		{
		}

		public Change_Passports_and_VisasInput(Workday_Common_HeaderType Workday_Common_Header, Change_Passports_and_Visas_RequestType Change_Passports_and_Visas_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Passports_and_Visas_Request = Change_Passports_and_Visas_Request;
		}
	}
}
