using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Goal_UnitsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Goal_Units_RequestType Get_Goal_Units_Request;

		public Get_Goal_UnitsInput()
		{
		}

		public Get_Goal_UnitsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Goal_Units_RequestType Get_Goal_Units_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Goal_Units_Request = Get_Goal_Units_Request;
		}
	}
}
