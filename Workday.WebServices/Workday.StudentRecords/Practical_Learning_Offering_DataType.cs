using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Practical_Learning_Offering_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Practical_LearningObjectType practical_Learning_ReferenceField;

		private Activity_Offering_DataType[] behaviored_Activity_Offering_DataField;

		private Practical_Learning_Offering_Specific_DataType[] practical_Learning_Offering_Specific_DataField;

		private Has_Academic_Curricular_Division_DataType[] has_Academic_Unit_DataField;

		private Has_Enrollable_Eligibility_DataType[] has_Enrollable_Eligibility_DataField;

		private Has_Billable_Load_Status_DataType[] has_Billable_Load_Status_DataField;

		private Has_Schedulable_DataType[] has_Schedulable_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Practical_LearningObjectType Practical_Learning_Reference
		{
			get
			{
				return this.practical_Learning_ReferenceField;
			}
			set
			{
				this.practical_Learning_ReferenceField = value;
				this.RaisePropertyChanged("Practical_Learning_Reference");
			}
		}

		[XmlElement("Behaviored_Activity_Offering_Data", Order = 2)]
		public Activity_Offering_DataType[] Behaviored_Activity_Offering_Data
		{
			get
			{
				return this.behaviored_Activity_Offering_DataField;
			}
			set
			{
				this.behaviored_Activity_Offering_DataField = value;
				this.RaisePropertyChanged("Behaviored_Activity_Offering_Data");
			}
		}

		[XmlElement("Practical_Learning_Offering_Specific_Data", Order = 3)]
		public Practical_Learning_Offering_Specific_DataType[] Practical_Learning_Offering_Specific_Data
		{
			get
			{
				return this.practical_Learning_Offering_Specific_DataField;
			}
			set
			{
				this.practical_Learning_Offering_Specific_DataField = value;
				this.RaisePropertyChanged("Practical_Learning_Offering_Specific_Data");
			}
		}

		[XmlElement("Has_Academic_Unit_Data", Order = 4)]
		public Has_Academic_Curricular_Division_DataType[] Has_Academic_Unit_Data
		{
			get
			{
				return this.has_Academic_Unit_DataField;
			}
			set
			{
				this.has_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Has_Academic_Unit_Data");
			}
		}

		[XmlElement("Has_Enrollable_Eligibility_Data", Order = 5)]
		public Has_Enrollable_Eligibility_DataType[] Has_Enrollable_Eligibility_Data
		{
			get
			{
				return this.has_Enrollable_Eligibility_DataField;
			}
			set
			{
				this.has_Enrollable_Eligibility_DataField = value;
				this.RaisePropertyChanged("Has_Enrollable_Eligibility_Data");
			}
		}

		[XmlElement("Has_Billable_Load_Status_Data", Order = 6)]
		public Has_Billable_Load_Status_DataType[] Has_Billable_Load_Status_Data
		{
			get
			{
				return this.has_Billable_Load_Status_DataField;
			}
			set
			{
				this.has_Billable_Load_Status_DataField = value;
				this.RaisePropertyChanged("Has_Billable_Load_Status_Data");
			}
		}

		[XmlElement("Has_Schedulable_Data", Order = 7)]
		public Has_Schedulable_DataType[] Has_Schedulable_Data
		{
			get
			{
				return this.has_Schedulable_DataField;
			}
			set
			{
				this.has_Schedulable_DataField = value;
				this.RaisePropertyChanged("Has_Schedulable_Data");
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
