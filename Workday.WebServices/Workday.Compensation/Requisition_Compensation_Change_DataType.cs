using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Requisition_Compensation_Change_DataType : INotifyPropertyChanged
	{
		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private DateTime compensation_Change_DateField;

		private Requisition_Compensation_DataType requisition_Compensation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_RequisitionObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Compensation_Change_Date
		{
			get
			{
				return this.compensation_Change_DateField;
			}
			set
			{
				this.compensation_Change_DateField = value;
				this.RaisePropertyChanged("Compensation_Change_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Requisition_Compensation_DataType Requisition_Compensation_Data
		{
			get
			{
				return this.requisition_Compensation_DataField;
			}
			set
			{
				this.requisition_Compensation_DataField = value;
				this.RaisePropertyChanged("Requisition_Compensation_Data");
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
