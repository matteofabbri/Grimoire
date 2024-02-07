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
	public class Item_Inventory_Attributes_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private bool use_ReservationsField;

		private bool use_ReservationsFieldSpecified;

		private Fulfillment_Attributes_DataType fulfillment_Attributes_DataField;

		private Replenishment_Policy_DataType replenishment_Policy_DataField;

		private Counting_Attributes_DataType counting_Attributes_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public bool Use_Reservations
		{
			get
			{
				return this.use_ReservationsField;
			}
			set
			{
				this.use_ReservationsField = value;
				this.RaisePropertyChanged("Use_Reservations");
			}
		}

		[XmlIgnore]
		public bool Use_ReservationsSpecified
		{
			get
			{
				return this.use_ReservationsFieldSpecified;
			}
			set
			{
				this.use_ReservationsFieldSpecified = value;
				this.RaisePropertyChanged("Use_ReservationsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Fulfillment_Attributes_DataType Fulfillment_Attributes_Data
		{
			get
			{
				return this.fulfillment_Attributes_DataField;
			}
			set
			{
				this.fulfillment_Attributes_DataField = value;
				this.RaisePropertyChanged("Fulfillment_Attributes_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Replenishment_Policy_DataType Replenishment_Policy_Data
		{
			get
			{
				return this.replenishment_Policy_DataField;
			}
			set
			{
				this.replenishment_Policy_DataField = value;
				this.RaisePropertyChanged("Replenishment_Policy_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Counting_Attributes_DataType Counting_Attributes_Data
		{
			get
			{
				return this.counting_Attributes_DataField;
			}
			set
			{
				this.counting_Attributes_DataField = value;
				this.RaisePropertyChanged("Counting_Attributes_Data");
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
