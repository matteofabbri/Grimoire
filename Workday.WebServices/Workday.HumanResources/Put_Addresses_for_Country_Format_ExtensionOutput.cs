using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Addresses_for_Country_Format_ExtensionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Addresses_for_Country_Format_Extension_ResponseType Put_Addresses_for_Country_Format_Extension_Response;

		public Put_Addresses_for_Country_Format_ExtensionOutput()
		{
		}

		public Put_Addresses_for_Country_Format_ExtensionOutput(Put_Addresses_for_Country_Format_Extension_ResponseType Put_Addresses_for_Country_Format_Extension_Response)
		{
			this.Put_Addresses_for_Country_Format_Extension_Response = Put_Addresses_for_Country_Format_Extension_Response;
		}
	}
}
