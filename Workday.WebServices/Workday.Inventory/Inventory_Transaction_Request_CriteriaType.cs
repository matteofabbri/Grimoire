using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Transaction_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private LocationObjectType stocking_Location_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Inventory_Transaction_TypeObjectType[] inventory_Transaction_Type_ReferenceField;

		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private DateTime transaction_Date_On_or_AfterField;

		private bool transaction_Date_On_or_AfterFieldSpecified;

		private DateTime transaction_Date_On_or_BeforeField;

		private bool transaction_Date_On_or_BeforeFieldSpecified;

		private WorkerObjectType issued_To_ReferenceField;

		private WorkerObjectType[] requester_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
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
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public LocationObjectType Stocking_Location_Reference
		{
			get
			{
				return this.stocking_Location_ReferenceField;
			}
			set
			{
				this.stocking_Location_ReferenceField = value;
				this.RaisePropertyChanged("Stocking_Location_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 3)]
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

		[XmlElement("Inventory_Transaction_Type_Reference", Order = 4)]
		public Inventory_Transaction_TypeObjectType[] Inventory_Transaction_Type_Reference
		{
			get
			{
				return this.inventory_Transaction_Type_ReferenceField;
			}
			set
			{
				this.inventory_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Purchase_ItemObjectType Inventory_Item_Reference
		{
			get
			{
				return this.inventory_Item_ReferenceField;
			}
			set
			{
				this.inventory_Item_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Item_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Transaction_Date_On_or_After
		{
			get
			{
				return this.transaction_Date_On_or_AfterField;
			}
			set
			{
				this.transaction_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Transaction_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_On_or_AfterSpecified
		{
			get
			{
				return this.transaction_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.transaction_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Transaction_Date_On_or_Before
		{
			get
			{
				return this.transaction_Date_On_or_BeforeField;
			}
			set
			{
				this.transaction_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Transaction_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.transaction_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.transaction_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Issued_To_Reference
		{
			get
			{
				return this.issued_To_ReferenceField;
			}
			set
			{
				this.issued_To_ReferenceField = value;
				this.RaisePropertyChanged("Issued_To_Reference");
			}
		}

		[XmlElement("Requester_Reference", Order = 9)]
		public WorkerObjectType[] Requester_Reference
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
