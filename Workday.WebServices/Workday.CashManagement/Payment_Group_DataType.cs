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
	public class Payment_Group_DataType : INotifyPropertyChanged
	{
		private Payment_GroupObjectType payment_Group_ReferenceField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Payment_MethodObjectType payment_Method_ReferenceField;

		private Payment_CategoryObjectType payment_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_GroupObjectType Payment_Group_Reference
		{
			get
			{
				return this.payment_Group_ReferenceField;
			}
			set
			{
				this.payment_Group_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Group_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
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

		[XmlElement(Order = 3)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payment_MethodObjectType Payment_Method_Reference
		{
			get
			{
				return this.payment_Method_ReferenceField;
			}
			set
			{
				this.payment_Method_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Method_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Payment_CategoryObjectType Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
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
