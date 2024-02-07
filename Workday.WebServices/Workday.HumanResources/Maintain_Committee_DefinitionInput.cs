using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Committee_DefinitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Committee_Definition_RequestType Maintain_Committee_Definition_Request;

		public Maintain_Committee_DefinitionInput()
		{
		}

		public Maintain_Committee_DefinitionInput(Workday_Common_HeaderType Workday_Common_Header, Maintain_Committee_Definition_RequestType Maintain_Committee_Definition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Maintain_Committee_Definition_Request = Maintain_Committee_Definition_Request;
		}
	}
}
