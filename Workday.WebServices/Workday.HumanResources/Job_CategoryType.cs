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
	public class Job_CategoryType : INotifyPropertyChanged
	{
		private Job_CategoryObjectType job_Category_ReferenceField;

		private Job_Category_DataType[] job_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_CategoryObjectType Job_Category_Reference
		{
			get
			{
				return this.job_Category_ReferenceField;
			}
			set
			{
				this.job_Category_ReferenceField = value;
				this.RaisePropertyChanged("Job_Category_Reference");
			}
		}

		[XmlElement("Job_Category_Data", Order = 1)]
		public Job_Category_DataType[] Job_Category_Data
		{
			get
			{
				return this.job_Category_DataField;
			}
			set
			{
				this.job_Category_DataField = value;
				this.RaisePropertyChanged("Job_Category_Data");
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
