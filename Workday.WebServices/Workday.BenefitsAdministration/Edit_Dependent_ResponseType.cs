using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Dependent_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType event_ReferenceField;

		private WorkerObjectType employee_ReferenceField;

		private DependentObjectType dependent_ReferenceField;

		private Exception_DataType[][] exception_Response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
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
		public DependentObjectType Dependent_Reference
		{
			get
			{
				return this.dependent_ReferenceField;
			}
			set
			{
				this.dependent_ReferenceField = value;
				this.RaisePropertyChanged("Dependent_Reference");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Exceptions_Data", typeof(Exception_DataType[]), IsNullable = false), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false, NestingLevel = 1)]
		public Exception_DataType[][] Exception_Response_Data
		{
			get
			{
				return this.exception_Response_DataField;
			}
			set
			{
				this.exception_Response_DataField = value;
				this.RaisePropertyChanged("Exception_Response_Data");
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
