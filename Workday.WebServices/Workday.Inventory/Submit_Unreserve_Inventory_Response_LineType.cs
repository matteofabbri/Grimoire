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
	public class Submit_Unreserve_Inventory_Response_LineType : INotifyPropertyChanged
	{
		private Inventory_Stock_Request_LineObjectType inventory_Stock_Request_Line_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Stock_Request_LineObjectType Inventory_Stock_Request_Line_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Line_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Line_Reference");
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
