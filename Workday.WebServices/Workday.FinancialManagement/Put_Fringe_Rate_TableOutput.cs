using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Fringe_Rate_TableOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Fringe_Rate_Table_ResponseType Put_Fringe_Rate_Table_Response;

		public Put_Fringe_Rate_TableOutput()
		{
		}

		public Put_Fringe_Rate_TableOutput(Put_Fringe_Rate_Table_ResponseType Put_Fringe_Rate_Table_Response)
		{
			this.Put_Fringe_Rate_Table_Response = Put_Fringe_Rate_Table_Response;
		}
	}
}
