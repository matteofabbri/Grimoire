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
	public class Job_Posting_Location_DataType : INotifyPropertyChanged
	{
		private LocationObjectType primary_Location_ReferenceField;

		private string external_NameField;

		private Job_Posting_Additional_Location_DataType[] job_Posting_Additional_Location_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Primary_Location_Reference
		{
			get
			{
				return this.primary_Location_ReferenceField;
			}
			set
			{
				this.primary_Location_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Name
		{
			get
			{
				return this.external_NameField;
			}
			set
			{
				this.external_NameField = value;
				this.RaisePropertyChanged("External_Name");
			}
		}

		[XmlElement("Job_Posting_Additional_Location_Data", Order = 2)]
		public Job_Posting_Additional_Location_DataType[] Job_Posting_Additional_Location_Data
		{
			get
			{
				return this.job_Posting_Additional_Location_DataField;
			}
			set
			{
				this.job_Posting_Additional_Location_DataField = value;
				this.RaisePropertyChanged("Job_Posting_Additional_Location_Data");
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
