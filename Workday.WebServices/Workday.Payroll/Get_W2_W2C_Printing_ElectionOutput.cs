using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_W2_W2C_Printing_ElectionOutput
	{
		[MessageBodyMember(Name = "Get_W-2_W-2C_Printing_Election_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_W-2_W-2C_Printing_Election_Response")]
		public Get_W2_W2C_Printing_Election_ResponseType Get_W2_W2C_Printing_Election_Response;

		public Get_W2_W2C_Printing_ElectionOutput()
		{
		}

		public Get_W2_W2C_Printing_ElectionOutput(Get_W2_W2C_Printing_Election_ResponseType Get_W2_W2C_Printing_Election_Response)
		{
			this.Get_W2_W2C_Printing_Election_Response = Get_W2_W2C_Printing_Election_Response;
		}
	}
}
