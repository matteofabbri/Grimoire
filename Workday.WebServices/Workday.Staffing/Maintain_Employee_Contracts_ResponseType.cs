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
	public class Maintain_Employee_Contracts_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType employee_Contract_Event_ReferenceField;

		private Employee_ContractObjectType[] employee_Contract_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Employee_Contract_Event_Reference
		{
			get
			{
				return this.employee_Contract_Event_ReferenceField;
			}
			set
			{
				this.employee_Contract_Event_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Contract_Event_Reference");
			}
		}

		[XmlElement("Employee_Contract_Reference", Order = 1)]
		public Employee_ContractObjectType[] Employee_Contract_Reference
		{
			get
			{
				return this.employee_Contract_ReferenceField;
			}
			set
			{
				this.employee_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Contract_Reference");
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
