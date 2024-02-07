using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Create_Job_Requisition_Sub_Process_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType create_Job_Requisition_Reason_ReferenceField;

		private Job_Requisition_Data_for_Create_and_EditType job_Requisition_DataField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_Process_for_Create_Job_RequisitionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Create_Job_Requisition_Reason_Reference
		{
			get
			{
				return this.create_Job_Requisition_Reason_ReferenceField;
			}
			set
			{
				this.create_Job_Requisition_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Create_Job_Requisition_Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_Requisition_Data_for_Create_and_EditType Job_Requisition_Data
		{
			get
			{
				return this.job_Requisition_DataField;
			}
			set
			{
				this.job_Requisition_DataField = value;
				this.RaisePropertyChanged("Job_Requisition_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Check_Position_Budget_Sub_Business_ProcessType Check_Position_Budget_Sub_Process_for_Create_Job_Requisition
		{
			get
			{
				return this.check_Position_Budget_Sub_Process_for_Create_Job_RequisitionField;
			}
			set
			{
				this.check_Position_Budget_Sub_Process_for_Create_Job_RequisitionField = value;
				this.RaisePropertyChanged("Check_Position_Budget_Sub_Process_for_Create_Job_Requisition");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
