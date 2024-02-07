using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_W2_W2C_Printing_ElectionOutput
	{
		[MessageBodyMember(Name = "Put_W-2_W-2C_Printing_Election_for_Worker_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Put_W-2_W-2C_Printing_Election_for_Worker_Response")]
		public Put_W2_W2C_Printing_Election_for_Worker_ResponseType Put_W2_W2C_Printing_Election_for_Worker_Response;

		public Put_W2_W2C_Printing_ElectionOutput()
		{
		}

		public Put_W2_W2C_Printing_ElectionOutput(Put_W2_W2C_Printing_Election_for_Worker_ResponseType Put_W2_W2C_Printing_Election_for_Worker_Response)
		{
			this.Put_W2_W2C_Printing_Election_for_Worker_Response = Put_W2_W2C_Printing_Election_for_Worker_Response;
		}
	}
}
