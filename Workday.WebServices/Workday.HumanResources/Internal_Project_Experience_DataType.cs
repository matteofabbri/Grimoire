using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Internal_Project_Experience_DataType : INotifyPropertyChanged
	{
		private string internal_Project_Experience_IDField;

		private bool remove_Internal_Project_ExperienceField;

		private bool remove_Internal_Project_ExperienceFieldSpecified;

		private string internal_ProjectField;

		private string descriptionField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string project_LeaderField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Internal_Project_Experience_ID
		{
			get
			{
				return this.internal_Project_Experience_IDField;
			}
			set
			{
				this.internal_Project_Experience_IDField = value;
				this.RaisePropertyChanged("Internal_Project_Experience_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Internal_Project_Experience
		{
			get
			{
				return this.remove_Internal_Project_ExperienceField;
			}
			set
			{
				this.remove_Internal_Project_ExperienceField = value;
				this.RaisePropertyChanged("Remove_Internal_Project_Experience");
			}
		}

		[XmlIgnore]
		public bool Remove_Internal_Project_ExperienceSpecified
		{
			get
			{
				return this.remove_Internal_Project_ExperienceFieldSpecified;
			}
			set
			{
				this.remove_Internal_Project_ExperienceFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Internal_Project_ExperienceSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Internal_Project
		{
			get
			{
				return this.internal_ProjectField;
			}
			set
			{
				this.internal_ProjectField = value;
				this.RaisePropertyChanged("Internal_Project");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Project_Leader
		{
			get
			{
				return this.project_LeaderField;
			}
			set
			{
				this.project_LeaderField = value;
				this.RaisePropertyChanged("Project_Leader");
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
