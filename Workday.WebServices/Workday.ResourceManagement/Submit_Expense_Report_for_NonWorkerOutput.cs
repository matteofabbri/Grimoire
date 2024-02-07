using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_Report_for_NonWorkerOutput
	{
		[MessageBodyMember(Name = "Submit_Expense_Report_for_Non-Worker_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Submit_Expense_Report_for_Non-Worker_Response")]
		public Submit_Expense_Report_for_NonWorker_ResponseType Submit_Expense_Report_for_NonWorker_Response;

		public Submit_Expense_Report_for_NonWorkerOutput()
		{
		}

		public Submit_Expense_Report_for_NonWorkerOutput(Submit_Expense_Report_for_NonWorker_ResponseType Submit_Expense_Report_for_NonWorker_Response)
		{
			this.Submit_Expense_Report_for_NonWorker_Response = Submit_Expense_Report_for_NonWorker_Response;
		}
	}
}
