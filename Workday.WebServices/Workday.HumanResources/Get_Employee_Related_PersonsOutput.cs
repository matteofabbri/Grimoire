using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Related_PersonsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Related_PersonsType Employee_Related_Persons;

		public Get_Employee_Related_PersonsOutput()
		{
		}

		public Get_Employee_Related_PersonsOutput(Employee_Related_PersonsType Employee_Related_Persons)
		{
			this.Employee_Related_Persons = Employee_Related_Persons;
		}
	}
}
