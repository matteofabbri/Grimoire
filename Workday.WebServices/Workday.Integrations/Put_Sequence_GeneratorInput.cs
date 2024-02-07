using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Sequence_GeneratorInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Sequence_Generator_RequestType Put_Sequence_Generator_Request;

		public Put_Sequence_GeneratorInput()
		{
		}

		public Put_Sequence_GeneratorInput(Workday_Common_HeaderType Workday_Common_Header, Put_Sequence_Generator_RequestType Put_Sequence_Generator_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Sequence_Generator_Request = Put_Sequence_Generator_Request;
		}
	}
}
