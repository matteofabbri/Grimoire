using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_SiteInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Business_Site_GetType Business_Site_Get;

		public Get_Business_SiteInput()
		{
		}

		public Get_Business_SiteInput(Workday_Common_HeaderType Workday_Common_Header, Business_Site_GetType Business_Site_Get)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Business_Site_Get = Business_Site_Get;
		}
	}
}
