using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_FrequenciesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Frequencies_RequestType Get_Frequencies_Request;

		public Get_FrequenciesInput()
		{
		}

		public Get_FrequenciesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Frequencies_RequestType Get_Frequencies_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Frequencies_Request = Get_Frequencies_Request;
		}
	}
}
