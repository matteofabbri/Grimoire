using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Escheatment_WWS_ItemType : INotifyPropertyChanged
	{
		private Escheatment_ItemObjectType escheatment_Item_ReferenceField;

		private Escheatment_Item_DataType escheatment_Item_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Escheatment_ItemObjectType Escheatment_Item_Reference
		{
			get
			{
				return this.escheatment_Item_ReferenceField;
			}
			set
			{
				this.escheatment_Item_ReferenceField = value;
				this.RaisePropertyChanged("Escheatment_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Escheatment_Item_DataType Escheatment_Item_Data
		{
			get
			{
				return this.escheatment_Item_DataField;
			}
			set
			{
				this.escheatment_Item_DataField = value;
				this.RaisePropertyChanged("Escheatment_Item_Data");
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
