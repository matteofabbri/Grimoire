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
	public class Inventory_Return_Order_Request_ReferencesType : INotifyPropertyChanged
	{
		private Inventory_ReturnObjectType[] inventory_Return_Order_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Return_Order_Reference", Order = 0)]
		public Inventory_ReturnObjectType[] Inventory_Return_Order_Reference
		{
			get
			{
				return this.inventory_Return_Order_ReferenceField;
			}
			set
			{
				this.inventory_Return_Order_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Reference");
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
