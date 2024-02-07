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
	public class Study_Abroad_Offering_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Behaviored_Activity_Offering_DataType[] behaviored_Activity_Offering_DataField;

		private Study_Abroad_Offering_Specific_DataType[] study_Abroad_Offering_Specific_DataField;

		private Has_Academic_Curricular_Division_DataType[] has_Academic_Curricular_Division_DataField;

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

		[XmlElement("Behaviored_Activity_Offering_Data", Order = 1)]
		public Behaviored_Activity_Offering_DataType[] Behaviored_Activity_Offering_Data
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

		[XmlElement("Study_Abroad_Offering_Specific_Data", Order = 2)]
		public Study_Abroad_Offering_Specific_DataType[] Study_Abroad_Offering_Specific_Data
		{
			get
			{
				return this.study_Abroad_Offering_Specific_DataField;
			}
			set
			{
				this.study_Abroad_Offering_Specific_DataField = value;
				this.RaisePropertyChanged("Study_Abroad_Offering_Specific_Data");
			}
		}

		[XmlElement("Has_Academic_Curricular_Division_Data", Order = 3)]
		public Has_Academic_Curricular_Division_DataType[] Has_Academic_Curricular_Division_Data
		{
			get
			{
				return this.has_Academic_Curricular_Division_DataField;
			}
			set
			{
				this.has_Academic_Curricular_Division_DataField = value;
				this.RaisePropertyChanged("Has_Academic_Curricular_Division_Data");
			}
		}

		[XmlElement("Has_Enrollable_Eligibility_Data", Order = 4)]
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

		[XmlElement("Has_Billable_Load_Status_Data", Order = 5)]
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

		[XmlElement("Has_Schedulable_Data", Order = 6)]
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
