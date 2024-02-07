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
	public class Supplier_Order_ContractType : INotifyPropertyChanged
	{
		private Supplier_ContractObjectType supplier_Order_Contract_ReferenceField;

		private Supplier_Order_Contract_Data_for_Put_and_GetType supplier_Order_Contract_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_ContractObjectType Supplier_Order_Contract_Reference
		{
			get
			{
				return this.supplier_Order_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Order_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Order_Contract_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Supplier_Order_Contract_Data_for_Put_and_GetType Supplier_Order_Contract_Data
		{
			get
			{
				return this.supplier_Order_Contract_DataField;
			}
			set
			{
				this.supplier_Order_Contract_DataField = value;
				this.RaisePropertyChanged("Supplier_Order_Contract_Data");
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
