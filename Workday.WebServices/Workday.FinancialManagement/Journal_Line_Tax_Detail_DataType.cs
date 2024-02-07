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
	public class Journal_Line_Tax_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_DateField;

		private Tax_TypeObjectType tax_Type_ReferenceField;

		private decimal taxable_AmountField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_RateObjectType tax_Rate_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_Recoverability_TypeObjectType tax_Recoverability_ReferenceField;

		private SupplierObjectType supplier_ReferenceField;

		private CustomerObjectType customer_ReferenceField;

		private string external_Business_Entity_NameField;

		private string external_Business_Entity_AddressField;

		private string external_Business_Entity_Tax_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_TypeObjectType Tax_Type_Reference
		{
			get
			{
				return this.tax_Type_ReferenceField;
			}
			set
			{
				this.tax_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Taxable_Amount
		{
			get
			{
				return this.taxable_AmountField;
			}
			set
			{
				this.taxable_AmountField = value;
				this.RaisePropertyChanged("Taxable_Amount");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Tax_RateObjectType Tax_Rate_Reference
		{
			get
			{
				return this.tax_Rate_ReferenceField;
			}
			set
			{
				this.tax_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Rate_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Tax_Recoverability_TypeObjectType Tax_Recoverability_Reference
		{
			get
			{
				return this.tax_Recoverability_ReferenceField;
			}
			set
			{
				this.tax_Recoverability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Recoverability_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public SupplierObjectType Supplier_Reference
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

		[XmlElement(Order = 8)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string External_Business_Entity_Name
		{
			get
			{
				return this.external_Business_Entity_NameField;
			}
			set
			{
				this.external_Business_Entity_NameField = value;
				this.RaisePropertyChanged("External_Business_Entity_Name");
			}
		}

		[XmlElement(Order = 10)]
		public string External_Business_Entity_Address
		{
			get
			{
				return this.external_Business_Entity_AddressField;
			}
			set
			{
				this.external_Business_Entity_AddressField = value;
				this.RaisePropertyChanged("External_Business_Entity_Address");
			}
		}

		[XmlElement(Order = 11)]
		public string External_Business_Entity_Tax_ID
		{
			get
			{
				return this.external_Business_Entity_Tax_IDField;
			}
			set
			{
				this.external_Business_Entity_Tax_IDField = value;
				this.RaisePropertyChanged("External_Business_Entity_Tax_ID");
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
