using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_Agency_Payout_Terms_DataType : INotifyPropertyChanged
	{
		private Recruiting_Agency_Fee_TypeObjectType recruiting_Agency_Fee_Type_ReferenceField;

		private decimal fee_ValueField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_Agency_Fee_TypeObjectType Recruiting_Agency_Fee_Type_Reference
		{
			get
			{
				return this.recruiting_Agency_Fee_Type_ReferenceField;
			}
			set
			{
				this.recruiting_Agency_Fee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Agency_Fee_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Fee_Value
		{
			get
			{
				return this.fee_ValueField;
			}
			set
			{
				this.fee_ValueField = value;
				this.RaisePropertyChanged("Fee_Value");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
