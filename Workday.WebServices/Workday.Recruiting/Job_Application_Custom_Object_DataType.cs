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
	public class Job_Application_Custom_Object_DataType : INotifyPropertyChanged
	{
		private Job_ApplicationObjectType job_Application_ReferenceField;

		private Non_Effective_Dated_Web_Service_Additional_DataType business_Object_Additional_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_ApplicationObjectType Job_Application_Reference
		{
			get
			{
				return this.job_Application_ReferenceField;
			}
			set
			{
				this.job_Application_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Non_Effective_Dated_Web_Service_Additional_DataType Business_Object_Additional_Data
		{
			get
			{
				return this.business_Object_Additional_DataField;
			}
			set
			{
				this.business_Object_Additional_DataField = value;
				this.RaisePropertyChanged("Business_Object_Additional_Data");
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
