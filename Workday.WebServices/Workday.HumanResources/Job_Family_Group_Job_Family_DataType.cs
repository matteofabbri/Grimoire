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
	public class Job_Family_Group_Job_Family_DataType : INotifyPropertyChanged
	{
		private string job_Family_NameField;

		private string job_Family_SummaryField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Job_Profile_Summary_DataType[] job_Profile_Info_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_Family_Name
		{
			get
			{
				return this.job_Family_NameField;
			}
			set
			{
				this.job_Family_NameField = value;
				this.RaisePropertyChanged("Job_Family_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Family_Summary
		{
			get
			{
				return this.job_Family_SummaryField;
			}
			set
			{
				this.job_Family_SummaryField = value;
				this.RaisePropertyChanged("Job_Family_Summary");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Job_Profile_Info_Data", Order = 3)]
		public Job_Profile_Summary_DataType[] Job_Profile_Info_Data
		{
			get
			{
				return this.job_Profile_Info_DataField;
			}
			set
			{
				this.job_Profile_Info_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Info_Data");
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
