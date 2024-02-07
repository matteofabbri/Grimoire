using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_Related_PersonsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_Related_Persons_GetType Employee_Related_Persons_Get;

		public Get_Employee_Related_PersonsInput()
		{
		}

		public Get_Employee_Related_PersonsInput(Workday_Common_HeaderType Workday_Common_Header, Employee_Related_Persons_GetType Employee_Related_Persons_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Employee_Related_Persons_Get = Employee_Related_Persons_Get;
		}
	}
}
