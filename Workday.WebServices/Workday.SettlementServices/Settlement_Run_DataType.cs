using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Settlement_Run_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType organization_ReferenceField;

		private object[] itemsField;

		private CurrencyObjectType display_Currency_ReferenceField;

		private string settlement_Run_NameField;

		private DateTime payment_DateField;

		private Settlement_Run_FilterObjectType[] auto_Select_Filters_ReferenceField;

		private bool include_Payments_on_Behalf_of_Other_CompaniesField;

		private bool include_Payments_on_Behalf_of_Other_CompaniesFieldSpecified;

		private bool exclude_Negative_PaymentsField;

		private bool exclude_Negative_PaymentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("All_Currencies_Reference", typeof(bool), Order = 1), XmlElement("Currency_Reference", typeof(CurrencyObjectType), Order = 1)]
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

		[XmlElement(Order = 2)]
		public CurrencyObjectType Display_Currency_Reference
		{
			get
			{
				return this.display_Currency_ReferenceField;
			}
			set
			{
				this.display_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Display_Currency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Settlement_Run_Name
		{
			get
			{
				return this.settlement_Run_NameField;
			}
			set
			{
				this.settlement_Run_NameField = value;
				this.RaisePropertyChanged("Settlement_Run_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlElement("Auto_Select_Filters_Reference", Order = 5)]
		public Settlement_Run_FilterObjectType[] Auto_Select_Filters_Reference
		{
			get
			{
				return this.auto_Select_Filters_ReferenceField;
			}
			set
			{
				this.auto_Select_Filters_ReferenceField = value;
				this.RaisePropertyChanged("Auto_Select_Filters_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Payments_on_Behalf_of_Other_Companies
		{
			get
			{
				return this.include_Payments_on_Behalf_of_Other_CompaniesField;
			}
			set
			{
				this.include_Payments_on_Behalf_of_Other_CompaniesField = value;
				this.RaisePropertyChanged("Include_Payments_on_Behalf_of_Other_Companies");
			}
		}

		[XmlIgnore]
		public bool Include_Payments_on_Behalf_of_Other_CompaniesSpecified
		{
			get
			{
				return this.include_Payments_on_Behalf_of_Other_CompaniesFieldSpecified;
			}
			set
			{
				this.include_Payments_on_Behalf_of_Other_CompaniesFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payments_on_Behalf_of_Other_CompaniesSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Exclude_Negative_Payments
		{
			get
			{
				return this.exclude_Negative_PaymentsField;
			}
			set
			{
				this.exclude_Negative_PaymentsField = value;
				this.RaisePropertyChanged("Exclude_Negative_Payments");
			}
		}

		[XmlIgnore]
		public bool Exclude_Negative_PaymentsSpecified
		{
			get
			{
				return this.exclude_Negative_PaymentsFieldSpecified;
			}
			set
			{
				this.exclude_Negative_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Negative_PaymentsSpecified");
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
