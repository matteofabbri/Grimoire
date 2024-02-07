using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Support_Order_Detail_DataType : INotifyPropertyChanged
	{
		private decimal order_Form_AmountField;

		private bool order_Form_AmountFieldSpecified;

		private decimal itemField;

		private ItemChoiceType3 itemElementNameField;

		private Support_TypeObjectType support_Type_ReferenceField;

		private bool arrears_Over_12_WeeksField;

		private bool arrears_Over_12_WeeksFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Order_Form_Amount
		{
			get
			{
				return this.order_Form_AmountField;
			}
			set
			{
				this.order_Form_AmountField = value;
				this.RaisePropertyChanged("Order_Form_Amount");
			}
		}

		[XmlIgnore]
		public bool Order_Form_AmountSpecified
		{
			get
			{
				return this.order_Form_AmountFieldSpecified;
			}
			set
			{
				this.order_Form_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Order_Form_AmountSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Amount_as_Percent", typeof(decimal), Order = 1), XmlElement("Pay_Period_Amount_Override", typeof(decimal), Order = 1)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 2), XmlIgnore]
		public ItemChoiceType3 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 3)]
		public Support_TypeObjectType Support_Type_Reference
		{
			get
			{
				return this.support_Type_ReferenceField;
			}
			set
			{
				this.support_Type_ReferenceField = value;
				this.RaisePropertyChanged("Support_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Arrears_Over_12_Weeks
		{
			get
			{
				return this.arrears_Over_12_WeeksField;
			}
			set
			{
				this.arrears_Over_12_WeeksField = value;
				this.RaisePropertyChanged("Arrears_Over_12_Weeks");
			}
		}

		[XmlIgnore]
		public bool Arrears_Over_12_WeeksSpecified
		{
			get
			{
				return this.arrears_Over_12_WeeksFieldSpecified;
			}
			set
			{
				this.arrears_Over_12_WeeksFieldSpecified = value;
				this.RaisePropertyChanged("Arrears_Over_12_WeeksSpecified");
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
