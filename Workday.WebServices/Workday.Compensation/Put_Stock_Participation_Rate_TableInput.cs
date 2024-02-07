using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Stock_Participation_Rate_TableInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Stock_Participation_Rate_Table_RequestType Put_Stock_Participation_Rate_Table_Request;

		public Put_Stock_Participation_Rate_TableInput()
		{
		}

		public Put_Stock_Participation_Rate_TableInput(Workday_Common_HeaderType Workday_Common_Header, Put_Stock_Participation_Rate_Table_RequestType Put_Stock_Participation_Rate_Table_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Stock_Participation_Rate_Table_Request = Put_Stock_Participation_Rate_Table_Request;
		}
	}
}
