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
	public class Supplier_Invoice_History_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private string supplier_Reference_NumberField;

		private DateTime invoice_DateField;

		private bool invoice_DateFieldSpecified;

		private decimal total_Invoice_AmountField;

		private bool total_Invoice_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string external_PO_NumberField;

		private string invoice_NumberField;

		private string source_Integration_SystemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public OrganizationObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Supplier_Reference", Order = 1)]
		public Resource_ProviderObjectType[] Supplier_Reference
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

		[XmlElement(Order = 2)]
		public string Supplier_Reference_Number
		{
			get
			{
				return this.supplier_Reference_NumberField;
			}
			set
			{
				this.supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Reference_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlIgnore]
		public bool Invoice_DateSpecified
		{
			get
			{
				return this.invoice_DateFieldSpecified;
			}
			set
			{
				this.invoice_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Total_Invoice_Amount
		{
			get
			{
				return this.total_Invoice_AmountField;
			}
			set
			{
				this.total_Invoice_AmountField = value;
				this.RaisePropertyChanged("Total_Invoice_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Invoice_AmountSpecified
		{
			get
			{
				return this.total_Invoice_AmountFieldSpecified;
			}
			set
			{
				this.total_Invoice_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Invoice_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public string External_PO_Number
		{
			get
			{
				return this.external_PO_NumberField;
			}
			set
			{
				this.external_PO_NumberField = value;
				this.RaisePropertyChanged("External_PO_Number");
			}
		}

		[XmlElement(Order = 7)]
		public string Invoice_Number
		{
			get
			{
				return this.invoice_NumberField;
			}
			set
			{
				this.invoice_NumberField = value;
				this.RaisePropertyChanged("Invoice_Number");
			}
		}

		[XmlElement(Order = 8)]
		public string Source_Integration_System
		{
			get
			{
				return this.source_Integration_SystemField;
			}
			set
			{
				this.source_Integration_SystemField = value;
				this.RaisePropertyChanged("Source_Integration_System");
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
