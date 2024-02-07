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
	public class Supplier_Invoice_Installment_Replacement_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Installment_IDField;

		private Supplier_Invoice_InstallmentObjectType supplier_Invoice_Installment_ReferenceField;

		private decimal installment_NumberField;

		private bool installment_NumberFieldSpecified;

		private Document_StatusObjectType[] status_ReferenceField;

		private DateTime invoice_DateField;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private bool use_Installment_OverridesField;

		private bool use_Installment_OverridesFieldSpecified;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string memoField;

		private Supplier_Contract_Installment_Line_DataType[] supplier_Invoice_Installment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Installment_ID
		{
			get
			{
				return this.supplier_Invoice_Installment_IDField;
			}
			set
			{
				this.supplier_Invoice_Installment_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Installment_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Supplier_Invoice_InstallmentObjectType Supplier_Invoice_Installment_Reference
		{
			get
			{
				return this.supplier_Invoice_Installment_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Installment_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Installment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Installment_Number
		{
			get
			{
				return this.installment_NumberField;
			}
			set
			{
				this.installment_NumberField = value;
				this.RaisePropertyChanged("Installment_Number");
			}
		}

		[XmlIgnore]
		public bool Installment_NumberSpecified
		{
			get
			{
				return this.installment_NumberFieldSpecified;
			}
			set
			{
				this.installment_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Installment_NumberSpecified");
			}
		}

		[XmlElement("Status_Reference", Order = 3)]
		public Document_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Invoice_Date
		{
			get
			{
				return this.invoice_DateField;
			}
			set
			{
				this.invoice_DateField = value;
				this.RaisePropertyChanged("Invoice_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Supplier_InvoiceObjectType Supplier_Invoice_Reference
		{
			get
			{
				return this.supplier_Invoice_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Use_Installment_Overrides
		{
			get
			{
				return this.use_Installment_OverridesField;
			}
			set
			{
				this.use_Installment_OverridesField = value;
				this.RaisePropertyChanged("Use_Installment_Overrides");
			}
		}

		[XmlIgnore]
		public bool Use_Installment_OverridesSpecified
		{
			get
			{
				return this.use_Installment_OverridesFieldSpecified;
			}
			set
			{
				this.use_Installment_OverridesFieldSpecified = value;
				this.RaisePropertyChanged("Use_Installment_OverridesSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement("Supplier_Invoice_Installment_Line_Data", Order = 14)]
		public Supplier_Contract_Installment_Line_DataType[] Supplier_Invoice_Installment_Line_Data
		{
			get
			{
				return this.supplier_Invoice_Installment_Line_DataField;
			}
			set
			{
				this.supplier_Invoice_Installment_Line_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Installment_Line_Data");
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
