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
	public class Job_History_CompanyType : INotifyPropertyChanged
	{
		private Job_History_CompanyObjectType job_History_Company_ReferenceField;

		private Job_History_Company_DataType job_History_Company_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_History_CompanyObjectType Job_History_Company_Reference
		{
			get
			{
				return this.job_History_Company_ReferenceField;
			}
			set
			{
				this.job_History_Company_ReferenceField = value;
				this.RaisePropertyChanged("Job_History_Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_History_Company_DataType Job_History_Company_Data
		{
			get
			{
				return this.job_History_Company_DataField;
			}
			set
			{
				this.job_History_Company_DataField = value;
				this.RaisePropertyChanged("Job_History_Company_Data");
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
