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
	public class Return_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private string return_NumberField;

		private Document_StatusObjectType[] return_Status_ReferenceField;

		private DateTime return_Date_On_or_AfterField;

		private bool return_Date_On_or_AfterFieldSpecified;

		private DateTime return_Date_On_or_BeforeField;

		private bool return_Date_On_or_BeforeFieldSpecified;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Return_to_Supplier_ReasonObjectType[] return_Reason_ReferenceField;

		private object itemField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Procurement_ItemObjectType[] item_ReferenceField;

		private string supplier_RMAField;

		private Unique_IdentifierObjectType[] created_by_Person_ReferenceField;

		private WorkerObjectType[] approving_Worker_ReferenceField;

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

		[XmlElement(Order = 1)]
		public string Return_Number
		{
			get
			{
				return this.return_NumberField;
			}
			set
			{
				this.return_NumberField = value;
				this.RaisePropertyChanged("Return_Number");
			}
		}

		[XmlElement("Return_Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Return_Status_Reference
		{
			get
			{
				return this.return_Status_ReferenceField;
			}
			set
			{
				this.return_Status_ReferenceField = value;
				this.RaisePropertyChanged("Return_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Return_Date_On_or_After
		{
			get
			{
				return this.return_Date_On_or_AfterField;
			}
			set
			{
				this.return_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Return_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Return_Date_On_or_AfterSpecified
		{
			get
			{
				return this.return_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.return_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Return_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Return_Date_On_or_Before
		{
			get
			{
				return this.return_Date_On_or_BeforeField;
			}
			set
			{
				this.return_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Return_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Return_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.return_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.return_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Return_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Supplier_Reference", Order = 5)]
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

		[XmlElement("Return_Reason_Reference", Order = 6)]
		public Return_to_Supplier_ReasonObjectType[] Return_Reason_Reference
		{
			get
			{
				return this.return_Reason_ReferenceField;
			}
			set
			{
				this.return_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Return_Reason_Reference");
			}
		}

		[XmlElement("Purchase_Order_Reference", typeof(Purchase_OrderObjectType), Order = 7), XmlElement("Supplier_Contract_Reference", typeof(Supplier_ContractObjectType), Order = 7)]
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

		[XmlElement("Spend_Category_Reference", Order = 8)]
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

		[XmlElement("Item_Reference", Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Supplier_RMA
		{
			get
			{
				return this.supplier_RMAField;
			}
			set
			{
				this.supplier_RMAField = value;
				this.RaisePropertyChanged("Supplier_RMA");
			}
		}

		[XmlElement("Created_by_Person_Reference", Order = 11)]
		public Unique_IdentifierObjectType[] Created_by_Person_Reference
		{
			get
			{
				return this.created_by_Person_ReferenceField;
			}
			set
			{
				this.created_by_Person_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Person_Reference");
			}
		}

		[XmlElement("Approving_Worker_Reference", Order = 12)]
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
