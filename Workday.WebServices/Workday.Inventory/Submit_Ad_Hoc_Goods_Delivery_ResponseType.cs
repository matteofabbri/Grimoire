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
	public class Submit_Ad_Hoc_Goods_Delivery_ResponseType : INotifyPropertyChanged
	{
		private Goods_DeliveryObjectType goods_Delivery_ReferenceField;

		private Exception_DataType[][] exceptions_Response_DataField;

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

		[XmlArray(Order = 1), XmlArrayItem("Exceptions_Data", typeof(Exception_DataType[]), IsNullable = false), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false, NestingLevel = 1)]
		public Exception_DataType[][] Exceptions_Response_Data
		{
			get
			{
				return this.exceptions_Response_DataField;
			}
			set
			{
				this.exceptions_Response_DataField = value;
				this.RaisePropertyChanged("Exceptions_Response_Data");
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