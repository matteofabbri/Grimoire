using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Absence_InputInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Absence_Input_RequestType Put_Absence_Input_Request;

		public Put_Absence_InputInput()
		{
		}

		public Put_Absence_InputInput(Workday_Common_HeaderType Workday_Common_Header, Put_Absence_Input_RequestType Put_Absence_Input_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Absence_Input_Request = Put_Absence_Input_Request;
		}
	}
}
