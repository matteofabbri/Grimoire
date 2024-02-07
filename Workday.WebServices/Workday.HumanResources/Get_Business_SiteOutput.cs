using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Business_SiteOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Business_SiteType Business_Site;

		public Get_Business_SiteOutput()
		{
		}

		public Get_Business_SiteOutput(Business_SiteType Business_Site)
		{
			this.Business_Site = Business_Site;
		}
	}
}
