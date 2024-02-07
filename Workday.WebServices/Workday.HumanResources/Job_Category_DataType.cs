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
	public class Job_Category_DataType : INotifyPropertyChanged
	{
		private string job_Category_IDField;

		private string job_Category_NameField;

		private string job_Category_DescriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_Category_ID
		{
			get
			{
				return this.job_Category_IDField;
			}
			set
			{
				this.job_Category_IDField = value;
				this.RaisePropertyChanged("Job_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Category_Name
		{
			get
			{
				return this.job_Category_NameField;
			}
			set
			{
				this.job_Category_NameField = value;
				this.RaisePropertyChanged("Job_Category_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Category_Description
		{
			get
			{
				return this.job_Category_DescriptionField;
			}
			set
			{
				this.job_Category_DescriptionField = value;
				this.RaisePropertyChanged("Job_Category_Description");
			}
		}

		[XmlElement(Order = 3)]
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
