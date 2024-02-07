using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Personal_InfoOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Personal_InfoType Employee_Personal_Info;

		public Get_Employee_Personal_InfoOutput()
		{
		}

		public Get_Employee_Personal_InfoOutput(Employee_Personal_InfoType Employee_Personal_Info)
		{
			this.Employee_Personal_Info = Employee_Personal_Info;
		}
	}
}
