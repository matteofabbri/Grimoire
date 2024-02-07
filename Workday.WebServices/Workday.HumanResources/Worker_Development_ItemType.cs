using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Development_ItemType : INotifyPropertyChanged
	{
		private Development_ItemObjectType development_Item_ReferenceField;

		private Development_Item_Version_DataType development_Item_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Development_ItemObjectType Development_Item_Reference
		{
			get
			{
				return this.development_Item_ReferenceField;
			}
			set
			{
				this.development_Item_ReferenceField = value;
				this.RaisePropertyChanged("Development_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Development_Item_Version_DataType Development_Item_Data
		{
			get
			{
				return this.development_Item_DataField;
			}
			set
			{
				this.development_Item_DataField = value;
				this.RaisePropertyChanged("Development_Item_Data");
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
