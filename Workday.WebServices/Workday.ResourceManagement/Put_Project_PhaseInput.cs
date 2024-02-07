using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_PhaseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Phase_RequestType Put_Project_Phase_Request;

		public Put_Project_PhaseInput()
		{
		}

		public Put_Project_PhaseInput(Workday_Common_HeaderType Workday_Common_Header, Put_Project_Phase_RequestType Put_Project_Phase_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Project_Phase_Request = Put_Project_Phase_Request;
		}
	}
}
