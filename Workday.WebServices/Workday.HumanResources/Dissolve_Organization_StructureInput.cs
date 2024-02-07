using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Dissolve_Organization_StructureInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Organization_Structure_DissolveType Organization_Structure_Dissolve;

		public Dissolve_Organization_StructureInput()
		{
		}

		public Dissolve_Organization_StructureInput(Workday_Common_HeaderType Workday_Common_Header, Organization_Structure_DissolveType Organization_Structure_Dissolve)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Organization_Structure_Dissolve = Organization_Structure_Dissolve;
		}
	}
}
