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
	public class Item_Lot_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string lot_IdentifierField;

		private Purchase_ItemObjectType purchase_Item_ReferenceField;

		private ManufacturerObjectType lot_Manufacturer_ReferenceField;

		private DateTime manufacture_DateField;

		private bool manufacture_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private Document_StatusObjectType lot_Status_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Lot_Identifier
		{
			get
			{
				return this.lot_IdentifierField;
			}
			set
			{
				this.lot_IdentifierField = value;
				this.RaisePropertyChanged("Lot_Identifier");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_ItemObjectType Purchase_Item_Reference
		{
			get
			{
				return this.purchase_Item_ReferenceField;
			}
			set
			{
				this.purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public ManufacturerObjectType Lot_Manufacturer_Reference
		{
			get
			{
				return this.lot_Manufacturer_ReferenceField;
			}
			set
			{
				this.lot_Manufacturer_ReferenceField = value;
				this.RaisePropertyChanged("Lot_Manufacturer_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Manufacture_Date
		{
			get
			{
				return this.manufacture_DateField;
			}
			set
			{
				this.manufacture_DateField = value;
				this.RaisePropertyChanged("Manufacture_Date");
			}
		}

		[XmlIgnore]
		public bool Manufacture_DateSpecified
		{
			get
			{
				return this.manufacture_DateFieldSpecified;
			}
			set
			{
				this.manufacture_DateFieldSpecified = value;
				this.RaisePropertyChanged("Manufacture_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Document_StatusObjectType Lot_Status_Reference
		{
			get
			{
				return this.lot_Status_ReferenceField;
			}
			set
			{
				this.lot_Status_ReferenceField = value;
				this.RaisePropertyChanged("Lot_Status_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
