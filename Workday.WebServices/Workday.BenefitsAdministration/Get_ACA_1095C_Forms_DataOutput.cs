using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ACA_1095C_Forms_DataOutput
	{
		[MessageBodyMember(Name = "Get_ACA_1095-C_Forms_Data_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_ACA_1095-C_Forms_Data_Response")]
		public Get_ACA_1095C_Forms_Data_ResponseType Get_ACA_1095C_Forms_Data_Response;

		public Get_ACA_1095C_Forms_DataOutput()
		{
		}

		public Get_ACA_1095C_Forms_DataOutput(Get_ACA_1095C_Forms_Data_ResponseType Get_ACA_1095C_Forms_Data_Response)
		{
			this.Get_ACA_1095C_Forms_Data_Response = Get_ACA_1095C_Forms_Data_Response;
		}
	}
}
