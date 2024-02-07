using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Workday_AccountInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Workday_Account_for_Worker_UpdateType Workday_Account_for_Worker_Update;

		public Update_Workday_AccountInput()
		{
		}

		public Update_Workday_AccountInput(Workday_Common_HeaderType Workday_Common_Header, Workday_Account_for_Worker_UpdateType Workday_Account_for_Worker_Update)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Workday_Account_for_Worker_Update = Workday_Account_for_Worker_Update;
		}
	}
}
