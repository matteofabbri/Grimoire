using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Classification_Summary_DataType : INotifyPropertyChanged
	{
		private Job_ClassificationObjectType job_Classification_ReferenceField;

		private Job_Classification_GroupObjectType job_Group_ReferenceField;

		private bool additionalField;

		private bool additionalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_ClassificationObjectType Job_Classification_Reference
		{
			get
			{
				return this.job_Classification_ReferenceField;
			}
			set
			{
				this.job_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Job_Classification_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_Classification_GroupObjectType Job_Group_Reference
		{
			get
			{
				return this.job_Group_ReferenceField;
			}
			set
			{
				this.job_Group_ReferenceField = value;
				this.RaisePropertyChanged("Job_Group_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Additional
		{
			get
			{
				return this.additionalField;
			}
			set
			{
				this.additionalField = value;
				this.RaisePropertyChanged("Additional");
			}
		}

		[XmlIgnore]
		public bool AdditionalSpecified
		{
			get
			{
				return this.additionalFieldSpecified;
			}
			set
			{
				this.additionalFieldSpecified = value;
				this.RaisePropertyChanged("AdditionalSpecified");
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
