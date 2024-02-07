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
	public class Inventory_Shipment_Line_Data_for_Put_AwayType : INotifyPropertyChanged
	{
		private Inventory_Ship_List_LineObjectType inventory_Ship_List_Line_ReferenceField;

		private LocationObjectType stocking_Location_ReferenceField;

		private string memo_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Ship_List_LineObjectType Inventory_Ship_List_Line_Reference
		{
			get
			{
				return this.inventory_Ship_List_Line_ReferenceField;
			}
			set
			{
				this.inventory_Ship_List_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Ship_List_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Memo_Reference
		{
			get
			{
				return this.memo_ReferenceField;
			}
			set
			{
				this.memo_ReferenceField = value;
				this.RaisePropertyChanged("Memo_Reference");
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
