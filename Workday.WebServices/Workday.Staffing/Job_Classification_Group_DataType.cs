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
	public class Job_Classification_Group_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private string job_Classification_Group_NameField;

		private Global_Setup_Data_MappingObjectType global_Setup_Data_Mapping_ReferenceField;

		private Location_ContextObjectType location_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Job_ClassificationType[] job_ClassificationField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Classification_Group_Name
		{
			get
			{
				return this.job_Classification_Group_NameField;
			}
			set
			{
				this.job_Classification_Group_NameField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Global_Setup_Data_MappingObjectType Global_Setup_Data_Mapping_Reference
		{
			get
			{
				return this.global_Setup_Data_Mapping_ReferenceField;
			}
			set
			{
				this.global_Setup_Data_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Global_Setup_Data_Mapping_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Location_ContextObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Job_Classification", Order = 6)]
		public Job_ClassificationType[] Job_Classification
		{
			get
			{
				return this.job_ClassificationField;
			}
			set
			{
				this.job_ClassificationField = value;
				this.RaisePropertyChanged("Job_Classification");
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
