using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_EstablishmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Establishment_RequestType Assign_Establishment_Request;

		public Assign_EstablishmentInput()
		{
		}

		public Assign_EstablishmentInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Establishment_RequestType Assign_Establishment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Establishment_Request = Assign_Establishment_Request;
		}
	}
}
