using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Employee_ImageOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Employee_ImageType Employee_Image;

		public Get_Employee_ImageOutput()
		{
		}

		public Get_Employee_ImageOutput(Employee_ImageType Employee_Image)
		{
			this.Employee_Image = Employee_Image;
		}
	}
}
