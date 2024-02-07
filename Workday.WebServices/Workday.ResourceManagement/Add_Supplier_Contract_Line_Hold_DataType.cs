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
	public class Add_Supplier_Contract_Line_Hold_DataType : INotifyPropertyChanged
	{
		private string supplier_Contract_IDField;

		private Goods_Line_Add_Hold_DataType[] supplier_Contract_Line_Add_Hold_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Contract_ID
		{
			get
			{
				return this.supplier_Contract_IDField;
			}
			set
			{
				this.supplier_Contract_IDField = value;
				this.RaisePropertyChanged("Supplier_Contract_ID");
			}
		}

		[XmlElement("Supplier_Contract_Line_Add_Hold_Data", Order = 1)]
		public Goods_Line_Add_Hold_DataType[] Supplier_Contract_Line_Add_Hold_Data
		{
			get
			{
				return this.supplier_Contract_Line_Add_Hold_DataField;
			}
			set
			{
				this.supplier_Contract_Line_Add_Hold_DataField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Add_Hold_Data");
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
