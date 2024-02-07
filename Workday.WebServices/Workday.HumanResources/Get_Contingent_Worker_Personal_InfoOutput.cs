using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Contingent_Worker_Personal_InfoOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Contingent_Worker_Personal_InfoType Contingent_Worker_Personal_Info;

		public Get_Contingent_Worker_Personal_InfoOutput()
		{
		}

		public Get_Contingent_Worker_Personal_InfoOutput(Contingent_Worker_Personal_InfoType Contingent_Worker_Personal_Info)
		{
			this.Contingent_Worker_Personal_Info = Contingent_Worker_Personal_Info;
		}
	}
}
