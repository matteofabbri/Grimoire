using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Location_AttributeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Location_Attribute_ResponseType Put_Location_Attribute_Response;

		public Put_Location_AttributeOutput()
		{
		}

		public Put_Location_AttributeOutput(Put_Location_Attribute_ResponseType Put_Location_Attribute_Response)
		{
			this.Put_Location_Attribute_Response = Put_Location_Attribute_Response;
		}
	}
}
