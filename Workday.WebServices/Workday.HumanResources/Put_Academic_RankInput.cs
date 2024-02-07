using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Academic_RankInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Academic_Rank_RequestType Put_Academic_Rank_Request;

		public Put_Academic_RankInput()
		{
		}

		public Put_Academic_RankInput(Workday_Common_HeaderType Workday_Common_Header, Put_Academic_Rank_RequestType Put_Academic_Rank_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Academic_Rank_Request = Put_Academic_Rank_Request;
		}
	}
}
