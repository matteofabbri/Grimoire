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
	public class Inventory_Par_Count_Request_ReferencesType : INotifyPropertyChanged
	{
		private Inventory_Par_CountObjectType[] inventory_Par_Count_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Par_Count_Reference", Order = 0)]
		public Inventory_Par_CountObjectType[] Inventory_Par_Count_Reference
		{
			get
			{
				return this.inventory_Par_Count_ReferenceField;
			}
			set
			{
				this.inventory_Par_Count_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Par_Count_Reference");
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
