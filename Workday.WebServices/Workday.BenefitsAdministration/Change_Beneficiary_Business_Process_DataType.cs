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
	public class Change_Beneficiary_Business_Process_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private string beneficiary_IDField;

		private BeneficiaryObjectType beneficiary_ReferenceField;

		private object itemField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
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

		[XmlElement(Order = 1)]
		public string Beneficiary_ID
		{
			get
			{
				return this.beneficiary_IDField;
			}
			set
			{
				this.beneficiary_IDField = value;
				this.RaisePropertyChanged("Beneficiary_ID");
			}
		}

		[XmlElement(Order = 2)]
		public BeneficiaryObjectType Beneficiary_Reference
		{
			get
			{
				return this.beneficiary_ReferenceField;
			}
			set
			{
				this.beneficiary_ReferenceField = value;
				this.RaisePropertyChanged("Beneficiary_Reference");
			}
		}

		[XmlElement("Person_Data", typeof(Beneficiary_Person_DataType), Order = 3), XmlElement("Trust_Data", typeof(Beneficiary_Trust_Information_DataType), Order = 3)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
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
