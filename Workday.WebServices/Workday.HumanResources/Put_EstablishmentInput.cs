using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_EstablishmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Establishment_RequestType Put_Establishment_Request;

		public Put_EstablishmentInput()
		{
		}

		public Put_EstablishmentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Establishment_RequestType Put_Establishment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Establishment_Request = Put_Establishment_Request;
		}
	}
}