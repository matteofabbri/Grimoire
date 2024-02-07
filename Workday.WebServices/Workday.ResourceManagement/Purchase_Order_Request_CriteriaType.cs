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
	public class Purchase_Order_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private string purchase_Order_NumberField;

		private DateTime purchase_Order_Date_On_or_AfterField;

		private bool purchase_Order_Date_On_or_AfterFieldSpecified;

		private DateTime purchase_Order_Date_On_or_BeforeField;

		private bool purchase_Order_Date_On_or_BeforeFieldSpecified;

		private DateTime due_Date_On_or_AfterField;

		private bool due_Date_On_or_AfterFieldSpecified;

		private DateTime due_Date_On_or_BeforeField;

		private bool due_Date_On_or_BeforeFieldSpecified;

		private DateTime updated_From_DateField;

		private bool updated_From_DateFieldSpecified;

		private DateTime updated_To_DateField;

		private bool updated_To_DateFieldSpecified;

		private Transaction_Log_TypeObjectType[] purchase_Order_Change_Type_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType[] issue_Option_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private RequisitionObjectType requisition_ReferenceField;

		private WorkerObjectType requesting_Worker_ReferenceField;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		private WorkerObjectType[] creating_Worker_ReferenceField;

		private WorkerObjectType[] approving_Worker_ReferenceField;

		private Accounting_WorktagObjectType[] worktag_ReferenceField;

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
		public string Purchase_Order_Number
		{
			get
			{
				return this.purchase_Order_NumberField;
			}
			set
			{
				this.purchase_Order_NumberField = value;
				this.RaisePropertyChanged("Purchase_Order_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Purchase_Order_Date_On_or_After
		{
			get
			{
				return this.purchase_Order_Date_On_or_AfterField;
			}
			set
			{
				this.purchase_Order_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Purchase_Order_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Date_On_or_AfterSpecified
		{
			get
			{
				return this.purchase_Order_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.purchase_Order_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Purchase_Order_Date_On_or_Before
		{
			get
			{
				return this.purchase_Order_Date_On_or_BeforeField;
			}
			set
			{
				this.purchase_Order_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Purchase_Order_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.purchase_Order_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.purchase_Order_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Due_Date_On_or_After
		{
			get
			{
				return this.due_Date_On_or_AfterField;
			}
			set
			{
				this.due_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Due_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Due_Date_On_or_AfterSpecified
		{
			get
			{
				return this.due_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.due_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Due_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Due_Date_On_or_Before
		{
			get
			{
				return this.due_Date_On_or_BeforeField;
			}
			set
			{
				this.due_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Due_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Due_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.due_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.due_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Due_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Updated_From_Date
		{
			get
			{
				return this.updated_From_DateField;
			}
			set
			{
				this.updated_From_DateField = value;
				this.RaisePropertyChanged("Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_From_DateSpecified
		{
			get
			{
				return this.updated_From_DateFieldSpecified;
			}
			set
			{
				this.updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime Updated_To_Date
		{
			get
			{
				return this.updated_To_DateField;
			}
			set
			{
				this.updated_To_DateField = value;
				this.RaisePropertyChanged("Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_To_DateSpecified
		{
			get
			{
				return this.updated_To_DateFieldSpecified;
			}
			set
			{
				this.updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_To_DateSpecified");
			}
		}

		[XmlElement("Purchase_Order_Change_Type_Reference", Order = 9)]
		public Transaction_Log_TypeObjectType[] Purchase_Order_Change_Type_Reference
		{
			get
			{
				return this.purchase_Order_Change_Type_ReferenceField;
			}
			set
			{
				this.purchase_Order_Change_Type_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Change_Type_Reference");
			}
		}

		[XmlElement("Issue_Option_Reference", Order = 10)]
		public Purchase_Order_Issue_OptionObjectType[] Issue_Option_Reference
		{
			get
			{
				return this.issue_Option_ReferenceField;
			}
			set
			{
				this.issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Issue_Option_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public RequisitionObjectType Requisition_Reference
		{
			get
			{
				return this.requisition_ReferenceField;
			}
			set
			{
				this.requisition_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public WorkerObjectType Requesting_Worker_Reference
		{
			get
			{
				return this.requesting_Worker_ReferenceField;
			}
			set
			{
				this.requesting_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Requesting_Worker_Reference");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement("Creating_Worker_Reference", Order = 15)]
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

		[XmlElement("Approving_Worker_Reference", Order = 16)]
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

		[XmlElement("Worktag_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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
