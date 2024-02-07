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
	public class Inventory_Transaction_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] inventory_Transaction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Inventory_Transaction_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Inventory_Transaction_Reference
		{
			get
			{
				return this.inventory_Transaction_ReferenceField;
			}
			set
			{
				this.inventory_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Reference");
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
