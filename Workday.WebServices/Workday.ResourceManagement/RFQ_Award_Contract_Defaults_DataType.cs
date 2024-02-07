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
	public class RFQ_Award_Contract_Defaults_DataType : INotifyPropertyChanged
	{
		private Supplier_Contract_TypeObjectType supplier_Contract_Type_ReferenceField;

		private WorkerObjectType buyer_ReferenceField;

		private DateTime contract_Start_DateField;

		private bool contract_Start_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private string contract_NameField;

		private WorkerObjectType contract_Specialist_ReferenceField;

		private string shipTo_ContactField;

		private Unique_IdentifierObjectType ship_To_Address_ReferenceField;

		private string billTo_ContactField;

		private Unique_IdentifierObjectType bill_To_Address_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType issue_Option_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_Contract_TypeObjectType Supplier_Contract_Type_Reference
		{
			get
			{
				return this.supplier_Contract_Type_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Buyer_Reference
		{
			get
			{
				return this.buyer_ReferenceField;
			}
			set
			{
				this.buyer_ReferenceField = value;
				this.RaisePropertyChanged("Buyer_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Contract_Start_Date
		{
			get
			{
				return this.contract_Start_DateField;
			}
			set
			{
				this.contract_Start_DateField = value;
				this.RaisePropertyChanged("Contract_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Start_DateSpecified
		{
			get
			{
				return this.contract_Start_DateFieldSpecified;
			}
			set
			{
				this.contract_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Contract_Name
		{
			get
			{
				return this.contract_NameField;
			}
			set
			{
				this.contract_NameField = value;
				this.RaisePropertyChanged("Contract_Name");
			}
		}

		[XmlElement(Order = 5)]
		public WorkerObjectType Contract_Specialist_Reference
		{
			get
			{
				return this.contract_Specialist_ReferenceField;
			}
			set
			{
				this.contract_Specialist_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Specialist_Reference");
			}
		}

		[XmlElement("Ship-To_Contact", Order = 6)]
		public string ShipTo_Contact
		{
			get
			{
				return this.shipTo_ContactField;
			}
			set
			{
				this.shipTo_ContactField = value;
				this.RaisePropertyChanged("ShipTo_Contact");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement("Bill-To_Contact", Order = 8)]
		public string BillTo_Contact
		{
			get
			{
				return this.billTo_ContactField;
			}
			set
			{
				this.billTo_ContactField = value;
				this.RaisePropertyChanged("BillTo_Contact");
			}
		}

		[XmlElement(Order = 9)]
		public Unique_IdentifierObjectType Bill_To_Address_Reference
		{
			get
			{
				return this.bill_To_Address_ReferenceField;
			}
			set
			{
				this.bill_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Address_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Purchase_Order_Issue_OptionObjectType Issue_Option_Reference
		{
			get
			{
				return this.issue_Option_ReferenceField;
			}
			set
			{
				this.issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Issue_Option_Reference");
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
