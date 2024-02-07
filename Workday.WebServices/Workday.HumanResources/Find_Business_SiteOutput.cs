using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Find_Business_SiteOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Business_Site_ReferencesRootType Business_Site_References;

		public Find_Business_SiteOutput()
		{
		}

		public Find_Business_SiteOutput(Business_Site_ReferencesRootType Business_Site_References)
		{
			this.Business_Site_References = Business_Site_References;
		}
	}
}
