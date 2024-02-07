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
	public class Supplier_Invoice_Adjustment_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Business_Entity_Status_ValueObjectType[] supplier_Status_ReferenceField;

		private DateTime invoice_Date_On_or_AfterField;

		private bool invoice_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Date_On_or_BeforeField;

		private bool invoice_Date_On_or_BeforeFieldSpecified;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private SupplierObjectType[] supplier_Hierarchy_ReferenceField;

		private bool invoice_On_HoldField;

		private bool invoice_On_HoldFieldSpecified;

		private bool intercompany_InvoiceField;

		private bool intercompany_InvoiceFieldSpecified;

		private Document_Payment_StatusObjectType[] payment_Status_ReferenceField;

		private Invoice_Adjustment_ReasonObjectType[] adjustment_Reasons_ReferenceField;

		private DateTime invoice_Due_Date_On_or_AfterField;

		private bool invoice_Due_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Due_Date_On_or_BeforeField;

		private bool invoice_Due_Date_On_or_BeforeFieldSpecified;

		private WorkerObjectType[] created_By_Worker_ReferenceField;

		private WorkerObjectType[] approving_Worker_ReferenceField;

		private string external_PO_NumberField;

		private Document_StatusObjectType[] invoice_Status_ReferenceField;

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

		[XmlElement("Supplier_Status_Reference", Order = 2)]
		public Business_Entity_Status_ValueObjectType[] Supplier_Status_Reference
		{
			get
			{
				return this.supplier_Status_ReferenceField;
			}
			set
			{
				this.supplier_Status_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Invoice_Date_On_or_After
		{
			get
			{
				return this.invoice_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Invoice_Date_On_or_Before
		{
			get
			{
				return this.invoice_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Supplier_Hierarchy_Reference", Order = 6)]
		public SupplierObjectType[] Supplier_Hierarchy_Reference
		{
			get
			{
				return this.supplier_Hierarchy_ReferenceField;
			}
			set
			{
				this.supplier_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Invoice_On_Hold
		{
			get
			{
				return this.invoice_On_HoldField;
			}
			set
			{
				this.invoice_On_HoldField = value;
				this.RaisePropertyChanged("Invoice_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Invoice_On_HoldSpecified
		{
			get
			{
				return this.invoice_On_HoldFieldSpecified;
			}
			set
			{
				this.invoice_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_On_HoldSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Intercompany_Invoice
		{
			get
			{
				return this.intercompany_InvoiceField;
			}
			set
			{
				this.intercompany_InvoiceField = value;
				this.RaisePropertyChanged("Intercompany_Invoice");
			}
		}

		[XmlIgnore]
		public bool Intercompany_InvoiceSpecified
		{
			get
			{
				return this.intercompany_InvoiceFieldSpecified;
			}
			set
			{
				this.intercompany_InvoiceFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_InvoiceSpecified");
			}
		}

		[XmlElement("Payment_Status_Reference", Order = 9)]
		public Document_Payment_StatusObjectType[] Payment_Status_Reference
		{
			get
			{
				return this.payment_Status_ReferenceField;
			}
			set
			{
				this.payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Status_Reference");
			}
		}

		[XmlElement("Adjustment_Reasons_Reference", Order = 10)]
		public Invoice_Adjustment_ReasonObjectType[] Adjustment_Reasons_Reference
		{
			get
			{
				return this.adjustment_Reasons_ReferenceField;
			}
			set
			{
				this.adjustment_Reasons_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reasons_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Invoice_Due_Date_On_or_After
		{
			get
			{
				return this.invoice_Due_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Due_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Due_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Due_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Due_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Invoice_Due_Date_On_or_Before
		{
			get
			{
				return this.invoice_Due_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Due_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Due_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Due_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Due_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Created_By_Worker_Reference", Order = 13)]
		public WorkerObjectType[] Created_By_Worker_Reference
		{
			get
			{
				return this.created_By_Worker_ReferenceField;
			}
			set
			{
				this.created_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Worker_Reference");
			}
		}

		[XmlElement("Approving_Worker_Reference", Order = 14)]
		public WorkerObjectType[] Approving_Worker_Reference
		{
			get
			{
				return this.approving_Worker_ReferenceField;
			}
			set
			{
				this.approving_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Approving_Worker_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement("Invoice_Status_Reference", Order = 16)]
		public Document_StatusObjectType[] Invoice_Status_Reference
		{
			get
			{
				return this.invoice_Status_ReferenceField;
			}
			set
			{
				this.invoice_Status_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Status_Reference");
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
