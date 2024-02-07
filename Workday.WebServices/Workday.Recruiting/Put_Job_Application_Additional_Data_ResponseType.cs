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
	public class Put_Job_Application_Additional_Data_ResponseType : INotifyPropertyChanged
	{
		private Job_ApplicationObjectType job_Application_Additional_Data_ReferenceField;

		private Non_Effective_Dated_Web_Service_Additional_DataType job_Application_Additional_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_ApplicationObjectType Job_Application_Additional_Data_Reference
		{
			get
			{
				return this.job_Application_Additional_Data_ReferenceField;
			}
			set
			{
				this.job_Application_Additional_Data_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Additional_Data_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Non_Effective_Dated_Web_Service_Additional_DataType Job_Application_Additional_Data
		{
			get
			{
				return this.job_Application_Additional_DataField;
			}
			set
			{
				this.job_Application_Additional_DataField = value;
				this.RaisePropertyChanged("Job_Application_Additional_Data");
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
