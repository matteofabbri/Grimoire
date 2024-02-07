using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Stock_Participation_Rate_TableOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Stock_Participation_Rate_Table_ResponseType Put_Stock_Participation_Rate_Table_Response;

		public Put_Stock_Participation_Rate_TableOutput()
		{
		}

		public Put_Stock_Participation_Rate_TableOutput(Put_Stock_Participation_Rate_Table_ResponseType Put_Stock_Participation_Rate_Table_Response)
		{
			this.Put_Stock_Participation_Rate_Table_Response = Put_Stock_Participation_Rate_Table_Response;
		}
	}
}
