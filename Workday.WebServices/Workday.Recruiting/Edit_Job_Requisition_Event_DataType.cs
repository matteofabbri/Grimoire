using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Job_Requisition_Event_DataType : INotifyPropertyChanged
	{
		private decimal number_of_OpeningsField;

		private bool number_of_OpeningsFieldSpecified;

		private Event_Classification_SubcategoryObjectType edit_Job_Requisition_Reason_ReferenceField;

		private Job_Requisition_Data_for_Create_and_EditType[] job_Requisition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Number_of_Openings
		{
			get
			{
				return this.number_of_OpeningsField;
			}
			set
			{
				this.number_of_OpeningsField = value;
				this.RaisePropertyChanged("Number_of_Openings");
			}
		}

		[XmlIgnore]
		public bool Number_of_OpeningsSpecified
		{
			get
			{
				return this.number_of_OpeningsFieldSpecified;
			}
			set
			{
				this.number_of_OpeningsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_OpeningsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Edit_Job_Requisition_Reason_Reference
		{
			get
			{
				return this.edit_Job_Requisition_Reason_ReferenceField;
			}
			set
			{
				this.edit_Job_Requisition_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Edit_Job_Requisition_Reason_Reference");
			}
		}

		[XmlElement("Job_Requisition_Data", Order = 2)]
		public Job_Requisition_Data_for_Create_and_EditType[] Job_Requisition_Data
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
