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
	public class Counting_Attributes_DataType : INotifyPropertyChanged
	{
		private Inventory_ABC_ClassificationObjectType inventory_ABC_Classification_ReferenceField;

		private bool include_in_CountField;

		private bool include_in_CountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_ABC_ClassificationObjectType Inventory_ABC_Classification_Reference
		{
			get
			{
				return this.inventory_ABC_Classification_ReferenceField;
			}
			set
			{
				this.inventory_ABC_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_ABC_Classification_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_in_Count
		{
			get
			{
				return this.include_in_CountField;
			}
			set
			{
				this.include_in_CountField = value;
				this.RaisePropertyChanged("Include_in_Count");
			}
		}

		[XmlIgnore]
		public bool Include_in_CountSpecified
		{
			get
			{
				return this.include_in_CountFieldSpecified;
			}
			set
			{
				this.include_in_CountFieldSpecified = value;
				this.RaisePropertyChanged("Include_in_CountSpecified");
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
