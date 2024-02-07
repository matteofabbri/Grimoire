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
	public class Tax_Authority_DataType : INotifyPropertyChanged
	{
		private string tax_Authority_Reference_IDField;

		private string tax_Authority_NameField;

		private object itemField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private CurrencyObjectType currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Authority_Reference_ID
		{
			get
			{
				return this.tax_Authority_Reference_IDField;
			}
			set
			{
				this.tax_Authority_Reference_IDField = value;
				this.RaisePropertyChanged("Tax_Authority_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Authority_Name
		{
			get
			{
				return this.tax_Authority_NameField;
			}
			set
			{
				this.tax_Authority_NameField = value;
				this.RaisePropertyChanged("Tax_Authority_Name");
			}
		}

		[XmlElement("Create_Tax_Authority_from_Customer_Reference", typeof(Billable_EntityObjectType), Order = 2), XmlElement("Create_Tax_Authority_from_Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 2), XmlElement("Create_Tax_Authority_from_Investor_Reference", typeof(InvestorObjectType), Order = 2), XmlElement("Create_Tax_Authority_from_Supplier_Reference", typeof(SupplierObjectType), Order = 2)]
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

		[XmlElement(Order = 3)]
		public Business_Entity_WWS_DataType Business_Entity_Data
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

		[XmlElement("Settlement_Account_Data", Order = 5)]
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

		[XmlElement("Attachment_Data", Order = 6)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
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
