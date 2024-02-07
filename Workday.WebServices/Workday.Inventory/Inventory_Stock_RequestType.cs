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
	public class Inventory_Stock_RequestType : INotifyPropertyChanged
	{
		private Inventory_Stock_RequestObjectType inventory_Stock_Request_ReferenceField;

		private Inventory_Stock_Request_outbound_DataType[] inventory_Stock_Request_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Inventory_Stock_Request_Data", Order = 1)]
		public Inventory_Stock_Request_outbound_DataType[] Inventory_Stock_Request_Data
		{
			get
			{
				return this.inventory_Stock_Request_DataField;
			}
			set
			{
				this.inventory_Stock_Request_DataField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Data");
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
