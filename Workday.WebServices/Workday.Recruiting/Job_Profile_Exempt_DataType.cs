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
	public class Job_Profile_Exempt_DataType : INotifyPropertyChanged
	{
		private Location_ContextObjectType location_Context_ReferenceField;

		private bool job_ExemptField;

		private bool job_ExemptFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Location_ContextObjectType Location_Context_Reference
		{
			get
			{
				return this.location_Context_ReferenceField;
			}
			set
			{
				this.location_Context_ReferenceField = value;
				this.RaisePropertyChanged("Location_Context_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Job_Exempt
		{
			get
			{
				return this.job_ExemptField;
			}
			set
			{
				this.job_ExemptField = value;
				this.RaisePropertyChanged("Job_Exempt");
			}
		}

		[XmlIgnore]
		public bool Job_ExemptSpecified
		{
			get
			{
				return this.job_ExemptFieldSpecified;
			}
			set
			{
				this.job_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("Job_ExemptSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
