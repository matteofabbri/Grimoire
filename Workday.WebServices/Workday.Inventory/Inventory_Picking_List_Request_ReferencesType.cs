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
	public class Inventory_Picking_List_Request_ReferencesType : INotifyPropertyChanged
	{
		private Inventory_Pick_ListObjectType[] inventory_Picking_List_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Picking_List_Reference", Order = 0)]
		public Inventory_Pick_ListObjectType[] Inventory_Picking_List_Reference
		{
			get
			{
				return this.inventory_Picking_List_ReferenceField;
			}
			set
			{
				this.inventory_Picking_List_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Picking_List_Reference");
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
