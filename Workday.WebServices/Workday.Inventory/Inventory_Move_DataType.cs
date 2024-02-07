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
	public class Inventory_Move_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private LocationObjectType from_Location_ReferenceField;

		private Inventory_Move_Detail_DataType[] inventory_Move_Detail_DataField;

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
		public LocationObjectType From_Location_Reference
		{
			get
			{
				return this.from_Location_ReferenceField;
			}
			set
			{
				this.from_Location_ReferenceField = value;
				this.RaisePropertyChanged("From_Location_Reference");
			}
		}

		[XmlElement("Inventory_Move_Detail_Data", Order = 2)]
		public Inventory_Move_Detail_DataType[] Inventory_Move_Detail_Data
		{
			get
			{
				return this.inventory_Move_Detail_DataField;
			}
			set
			{
				this.inventory_Move_Detail_DataField = value;
				this.RaisePropertyChanged("Inventory_Move_Detail_Data");
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
