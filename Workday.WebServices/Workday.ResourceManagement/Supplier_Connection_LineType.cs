using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Connection_LineType : INotifyPropertyChanged
	{
		private Supplier_ConnectionObjectType supplier_Connection_ReferenceField;

		private string supplier_Connection_IDField;

		private string supplier_Connection_NameField;

		private SupplierObjectType remit_To_Supplier_ReferenceField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private Payment_TypeObjectType[] accepted_Payment_Type_ReferenceField;

		private Settlement_Bank_AccountObjectType settlement_Bank_Account_ReferenceField;

		private object itemField;

		private string remit_To_Email_AddressField;

		private object[] itemsField;

		private string payment_MemoField;

		private bool is_DefaultField;

		private bool is_DefaultFieldSpecified;

		private bool is_InactiveField;

		private bool is_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_ConnectionObjectType Supplier_Connection_Reference
		{
			get
			{
				return this.supplier_Connection_ReferenceField;
			}
			set
			{
				this.supplier_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Connection_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Supplier_Connection_ID
		{
			get
			{
				return this.supplier_Connection_IDField;
			}
			set
			{
				this.supplier_Connection_IDField = value;
				this.RaisePropertyChanged("Supplier_Connection_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Supplier_Connection_Name
		{
			get
			{
				return this.supplier_Connection_NameField;
			}
			set
			{
				this.supplier_Connection_NameField = value;
				this.RaisePropertyChanged("Supplier_Connection_Name");
			}
		}

		[XmlElement(Order = 3)]
		public SupplierObjectType Remit_To_Supplier_Reference
		{
			get
			{
				return this.remit_To_Supplier_ReferenceField;
			}
			set
			{
				this.remit_To_Supplier_ReferenceField = value;
				this.RaisePropertyChanged("Remit_To_Supplier_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payment_TypeObjectType Default_Payment_Type_Reference
		{
			get
			{
				return this.default_Payment_Type_ReferenceField;
			}
			set
			{
				this.default_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Payment_Type_Reference");
			}
		}

		[XmlElement("Accepted_Payment_Type_Reference", Order = 5)]
		public Payment_TypeObjectType[] Accepted_Payment_Type_Reference
		{
			get
			{
				return this.accepted_Payment_Type_ReferenceField;
			}
			set
			{
				this.accepted_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Accepted_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Settlement_Bank_AccountObjectType Settlement_Bank_Account_Reference
		{
			get
			{
				return this.settlement_Bank_Account_ReferenceField;
			}
			set
			{
				this.settlement_Bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_Bank_Account_Reference");
			}
		}

		[XmlElement("Remit_To_Address_ID", typeof(string), Order = 7), XmlElement("Remit_To_Address_Reference", typeof(Unique_IdentifierObjectType), Order = 7)]
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

		[XmlElement(Order = 8)]
		public string Remit_To_Email_Address
		{
			get
			{
				return this.remit_To_Email_AddressField;
			}
			set
			{
				this.remit_To_Email_AddressField = value;
				this.RaisePropertyChanged("Remit_To_Email_Address");
			}
		}

		[XmlElement("Payee_Alternate_Name", typeof(Supplier_Connection_Payee_Alternate_NameType), Order = 9), XmlElement("Payee_Alternate_Name_Reference", typeof(Unique_IdentifierObjectType), Order = 9)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(Order = 10)]
		public string Payment_Memo
		{
			get
			{
				return this.payment_MemoField;
			}
			set
			{
				this.payment_MemoField = value;
				this.RaisePropertyChanged("Payment_Memo");
			}
		}

		[XmlElement(Order = 11)]
		public bool Is_Default
		{
			get
			{
				return this.is_DefaultField;
			}
			set
			{
				this.is_DefaultField = value;
				this.RaisePropertyChanged("Is_Default");
			}
		}

		[XmlIgnore]
		public bool Is_DefaultSpecified
		{
			get
			{
				return this.is_DefaultFieldSpecified;
			}
			set
			{
				this.is_DefaultFieldSpecified = value;
				this.RaisePropertyChanged("Is_DefaultSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Is_Inactive
		{
			get
			{
				return this.is_InactiveField;
			}
			set
			{
				this.is_InactiveField = value;
				this.RaisePropertyChanged("Is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Is_InactiveSpecified
		{
			get
			{
				return this.is_InactiveFieldSpecified;
			}
			set
			{
				this.is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Is_InactiveSpecified");
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
