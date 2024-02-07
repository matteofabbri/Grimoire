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
	public class Inventory_Par_CountType : INotifyPropertyChanged
	{
		private LocationObjectType par_Location_ReferenceField;

		private Inventory_Par_Count_Outbound_DataType[] inventory_Par_Count_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Par_Location_Reference
		{
			get
			{
				return this.par_Location_ReferenceField;
			}
			set
			{
				this.par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Reference");
			}
		}

		[XmlElement("Inventory_Par_Count_Data", Order = 1)]
		public Inventory_Par_Count_Outbound_DataType[] Inventory_Par_Count_Data
		{
			get
			{
				return this.inventory_Par_Count_DataField;
			}
			set
			{
				this.inventory_Par_Count_DataField = value;
				this.RaisePropertyChanged("Inventory_Par_Count_Data");
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
