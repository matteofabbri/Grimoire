using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Course_Offering_SetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Course_Offering_Set_RequestType Put_Course_Offering_Set_Request;

		public Put_Course_Offering_SetInput()
		{
		}

		public Put_Course_Offering_SetInput(Workday_Common_HeaderType Workday_Common_Header, Put_Course_Offering_Set_RequestType Put_Course_Offering_Set_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Course_Offering_Set_Request = Put_Course_Offering_Set_Request;
		}
	}
}
