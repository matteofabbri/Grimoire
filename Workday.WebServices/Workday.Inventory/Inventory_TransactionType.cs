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
	public class Inventory_TransactionType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType inventory_Transaction_ReferenceField;

		private Inventory_Transaction_DataType[] inventory_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Inventory_Transaction_Reference
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

		[XmlElement("Inventory_Transaction_Data", Order = 1)]
		public Inventory_Transaction_DataType[] Inventory_Transaction_Data
		{
			get
			{
				return this.inventory_Transaction_DataField;
			}
			set
			{
				this.inventory_Transaction_DataField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Data");
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
