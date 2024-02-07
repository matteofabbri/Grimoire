using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_PurchaseType : INotifyPropertyChanged
	{
		private Investment_Pool_PurchaseObjectType investment_Pool_Purchase_ReferenceField;

		private Investment_Pool_Purchase_DataType investment_Pool_Purchase_DataField;

		private Investment_Pool_Purchase_ValueType investment_Pool_Purchase_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Investment_Pool_PurchaseObjectType Investment_Pool_Purchase_Reference
		{
			get
			{
				return this.investment_Pool_Purchase_ReferenceField;
			}
			set
			{
				this.investment_Pool_Purchase_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Purchase_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Investment_Pool_Purchase_DataType Investment_Pool_Purchase_Data
		{
			get
			{
				return this.investment_Pool_Purchase_DataField;
			}
			set
			{
				this.investment_Pool_Purchase_DataField = value;
				this.RaisePropertyChanged("Investment_Pool_Purchase_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Investment_Pool_Purchase_ValueType Investment_Pool_Purchase_Value
		{
			get
			{
				return this.investment_Pool_Purchase_ValueField;
			}
			set
			{
				this.investment_Pool_Purchase_ValueField = value;
				this.RaisePropertyChanged("Investment_Pool_Purchase_Value");
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
