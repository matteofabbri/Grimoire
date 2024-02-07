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
	public class Orientation_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Configurable_Activity_Data_Snapshot_DataType[] configurable_Activity_Data_Snapshot_DataField;

		private Orientation_Specific_Data_DataType[] orientation_Specific_Data_DataField;

		private Has_Academic_Curricular_Division_DataType[] has_Academic_Curricular_Division_DataField;

		private Has_Enrollment_Eligibility_Defaults_DataType[] has_Enrollment_Eligibility_Defaults_DataField;

		private Has_Billable_Load_Status_Defaults_DataType[] has_Billable_Load_Status_Defaults_DataField;

		private Has_Schedulable_Defaults_DataType[] has_Schedulable_Defaults_DataField;

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

		[XmlElement("Configurable_Activity_Data_Snapshot_Data", Order = 1)]
		public Configurable_Activity_Data_Snapshot_DataType[] Configurable_Activity_Data_Snapshot_Data
		{
			get
			{
				return this.configurable_Activity_Data_Snapshot_DataField;
			}
			set
			{
				this.configurable_Activity_Data_Snapshot_DataField = value;
				this.RaisePropertyChanged("Configurable_Activity_Data_Snapshot_Data");
			}
		}

		[XmlElement("Orientation_Specific_Data_Data", Order = 2)]
		public Orientation_Specific_Data_DataType[] Orientation_Specific_Data_Data
		{
			get
			{
				return this.orientation_Specific_Data_DataField;
			}
			set
			{
				this.orientation_Specific_Data_DataField = value;
				this.RaisePropertyChanged("Orientation_Specific_Data_Data");
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

		[XmlElement("Has_Enrollment_Eligibility_Defaults_Data", Order = 4)]
		public Has_Enrollment_Eligibility_Defaults_DataType[] Has_Enrollment_Eligibility_Defaults_Data
		{
			get
			{
				return this.has_Enrollment_Eligibility_Defaults_DataField;
			}
			set
			{
				this.has_Enrollment_Eligibility_Defaults_DataField = value;
				this.RaisePropertyChanged("Has_Enrollment_Eligibility_Defaults_Data");
			}
		}

		[XmlElement("Has_Billable_Load_Status_Defaults_Data", Order = 5)]
		public Has_Billable_Load_Status_Defaults_DataType[] Has_Billable_Load_Status_Defaults_Data
		{
			get
			{
				return this.has_Billable_Load_Status_Defaults_DataField;
			}
			set
			{
				this.has_Billable_Load_Status_Defaults_DataField = value;
				this.RaisePropertyChanged("Has_Billable_Load_Status_Defaults_Data");
			}
		}

		[XmlElement("Has_Schedulable_Defaults_Data", Order = 6)]
		public Has_Schedulable_Defaults_DataType[] Has_Schedulable_Defaults_Data
		{
			get
			{
				return this.has_Schedulable_Defaults_DataField;
			}
			set
			{
				this.has_Schedulable_Defaults_DataField = value;
				this.RaisePropertyChanged("Has_Schedulable_Defaults_Data");
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
