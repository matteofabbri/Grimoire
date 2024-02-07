using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_List_Entry_DataType : INotifyPropertyChanged
	{
		private SupplierObjectType supplier_ReferenceField;

		private bool inactive_as_List_EntryField;

		private bool inactive_as_List_EntryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public SupplierObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Inactive_as_List_Entry
		{
			get
			{
				return this.inactive_as_List_EntryField;
			}
			set
			{
				this.inactive_as_List_EntryField = value;
				this.RaisePropertyChanged("Inactive_as_List_Entry");
			}
		}

		[XmlIgnore]
		public bool Inactive_as_List_EntrySpecified
		{
			get
			{
				return this.inactive_as_List_EntryFieldSpecified;
			}
			set
			{
				this.inactive_as_List_EntryFieldSpecified = value;
				this.RaisePropertyChanged("Inactive_as_List_EntrySpecified");
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
