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
	public class Inventory_Pick_WWS_DataType : INotifyPropertyChanged
	{
		private string pick_List_ID_ReferenceField;

		private Inventory_Stock_RequestObjectType stock_Request_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private Unique_IdentifierObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType assigned_To_ReferenceField;

		private string document_Memo_ReferenceField;

		private Inventory_Pick_Stock_Request_Line_WWS_DataType[] inventory_Pick_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Pick_List_ID_Reference
		{
			get
			{
				return this.pick_List_ID_ReferenceField;
			}
			set
			{
				this.pick_List_ID_ReferenceField = value;
				this.RaisePropertyChanged("Pick_List_ID_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_Stock_RequestObjectType Stock_Request_Reference
		{
			get
			{
				return this.stock_Request_ReferenceField;
			}
			set
			{
				this.stock_Request_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Request_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Unique_IdentifierObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public WorkerObjectType Assigned_To_Reference
		{
			get
			{
				return this.assigned_To_ReferenceField;
			}
			set
			{
				this.assigned_To_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_To_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Document_Memo_Reference
		{
			get
			{
				return this.document_Memo_ReferenceField;
			}
			set
			{
				this.document_Memo_ReferenceField = value;
				this.RaisePropertyChanged("Document_Memo_Reference");
			}
		}

		[XmlElement("Inventory_Pick_Line_Data", Order = 6)]
		public Inventory_Pick_Stock_Request_Line_WWS_DataType[] Inventory_Pick_Line_Data
		{
			get
			{
				return this.inventory_Pick_Line_DataField;
			}
			set
			{
				this.inventory_Pick_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Pick_Line_Data");
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
