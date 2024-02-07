using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Issue_Purchase_Order_OutboundType : INotifyPropertyChanged
	{
		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private decimal order_VersionField;

		private bool order_VersionFieldSpecified;

		private Requestor_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] requestorField;

		private Company_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] companyField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private DateTime timestampField;

		private bool timestampFieldSpecified;

		private string memoField;

		private decimal total_CostField;

		private bool total_CostFieldSpecified;

		private string pO_NumberField;

		private string phone_NumberField;

		private decimal phone_Area_CodeField;

		private bool phone_Area_CodeFieldSpecified;

		private decimal phone_Country_CodeField;

		private bool phone_Country_CodeFieldSpecified;

		private string phone_Country_Code_Alpha2Field;

		private string fax_NumberField;

		private decimal fax_Area_CodeField;

		private bool fax_Area_CodeFieldSpecified;

		private decimal fax_Country_CodeField;

		private bool fax_Country_CodeFieldSpecified;

		private string fax_Country_Code_Alpha2Field;

		private string emailField;

		private string payment_MethodField;

		private string cardholder_NameField;

		private string credit_Card_TokenField;

		private string credit_Card_NumberField;

		private DateTime credit_Card_Expiration_DateField;

		private bool credit_Card_Expiration_DateFieldSpecified;

		private string credit_Card_Type_IDField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private string shipping_TermsField;

		private string shipping_MethodField;

		private string shipping_InstructionField;

		private Bill_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] bill_ToField;

		private Bill_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] bill_To_ContactField;

		private Ship_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] ship_ToField;

		private Ship_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] ship_To_ContactField;

		private Supplier_Reference_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] supplier_Reference_DataField;

		private Unique_Name_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] unique_Name_Info_DataField;

		private Purchase_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] pO_LineField;

		private ProjectBased_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] dO_LineField;

		private Resource_Order__Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] rO_LineField;

		private Taxable_Code_Application_NO_INPUT_DataType[] tax_Code_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] pO_AttachmentsField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_OrderObjectType Purchase_Order_Reference
		{
			get
			{
				return this.purchase_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Order_Version
		{
			get
			{
				return this.order_VersionField;
			}
			set
			{
				this.order_VersionField = value;
				this.RaisePropertyChanged("Order_Version");
			}
		}

		[XmlIgnore]
		public bool Order_VersionSpecified
		{
			get
			{
				return this.order_VersionFieldSpecified;
			}
			set
			{
				this.order_VersionFieldSpecified = value;
				this.RaisePropertyChanged("Order_VersionSpecified");
			}
		}

		[XmlElement("Requestor", Order = 2)]
		public Requestor_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Requestor
		{
			get
			{
				return this.requestorField;
			}
			set
			{
				this.requestorField = value;
				this.RaisePropertyChanged("Requestor");
			}
		}

		[XmlElement("Company", Order = 3)]
		public Company_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
				this.RaisePropertyChanged("Company");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlIgnore]
		public bool Document_DateSpecified
		{
			get
			{
				return this.document_DateFieldSpecified;
			}
			set
			{
				this.document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Document_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
				this.RaisePropertyChanged("Timestamp");
			}
		}

		[XmlIgnore]
		public bool TimestampSpecified
		{
			get
			{
				return this.timestampFieldSpecified;
			}
			set
			{
				this.timestampFieldSpecified = value;
				this.RaisePropertyChanged("TimestampSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Total_Cost
		{
			get
			{
				return this.total_CostField;
			}
			set
			{
				this.total_CostField = value;
				this.RaisePropertyChanged("Total_Cost");
			}
		}

		[XmlIgnore]
		public bool Total_CostSpecified
		{
			get
			{
				return this.total_CostFieldSpecified;
			}
			set
			{
				this.total_CostFieldSpecified = value;
				this.RaisePropertyChanged("Total_CostSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string PO_Number
		{
			get
			{
				return this.pO_NumberField;
			}
			set
			{
				this.pO_NumberField = value;
				this.RaisePropertyChanged("PO_Number");
			}
		}

		[XmlElement(Order = 9)]
		public string Phone_Number
		{
			get
			{
				return this.phone_NumberField;
			}
			set
			{
				this.phone_NumberField = value;
				this.RaisePropertyChanged("Phone_Number");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Phone_Area_Code
		{
			get
			{
				return this.phone_Area_CodeField;
			}
			set
			{
				this.phone_Area_CodeField = value;
				this.RaisePropertyChanged("Phone_Area_Code");
			}
		}

		[XmlIgnore]
		public bool Phone_Area_CodeSpecified
		{
			get
			{
				return this.phone_Area_CodeFieldSpecified;
			}
			set
			{
				this.phone_Area_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Phone_Area_CodeSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Phone_Country_Code
		{
			get
			{
				return this.phone_Country_CodeField;
			}
			set
			{
				this.phone_Country_CodeField = value;
				this.RaisePropertyChanged("Phone_Country_Code");
			}
		}

		[XmlIgnore]
		public bool Phone_Country_CodeSpecified
		{
			get
			{
				return this.phone_Country_CodeFieldSpecified;
			}
			set
			{
				this.phone_Country_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Phone_Country_CodeSpecified");
			}
		}

		[XmlElement("Phone_Country_Code_Alpha-2", Order = 12)]
		public string Phone_Country_Code_Alpha2
		{
			get
			{
				return this.phone_Country_Code_Alpha2Field;
			}
			set
			{
				this.phone_Country_Code_Alpha2Field = value;
				this.RaisePropertyChanged("Phone_Country_Code_Alpha2");
			}
		}

		[XmlElement(Order = 13)]
		public string Fax_Number
		{
			get
			{
				return this.fax_NumberField;
			}
			set
			{
				this.fax_NumberField = value;
				this.RaisePropertyChanged("Fax_Number");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Fax_Area_Code
		{
			get
			{
				return this.fax_Area_CodeField;
			}
			set
			{
				this.fax_Area_CodeField = value;
				this.RaisePropertyChanged("Fax_Area_Code");
			}
		}

		[XmlIgnore]
		public bool Fax_Area_CodeSpecified
		{
			get
			{
				return this.fax_Area_CodeFieldSpecified;
			}
			set
			{
				this.fax_Area_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Fax_Area_CodeSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Fax_Country_Code
		{
			get
			{
				return this.fax_Country_CodeField;
			}
			set
			{
				this.fax_Country_CodeField = value;
				this.RaisePropertyChanged("Fax_Country_Code");
			}
		}

		[XmlIgnore]
		public bool Fax_Country_CodeSpecified
		{
			get
			{
				return this.fax_Country_CodeFieldSpecified;
			}
			set
			{
				this.fax_Country_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Fax_Country_CodeSpecified");
			}
		}

		[XmlElement("Fax_Country_Code_Alpha-2", Order = 16)]
		public string Fax_Country_Code_Alpha2
		{
			get
			{
				return this.fax_Country_Code_Alpha2Field;
			}
			set
			{
				this.fax_Country_Code_Alpha2Field = value;
				this.RaisePropertyChanged("Fax_Country_Code_Alpha2");
			}
		}

		[XmlElement(Order = 17)]
		public string Email
		{
			get
			{
				return this.emailField;
			}
			set
			{
				this.emailField = value;
				this.RaisePropertyChanged("Email");
			}
		}

		[XmlElement(Order = 18)]
		public string Payment_Method
		{
			get
			{
				return this.payment_MethodField;
			}
			set
			{
				this.payment_MethodField = value;
				this.RaisePropertyChanged("Payment_Method");
			}
		}

		[XmlElement(Order = 19)]
		public string Cardholder_Name
		{
			get
			{
				return this.cardholder_NameField;
			}
			set
			{
				this.cardholder_NameField = value;
				this.RaisePropertyChanged("Cardholder_Name");
			}
		}

		[XmlElement(Order = 20)]
		public string Credit_Card_Token
		{
			get
			{
				return this.credit_Card_TokenField;
			}
			set
			{
				this.credit_Card_TokenField = value;
				this.RaisePropertyChanged("Credit_Card_Token");
			}
		}

		[XmlElement(Order = 21)]
		public string Credit_Card_Number
		{
			get
			{
				return this.credit_Card_NumberField;
			}
			set
			{
				this.credit_Card_NumberField = value;
				this.RaisePropertyChanged("Credit_Card_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Credit_Card_Expiration_Date
		{
			get
			{
				return this.credit_Card_Expiration_DateField;
			}
			set
			{
				this.credit_Card_Expiration_DateField = value;
				this.RaisePropertyChanged("Credit_Card_Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_Expiration_DateSpecified
		{
			get
			{
				return this.credit_Card_Expiration_DateFieldSpecified;
			}
			set
			{
				this.credit_Card_Expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public string Credit_Card_Type_ID
		{
			get
			{
				return this.credit_Card_Type_IDField;
			}
			set
			{
				this.credit_Card_Type_IDField = value;
				this.RaisePropertyChanged("Credit_Card_Type_ID");
			}
		}

		[XmlElement(Order = 24)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string Shipping_Terms
		{
			get
			{
				return this.shipping_TermsField;
			}
			set
			{
				this.shipping_TermsField = value;
				this.RaisePropertyChanged("Shipping_Terms");
			}
		}

		[XmlElement(Order = 28)]
		public string Shipping_Method
		{
			get
			{
				return this.shipping_MethodField;
			}
			set
			{
				this.shipping_MethodField = value;
				this.RaisePropertyChanged("Shipping_Method");
			}
		}

		[XmlElement(Order = 29)]
		public string Shipping_Instruction
		{
			get
			{
				return this.shipping_InstructionField;
			}
			set
			{
				this.shipping_InstructionField = value;
				this.RaisePropertyChanged("Shipping_Instruction");
			}
		}

		[XmlElement("Bill_To", Order = 30)]
		public Bill_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Bill_To
		{
			get
			{
				return this.bill_ToField;
			}
			set
			{
				this.bill_ToField = value;
				this.RaisePropertyChanged("Bill_To");
			}
		}

		[XmlElement("Bill_To_Contact", Order = 31)]
		public Bill_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Bill_To_Contact
		{
			get
			{
				return this.bill_To_ContactField;
			}
			set
			{
				this.bill_To_ContactField = value;
				this.RaisePropertyChanged("Bill_To_Contact");
			}
		}

		[XmlElement("Ship_To", Order = 32)]
		public Ship_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Ship_To
		{
			get
			{
				return this.ship_ToField;
			}
			set
			{
				this.ship_ToField = value;
				this.RaisePropertyChanged("Ship_To");
			}
		}

		[XmlElement("Ship_To_Contact", Order = 33)]
		public Ship_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Ship_To_Contact
		{
			get
			{
				return this.ship_To_ContactField;
			}
			set
			{
				this.ship_To_ContactField = value;
				this.RaisePropertyChanged("Ship_To_Contact");
			}
		}

		[XmlElement("Supplier_Reference_Data", Order = 34)]
		public Supplier_Reference_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Supplier_Reference_Data
		{
			get
			{
				return this.supplier_Reference_DataField;
			}
			set
			{
				this.supplier_Reference_DataField = value;
				this.RaisePropertyChanged("Supplier_Reference_Data");
			}
		}

		[XmlElement("Unique_Name_Info_Data", Order = 35)]
		public Unique_Name_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] Unique_Name_Info_Data
		{
			get
			{
				return this.unique_Name_Info_DataField;
			}
			set
			{
				this.unique_Name_Info_DataField = value;
				this.RaisePropertyChanged("Unique_Name_Info_Data");
			}
		}

		[XmlElement("PO_Line", Order = 36)]
		public Purchase_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] PO_Line
		{
			get
			{
				return this.pO_LineField;
			}
			set
			{
				this.pO_LineField = value;
				this.RaisePropertyChanged("PO_Line");
			}
		}

		[XmlElement("DO_Line", Order = 37)]
		public ProjectBased_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] DO_Line
		{
			get
			{
				return this.dO_LineField;
			}
			set
			{
				this.dO_LineField = value;
				this.RaisePropertyChanged("DO_Line");
			}
		}

		[XmlElement("RO_Line", Order = 38)]
		public Resource_Order__Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType[] RO_Line
		{
			get
			{
				return this.rO_LineField;
			}
			set
			{
				this.rO_LineField = value;
				this.RaisePropertyChanged("RO_Line");
			}
		}

		[XmlElement("Tax_Code_Data", Order = 39)]
		public Taxable_Code_Application_NO_INPUT_DataType[] Tax_Code_Data
		{
			get
			{
				return this.tax_Code_DataField;
			}
			set
			{
				this.tax_Code_DataField = value;
				this.RaisePropertyChanged("Tax_Code_Data");
			}
		}

		[XmlArray(Order = 40), XmlArrayItem("Attachment_Data", typeof(Business_Document_Attachment_with_External_Option_DataType), IsNullable = false)]
		public Business_Document_Attachment_with_External_Option_DataType[] PO_Attachments
		{
			get
			{
				return this.pO_AttachmentsField;
			}
			set
			{
				this.pO_AttachmentsField = value;
				this.RaisePropertyChanged("PO_Attachments");
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
