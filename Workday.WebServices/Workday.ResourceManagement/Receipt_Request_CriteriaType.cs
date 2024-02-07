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
	public class Receipt_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private string receipt_NumberField;

		private DateTime receipt_Date_On_or_AfterField;

		private bool receipt_Date_On_or_AfterFieldSpecified;

		private DateTime receipt_Date_On_or_BeforeField;

		private bool receipt_Date_On_or_BeforeFieldSpecified;

		private string receipt_StatusField;

		private WorkerObjectType[] creating_Worker_ReferenceField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
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
		public string Receipt_Number
		{
			get
			{
				return this.receipt_NumberField;
			}
			set
			{
				this.receipt_NumberField = value;
				this.RaisePropertyChanged("Receipt_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Receipt_Date_On_or_After
		{
			get
			{
				return this.receipt_Date_On_or_AfterField;
			}
			set
			{
				this.receipt_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Receipt_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Receipt_Date_On_or_AfterSpecified
		{
			get
			{
				return this.receipt_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.receipt_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Receipt_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Receipt_Date_On_or_Before
		{
			get
			{
				return this.receipt_Date_On_or_BeforeField;
			}
			set
			{
				this.receipt_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Receipt_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Receipt_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.receipt_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.receipt_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Receipt_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Receipt_Status
		{
			get
			{
				return this.receipt_StatusField;
			}
			set
			{
				this.receipt_StatusField = value;
				this.RaisePropertyChanged("Receipt_Status");
			}
		}

		[XmlElement("Creating_Worker_Reference", Order = 6)]
		public WorkerObjectType[] Creating_Worker_Reference
		{
			get
			{
				return this.creating_Worker_ReferenceField;
			}
			set
			{
				this.creating_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Creating_Worker_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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
