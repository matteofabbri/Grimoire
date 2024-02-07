using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_EthnicityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ethnicity_RequestType Put_Ethnicity_Request;

		public Put_EthnicityInput()
		{
		}

		public Put_EthnicityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Ethnicity_RequestType Put_Ethnicity_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Ethnicity_Request = Put_Ethnicity_Request;
		}
	}
}
