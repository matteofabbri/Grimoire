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
	public class Requisition_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_or_Company_Hierarchy_ReferenceField;

		private string requisition_IDField;

		private WorkerObjectType requester_ReferenceField;

		private Requisition_TypeObjectType[] requisition_Type_ReferenceField;

		private WorkerObjectType[] requisition_Sourcing_Buyer_ReferenceField;

		private CurrencyObjectType requisition_Currency_ReferenceField;

		private DateTime requisition_Date_On_or_AfterField;

		private DateTime requisition_Date_On_or_BeforeField;

		private bool itemField;

		private ItemChoiceType1 itemElementNameField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Supplier_ContractObjectType[] contract_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Procurement_ItemObjectType[] item_ReferenceField;

		private Purchase_OrderObjectType[] purchase_Order_ReferenceField;

		private WorkerObjectType[] approving_Worker_ReferenceField;

		private WorkerObjectType[] created_by_Worker_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_or_Company_Hierarchy_Reference", Order = 0)]
		public OrganizationObjectType[] Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Requisition_ID
		{
			get
			{
				return this.requisition_IDField;
			}
			set
			{
				this.requisition_IDField = value;
				this.RaisePropertyChanged("Requisition_ID");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement("Requisition_Type_Reference", Order = 3)]
		public Requisition_TypeObjectType[] Requisition_Type_Reference
		{
			get
			{
				return this.requisition_Type_ReferenceField;
			}
			set
			{
				this.requisition_Type_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Type_Reference");
			}
		}

		[XmlElement("Requisition_Sourcing_Buyer_Reference", Order = 4)]
		public WorkerObjectType[] Requisition_Sourcing_Buyer_Reference
		{
			get
			{
				return this.requisition_Sourcing_Buyer_ReferenceField;
			}
			set
			{
				this.requisition_Sourcing_Buyer_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Sourcing_Buyer_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public CurrencyObjectType Requisition_Currency_Reference
		{
			get
			{
				return this.requisition_Currency_ReferenceField;
			}
			set
			{
				this.requisition_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Requisition_Date_On_or_After
		{
			get
			{
				return this.requisition_Date_On_or_AfterField;
			}
			set
			{
				this.requisition_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Requisition_Date_On_or_After");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Requisition_Date_On_or_Before
		{
			get
			{
				return this.requisition_Date_On_or_BeforeField;
			}
			set
			{
				this.requisition_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Requisition_Date_On_or_Before");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Fully_Sourced", typeof(bool), Order = 8), XmlElement("Has_Unsourced_Lines", typeof(bool), Order = 8)]
		public bool Item
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

		[XmlElement(Order = 9), XmlIgnore]
		public ItemChoiceType1 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Supplier_Reference", Order = 10)]
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

		[XmlElement("Contract_Reference", Order = 11)]
		public Supplier_ContractObjectType[] Contract_Reference
		{
			get
			{
				return this.contract_ReferenceField;
			}
			set
			{
				this.contract_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 12)]
		public Spend_CategoryObjectType[] Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement("Item_Reference", Order = 13)]
		public Procurement_ItemObjectType[] Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement("Purchase_Order_Reference", Order = 14)]
		public Purchase_OrderObjectType[] Purchase_Order_Reference
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

		[XmlElement("Approving_Worker_Reference", Order = 15)]
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

		[XmlElement("Created_by_Worker_Reference", Order = 16)]
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

		[XmlElement("Worktags_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
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
