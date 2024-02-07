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
	public class Put_Goods_Delivery_Rule_RequestType : INotifyPropertyChanged
	{
		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private Goods_Delivery_RuleObjectType goods_Delivery_Rule_ReferenceField;

		private Goods_Delivery_Rules_DataType goods_Delivery_Rules_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Goods_Delivery_RuleObjectType Goods_Delivery_Rule_Reference
		{
			get
			{
				return this.goods_Delivery_Rule_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rule_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Goods_Delivery_Rules_DataType Goods_Delivery_Rules_Data
		{
			get
			{
				return this.goods_Delivery_Rules_DataField;
			}
			set
			{
				this.goods_Delivery_Rules_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rules_Data");
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
