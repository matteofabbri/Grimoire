using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Employment_InfoOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Employment_InfoType Employee_Employment_Info;

		public Get_Employee_Employment_InfoOutput()
		{
		}

		public Get_Employee_Employment_InfoOutput(Employee_Employment_InfoType Employee_Employment_Info)
		{
			this.Employee_Employment_Info = Employee_Employment_Info;
		}
	}
}
