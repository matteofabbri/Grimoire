using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Journal_SourceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Journal_Source_RequestType Put_Journal_Source_Request;

		public Put_Journal_SourceInput()
		{
		}

		public Put_Journal_SourceInput(Workday_Common_HeaderType Workday_Common_Header, Put_Journal_Source_RequestType Put_Journal_Source_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Journal_Source_Request = Put_Journal_Source_Request;
		}
	}
}
