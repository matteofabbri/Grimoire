using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Goal_UnitInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Goal_Unit_RequestType Put_Goal_Unit_Request;

		public Put_Goal_UnitInput()
		{
		}

		public Put_Goal_UnitInput(Workday_Common_HeaderType Workday_Common_Header, Put_Goal_Unit_RequestType Put_Goal_Unit_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Goal_Unit_Request = Put_Goal_Unit_Request;
		}
	}
}
