using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Maintained_Academic_PeriodsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Maintained_Academic_Periods_RequestType Get_Maintained_Academic_Periods_Request;

		public Get_Maintained_Academic_PeriodsInput()
		{
		}

		public Get_Maintained_Academic_PeriodsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Maintained_Academic_Periods_RequestType Get_Maintained_Academic_Periods_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Maintained_Academic_Periods_Request = Get_Maintained_Academic_Periods_Request;
		}
	}
}
