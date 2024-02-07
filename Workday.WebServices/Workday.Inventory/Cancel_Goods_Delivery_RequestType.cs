using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cancel_Goods_Delivery_RequestType : INotifyPropertyChanged
	{
		private Goods_DeliveryObjectType goods_Delivery_ReferenceField;

		private Cancel_Goods_Delivery_DataType cancel_Goods_Delivery_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_DeliveryObjectType Goods_Delivery_Reference
		{
			get
			{
				return this.goods_Delivery_ReferenceField;
			}
			set
			{
				this.goods_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cancel_Goods_Delivery_DataType Cancel_Goods_Delivery_Data
		{
			get
			{
				return this.cancel_Goods_Delivery_DataField;
			}
			set
			{
				this.cancel_Goods_Delivery_DataField = value;
				this.RaisePropertyChanged("Cancel_Goods_Delivery_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
