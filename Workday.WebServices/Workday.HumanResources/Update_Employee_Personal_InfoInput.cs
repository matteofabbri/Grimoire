using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Employee_Personal_InfoInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Personal_Info_UpdateType Employee_Personal_Info_Update;

		public Update_Employee_Personal_InfoInput()
		{
		}

		public Update_Employee_Personal_InfoInput(Workday_Common_HeaderType Workday_Common_Header, Employee_Personal_Info_UpdateType Employee_Personal_Info_Update)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Employee_Personal_Info_Update = Employee_Personal_Info_Update;
		}
	}
}
