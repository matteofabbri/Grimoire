using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Find_Business_SiteInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Business_Site_FindType Business_Site_Find;

		public Find_Business_SiteInput()
		{
		}

		public Find_Business_SiteInput(Workday_Common_HeaderType Workday_Common_Header, Business_Site_FindType Business_Site_Find)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Business_Site_Find = Business_Site_Find;
		}
	}
}
