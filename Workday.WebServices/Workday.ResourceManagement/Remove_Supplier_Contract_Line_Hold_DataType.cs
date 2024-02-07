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
	public class Remove_Supplier_Contract_Line_Hold_DataType : INotifyPropertyChanged
	{
		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private Supplier_Contract_Line_Replacement_DataType[] goods_Line_Remove_Hold_DataField;

		private Supplier_Contract_Service_Line_Replacement_DataType[] service_Line_Remove_Hold_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement("Goods_Line_Remove_Hold_Data", Order = 1)]
		public Supplier_Contract_Line_Replacement_DataType[] Goods_Line_Remove_Hold_Data
		{
			get
			{
				return this.goods_Line_Remove_Hold_DataField;
			}
			set
			{
				this.goods_Line_Remove_Hold_DataField = value;
				this.RaisePropertyChanged("Goods_Line_Remove_Hold_Data");
			}
		}

		[XmlElement("Service_Line_Remove_Hold_Data", Order = 2)]
		public Supplier_Contract_Service_Line_Replacement_DataType[] Service_Line_Remove_Hold_Data
		{
			get
			{
				return this.service_Line_Remove_Hold_DataField;
			}
			set
			{
				this.service_Line_Remove_Hold_DataField = value;
				this.RaisePropertyChanged("Service_Line_Remove_Hold_Data");
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
