using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Single_Legal_EntityInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Single_Legal_Entity_RequestType Put_Single_Legal_Entity_Request;

		public Put_Single_Legal_EntityInput()
		{
		}

		public Put_Single_Legal_EntityInput(Workday_Common_HeaderType Workday_Common_Header, Put_Single_Legal_Entity_RequestType Put_Single_Legal_Entity_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Single_Legal_Entity_Request = Put_Single_Legal_Entity_Request;
		}
	}
}
