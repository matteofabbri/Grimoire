using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Employment_InfoInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Employment_Info_GetType Employee_Employment_Info_Get;

		public Get_Employee_Employment_InfoInput()
		{
		}

		public Get_Employee_Employment_InfoInput(Workday_Common_HeaderType Workday_Common_Header, Employee_Employment_Info_GetType Employee_Employment_Info_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Employee_Employment_Info_Get = Employee_Employment_Info_Get;
		}
	}
}
