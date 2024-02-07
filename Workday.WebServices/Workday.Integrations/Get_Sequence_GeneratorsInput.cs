using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sequence_GeneratorsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sequence_Generators_RequestType Get_Sequence_Generators_Request;

		public Get_Sequence_GeneratorsInput()
		{
		}

		public Get_Sequence_GeneratorsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Sequence_Generators_RequestType Get_Sequence_Generators_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Sequence_Generators_Request = Get_Sequence_Generators_Request;
		}
	}
}
