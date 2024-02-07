using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ledger_Account_DataType : INotifyPropertyChanged
	{
		private string ledger_Account_IdentifierField;

		private string ledger_Account_NameField;

		private Ledger_Account_TypeObjectType ledger_Account_Type_ReferenceField;

		private bool retiredField;

		private bool retiredFieldSpecified;

		private OrganizationObjectType[] restricted_To_Company_or_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ledger_Account_Identifier
		{
			get
			{
				return this.ledger_Account_IdentifierField;
			}
			set
			{
				this.ledger_Account_IdentifierField = value;
				this.RaisePropertyChanged("Ledger_Account_Identifier");
			}
		}

		[XmlElement(Order = 1)]
		public string Ledger_Account_Name
		{
			get
			{
				return this.ledger_Account_NameField;
			}
			set
			{
				this.ledger_Account_NameField = value;
				this.RaisePropertyChanged("Ledger_Account_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_Account_TypeObjectType Ledger_Account_Type_Reference
		{
			get
			{
				return this.ledger_Account_Type_ReferenceField;
			}
			set
			{
				this.ledger_Account_Type_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Retired
		{
			get
			{
				return this.retiredField;
			}
			set
			{
				this.retiredField = value;
				this.RaisePropertyChanged("Retired");
			}
		}

		[XmlIgnore]
		public bool RetiredSpecified
		{
			get
			{
				return this.retiredFieldSpecified;
			}
			set
			{
				this.retiredFieldSpecified = value;
				this.RaisePropertyChanged("RetiredSpecified");
			}
		}

		[XmlElement("Restricted_To_Company_or_Hierarchy_Reference", Order = 4)]
		public OrganizationObjectType[] Restricted_To_Company_or_Hierarchy_Reference
		{
			get
			{
				return this.restricted_To_Company_or_Hierarchy_ReferenceField;
			}
			set
			{
				this.restricted_To_Company_or_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Company_or_Hierarchy_Reference");
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
