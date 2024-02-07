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
	public class Inventory_Return_Order_Request_CriteriaType : INotifyPropertyChanged
	{
		private LocationObjectType[] inventory_Sites_ReferenceField;

		private string inventory_Return_Order_IDField;

		private Inventory_Return_Order_TypeObjectType[] inventory_Returned_Order_Type_ReferenceField;

		private Document_StatusObjectType[] document_Status_ReferenceField;

		private WorkerObjectType[] returned_By_ReferenceField;

		private LocationObjectType[] returned_From_Site_ReferenceField;

		private LocationObjectType[] returned_From_Par_Location_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Purchase_ItemObjectType[] item_ReferenceField;

		private DateTime order_Date_On_or_AfterField;

		private bool order_Date_On_or_AfterFieldSpecified;

		private DateTime order_Date_On_or_BeforeField;

		private bool order_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Sites_Reference", Order = 0)]
		public LocationObjectType[] Inventory_Sites_Reference
		{
			get
			{
				return this.inventory_Sites_ReferenceField;
			}
			set
			{
				this.inventory_Sites_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Sites_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Inventory_Return_Order_ID
		{
			get
			{
				return this.inventory_Return_Order_IDField;
			}
			set
			{
				this.inventory_Return_Order_IDField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_ID");
			}
		}

		[XmlElement("Inventory_Returned_Order_Type_Reference", Order = 2)]
		public Inventory_Return_Order_TypeObjectType[] Inventory_Returned_Order_Type_Reference
		{
			get
			{
				return this.inventory_Returned_Order_Type_ReferenceField;
			}
			set
			{
				this.inventory_Returned_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Returned_Order_Type_Reference");
			}
		}

		[XmlElement("Document_Status_Reference", Order = 3)]
		public Document_StatusObjectType[] Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement("Returned_By_Reference", Order = 4)]
		public WorkerObjectType[] Returned_By_Reference
		{
			get
			{
				return this.returned_By_ReferenceField;
			}
			set
			{
				this.returned_By_ReferenceField = value;
				this.RaisePropertyChanged("Returned_By_Reference");
			}
		}

		[XmlElement("Returned_From_Site_Reference", Order = 5)]
		public LocationObjectType[] Returned_From_Site_Reference
		{
			get
			{
				return this.returned_From_Site_ReferenceField;
			}
			set
			{
				this.returned_From_Site_ReferenceField = value;
				this.RaisePropertyChanged("Returned_From_Site_Reference");
			}
		}

		[XmlElement("Returned_From_Par_Location_Reference", Order = 6)]
		public LocationObjectType[] Returned_From_Par_Location_Reference
		{
			get
			{
				return this.returned_From_Par_Location_ReferenceField;
			}
			set
			{
				this.returned_From_Par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Returned_From_Par_Location_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 7)]
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

		[XmlElement("Item_Reference", Order = 8)]
		public Purchase_ItemObjectType[] Item_Reference
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

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Order_Date_On_or_After
		{
			get
			{
				return this.order_Date_On_or_AfterField;
			}
			set
			{
				this.order_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Order_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_AfterSpecified
		{
			get
			{
				return this.order_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Order_Date_On_or_Before
		{
			get
			{
				return this.order_Date_On_or_BeforeField;
			}
			set
			{
				this.order_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Order_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.order_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_BeforeSpecified");
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
