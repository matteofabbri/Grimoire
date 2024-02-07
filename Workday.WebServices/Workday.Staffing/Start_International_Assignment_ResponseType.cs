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
	public class Start_International_Assignment_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType start_International_Assignment_ReferenceField;

		private WorkerObjectType employee_ReferenceField;

		private Position_ElementObjectType job_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Start_International_Assignment_Reference
		{
			get
			{
				return this.start_International_Assignment_ReferenceField;
			}
			set
			{
				this.start_International_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Start_International_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Position_ElementObjectType Job_Reference
		{
			get
			{
				return this.job_ReferenceField;
			}
			set
			{
				this.job_ReferenceField = value;
				this.RaisePropertyChanged("Job_Reference");
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
