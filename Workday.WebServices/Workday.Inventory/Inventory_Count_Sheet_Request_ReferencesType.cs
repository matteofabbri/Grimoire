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
	public class Inventory_Count_Sheet_Request_ReferencesType : INotifyPropertyChanged
	{
		private Inventory_Count_SheetObjectType[] inventory_Count_Sheet_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Count_Sheet_Reference", Order = 0)]
		public Inventory_Count_SheetObjectType[] Inventory_Count_Sheet_Reference
		{
			get
			{
				return this.inventory_Count_Sheet_ReferenceField;
			}
			set
			{
				this.inventory_Count_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Count_Sheet_Reference");
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
