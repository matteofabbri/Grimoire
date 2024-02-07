using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_History_Company_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private Job_History_IndustryObjectType[] job_History_Industry_ReferenceField;

		private bool watched_CompanyField;

		private bool watched_CompanyFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement("Job_History_Industry_Reference", Order = 2)]
		public Job_History_IndustryObjectType[] Job_History_Industry_Reference
		{
			get
			{
				return this.job_History_Industry_ReferenceField;
			}
			set
			{
				this.job_History_Industry_ReferenceField = value;
				this.RaisePropertyChanged("Job_History_Industry_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Watched_Company
		{
			get
			{
				return this.watched_CompanyField;
			}
			set
			{
				this.watched_CompanyField = value;
				this.RaisePropertyChanged("Watched_Company");
			}
		}

		[XmlIgnore]
		public bool Watched_CompanySpecified
		{
			get
			{
				return this.watched_CompanyFieldSpecified;
			}
			set
			{
				this.watched_CompanyFieldSpecified = value;
				this.RaisePropertyChanged("Watched_CompanySpecified");
			}
		}

		[XmlElement(Order = 4)]
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
