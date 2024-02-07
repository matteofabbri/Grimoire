using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sponsor_WWS_DataType : INotifyPropertyChanged
	{
		private string sponsor_IDField;

		private string sponsor_Reference_IDField;

		private string sponsor_NameField;

		private Sponsor_TypeObjectType sponsor_Type_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private Business_Entity_WWS_DataType[] business_Entity_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private Customer_Status_DataType[] customer_Status_DataField;

		private SponsorObjectType remitfrom_Sponsor_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private CurrencyObjectType[] accepted_Currencies_ReferenceField;

		private Delivery_MethodObjectType[] invoice_Delivery_Method_ReferenceField;

		private Delivery_MethodObjectType[] statement_Delivery_Method_ReferenceField;

		private SponsorObjectType[] included_Children_ReferenceField;

		private Business_Entity_Alternate_Name_DataType[] alternate_Name_DataField;

		private Financials_Attachment_DataType[] business_Entity_Attachment_DataField;

		private Note_WWS_DataType[] note_DataField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Sponsor_ID
		{
			get
			{
				return this.sponsor_IDField;
			}
			set
			{
				this.sponsor_IDField = value;
				this.RaisePropertyChanged("Sponsor_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sponsor_Reference_ID
		{
			get
			{
				return this.sponsor_Reference_IDField;
			}
			set
			{
				this.sponsor_Reference_IDField = value;
				this.RaisePropertyChanged("Sponsor_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Sponsor_Name
		{
			get
			{
				return this.sponsor_NameField;
			}
			set
			{
				this.sponsor_NameField = value;
				this.RaisePropertyChanged("Sponsor_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Sponsor_TypeObjectType Sponsor_Type_Reference
		{
			get
			{
				return this.sponsor_Type_ReferenceField;
			}
			set
			{
				this.sponsor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Business_Entity_Data", Order = 6)]
		public Business_Entity_WWS_DataType[] Business_Entity_Data
		{
			get
			{
				return this.business_Entity_DataField;
			}
			set
			{
				this.business_Entity_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Data");
			}
		}

		[XmlElement("Settlement_Account_Data", Order = 7)]
		public Settlement_Account_WWS_DataType[] Settlement_Account_Data
		{
			get
			{
				return this.settlement_Account_DataField;
			}
			set
			{
				this.settlement_Account_DataField = value;
				this.RaisePropertyChanged("Settlement_Account_Data");
			}
		}

		[XmlElement("Customer_Status_Data", Order = 8)]
		public Customer_Status_DataType[] Customer_Status_Data
		{
			get
			{
				return this.customer_Status_DataField;
			}
			set
			{
				this.customer_Status_DataField = value;
				this.RaisePropertyChanged("Customer_Status_Data");
			}
		}

		[XmlElement("Remit-from_Sponsor_Reference", Order = 9)]
		public SponsorObjectType Remitfrom_Sponsor_Reference
		{
			get
			{
				return this.remitfrom_Sponsor_ReferenceField;
			}
			set
			{
				this.remitfrom_Sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Remitfrom_Sponsor_Reference");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement("Accepted_Currencies_Reference", Order = 11)]
		public CurrencyObjectType[] Accepted_Currencies_Reference
		{
			get
			{
				return this.accepted_Currencies_ReferenceField;
			}
			set
			{
				this.accepted_Currencies_ReferenceField = value;
				this.RaisePropertyChanged("Accepted_Currencies_Reference");
			}
		}

		[XmlElement("Invoice_Delivery_Method_Reference", Order = 12)]
		public Delivery_MethodObjectType[] Invoice_Delivery_Method_Reference
		{
			get
			{
				return this.invoice_Delivery_Method_ReferenceField;
			}
			set
			{
				this.invoice_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Delivery_Method_Reference");
			}
		}

		[XmlElement("Statement_Delivery_Method_Reference", Order = 13)]
		public Delivery_MethodObjectType[] Statement_Delivery_Method_Reference
		{
			get
			{
				return this.statement_Delivery_Method_ReferenceField;
			}
			set
			{
				this.statement_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Statement_Delivery_Method_Reference");
			}
		}

		[XmlElement("Included_Children_Reference", Order = 14)]
		public SponsorObjectType[] Included_Children_Reference
		{
			get
			{
				return this.included_Children_ReferenceField;
			}
			set
			{
				this.included_Children_ReferenceField = value;
				this.RaisePropertyChanged("Included_Children_Reference");
			}
		}

		[XmlElement("Alternate_Name_Data", Order = 15)]
		public Business_Entity_Alternate_Name_DataType[] Alternate_Name_Data
		{
			get
			{
				return this.alternate_Name_DataField;
			}
			set
			{
				this.alternate_Name_DataField = value;
				this.RaisePropertyChanged("Alternate_Name_Data");
			}
		}

		[XmlElement("Business_Entity_Attachment_Data", Order = 16)]
		public Financials_Attachment_DataType[] Business_Entity_Attachment_Data
		{
			get
			{
				return this.business_Entity_Attachment_DataField;
			}
			set
			{
				this.business_Entity_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Attachment_Data");
			}
		}

		[XmlElement("Note_Data", Order = 17)]
		public Note_WWS_DataType[] Note_Data
		{
			get
			{
				return this.note_DataField;
			}
			set
			{
				this.note_DataField = value;
				this.RaisePropertyChanged("Note_Data");
			}
		}

		[XmlArray(Order = 18), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
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
