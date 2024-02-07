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
	public class Supplier_Invoice_Request_Request_CriteriaType : INotifyPropertyChanged
	{
		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private OrganizationObjectType[] company_ReferenceField;

		private Document_StatusObjectType[] invoice_Request_Status_ReferenceField;

		private DateTime invoice_Request_Date_On_or_AfterField;

		private bool invoice_Request_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Request_Date_On_or_BeforeField;

		private bool invoice_Request_Date_On_or_BeforeFieldSpecified;

		private DateTime invoice_Request_Due_Date_On_or_AfterField;

		private bool invoice_Request_Due_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Request_Due_Date_On_or_BeforeField;

		private bool invoice_Request_Due_Date_On_or_BeforeFieldSpecified;

		private WorkerObjectType[] created_by_Worker_ReferenceField;

		private WorkerObjectType[] approved_by_Worker_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Supplier_Reference", Order = 0)]
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

		[XmlElement("Company_Reference", Order = 1)]
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

		[XmlElement("Invoice_Request_Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Invoice_Request_Status_Reference
		{
			get
			{
				return this.invoice_Request_Status_ReferenceField;
			}
			set
			{
				this.invoice_Request_Status_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Request_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Invoice_Request_Date_On_or_After
		{
			get
			{
				return this.invoice_Request_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Request_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Request_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Request_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Request_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Request_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Request_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Invoice_Request_Date_On_or_Before
		{
			get
			{
				return this.invoice_Request_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Request_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Request_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Request_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Request_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Request_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Request_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Invoice_Request_Due_Date_On_or_After
		{
			get
			{
				return this.invoice_Request_Due_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Request_Due_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Request_Due_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Request_Due_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Request_Due_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Request_Due_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Request_Due_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Invoice_Request_Due_Date_On_or_Before
		{
			get
			{
				return this.invoice_Request_Due_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Request_Due_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Request_Due_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Request_Due_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Request_Due_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Request_Due_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Request_Due_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Created_by_Worker_Reference", Order = 7)]
		public WorkerObjectType[] Created_by_Worker_Reference
		{
			get
			{
				return this.created_by_Worker_ReferenceField;
			}
			set
			{
				this.created_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Worker_Reference");
			}
		}

		[XmlElement("Approved_by_Worker_Reference", Order = 8)]
		public WorkerObjectType[] Approved_by_Worker_Reference
		{
			get
			{
				return this.approved_by_Worker_ReferenceField;
			}
			set
			{
				this.approved_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Approved_by_Worker_Reference");
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
