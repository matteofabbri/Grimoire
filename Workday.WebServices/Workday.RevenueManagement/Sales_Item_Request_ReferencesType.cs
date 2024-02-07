using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sales_Item_Request_ReferencesType : INotifyPropertyChanged
	{
		private Sales_ItemObjectType[] sales_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Sales_Item_Reference", Order = 0)]
		public Sales_ItemObjectType[] Sales_Item_Reference
		{
			get
			{
				return this.sales_Item_ReferenceField;
			}
			set
			{
				this.sales_Item_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Reference");
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
