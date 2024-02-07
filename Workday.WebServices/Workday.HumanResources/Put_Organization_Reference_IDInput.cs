using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Organization_Reference_IDInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Organization_Reference_ID_RequestType Put_Organization_Reference_ID_Request;

		public Put_Organization_Reference_IDInput()
		{
		}

		public Put_Organization_Reference_IDInput(Workday_Common_HeaderType Workday_Common_Header, Put_Organization_Reference_ID_RequestType Put_Organization_Reference_ID_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Organization_Reference_ID_Request = Put_Organization_Reference_ID_Request;
		}
	}
}
