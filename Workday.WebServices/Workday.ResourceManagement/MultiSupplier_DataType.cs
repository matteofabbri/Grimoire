using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Multi-Supplier_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class MultiSupplier_DataType : INotifyPropertyChanged
	{
		private bool itemField;

		private ItemChoiceType3 itemElementNameField;

		private Supplier_List_Entry_DataType[] supplier_List_Entry_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Allow_All_Suppliers", typeof(bool), Order = 0), XmlElement("From_Supplier_List_Only", typeof(bool), Order = 0)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType3 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Supplier_List_Entry_Data", Order = 2)]
		public Supplier_List_Entry_DataType[] Supplier_List_Entry_Data
		{
			get
			{
				return this.supplier_List_Entry_DataField;
			}
			set
			{
				this.supplier_List_Entry_DataField = value;
				this.RaisePropertyChanged("Supplier_List_Entry_Data");
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
