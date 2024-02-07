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
	public class Inventory_Return_Order_DataType : INotifyPropertyChanged
	{
		private string inventory_Return_Order_IDField;

		private LocationObjectType inventory_Site_ReferenceField;

		private Inventory_Return_Order_TypeObjectType inventory_Return_Order_Type_ReferenceField;

		private Document_StatusObjectType inventory_Return_Order_Status_ReferenceField;

		private DateTime return_Order_DateField;

		private bool return_Order_DateFieldSpecified;

		private Inventory_Stock_RequestObjectType inventory_Stock_Request_ReferenceField;

		private LocationObjectType returned_From_Site_ReferenceField;

		private LocationObjectType returned_From_Par_Location_ReferenceField;

		private WorkerObjectType returned_By_ReferenceField;

		private Inventory_Return_Order_Line_Data_WSType[] inventory_Return_Order_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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
		public Inventory_Return_Order_TypeObjectType Inventory_Return_Order_Type_Reference
		{
			get
			{
				return this.inventory_Return_Order_Type_ReferenceField;
			}
			set
			{
				this.inventory_Return_Order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType Inventory_Return_Order_Status_Reference
		{
			get
			{
				return this.inventory_Return_Order_Status_ReferenceField;
			}
			set
			{
				this.inventory_Return_Order_Status_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Return_Order_Date
		{
			get
			{
				return this.return_Order_DateField;
			}
			set
			{
				this.return_Order_DateField = value;
				this.RaisePropertyChanged("Return_Order_Date");
			}
		}

		[XmlIgnore]
		public bool Return_Order_DateSpecified
		{
			get
			{
				return this.return_Order_DateFieldSpecified;
			}
			set
			{
				this.return_Order_DateFieldSpecified = value;
				this.RaisePropertyChanged("Return_Order_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Inventory_Stock_RequestObjectType Inventory_Stock_Request_Reference
		{
			get
			{
				return this.inventory_Stock_Request_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public LocationObjectType Returned_From_Site_Reference
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

		[XmlElement(Order = 7)]
		public LocationObjectType Returned_From_Par_Location_Reference
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

		[XmlElement(Order = 8)]
		public WorkerObjectType Returned_By_Reference
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

		[XmlElement("Inventory_Return_Order_Line_Data", Order = 9)]
		public Inventory_Return_Order_Line_Data_WSType[] Inventory_Return_Order_Line_Data
		{
			get
			{
				return this.inventory_Return_Order_Line_DataField;
			}
			set
			{
				this.inventory_Return_Order_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Line_Data");
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
