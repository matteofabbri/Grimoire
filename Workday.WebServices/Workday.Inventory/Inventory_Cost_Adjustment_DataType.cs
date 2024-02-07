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
	public class Inventory_Cost_Adjustment_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private Inventory_Cost_Adjustment_Detail_DataType[] inventory_Cost_Adjustment_Detail_DataField;

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

		[XmlElement("Inventory_Cost_Adjustment_Detail_Data", Order = 1)]
		public Inventory_Cost_Adjustment_Detail_DataType[] Inventory_Cost_Adjustment_Detail_Data
		{
			get
			{
				return this.inventory_Cost_Adjustment_Detail_DataField;
			}
			set
			{
				this.inventory_Cost_Adjustment_Detail_DataField = value;
				this.RaisePropertyChanged("Inventory_Cost_Adjustment_Detail_Data");
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
