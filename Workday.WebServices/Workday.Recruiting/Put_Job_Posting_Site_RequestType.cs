using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Job_Posting_Site_RequestType : INotifyPropertyChanged
	{
		private Job_Posting_SiteObjectType job_Posting_Site_ReferenceField;

		private Job_Posting_Site_Detail_DataType job_Posting_Site_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_Posting_SiteObjectType Job_Posting_Site_Reference
		{
			get
			{
				return this.job_Posting_Site_ReferenceField;
			}
			set
			{
				this.job_Posting_Site_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_Posting_Site_Detail_DataType Job_Posting_Site_Data
		{
			get
			{
				return this.job_Posting_Site_DataField;
			}
			set
			{
				this.job_Posting_Site_DataField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
