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
	public class Supplier_Contract_Line_Renewal_DataType : INotifyPropertyChanged
	{
		private bool do_Not_AutoRenewField;

		private bool do_Not_AutoRenewFieldSpecified;

		private decimal renewal_AmountField;

		private bool renewal_AmountFieldSpecified;

		private decimal renewal_QuantityField;

		private bool renewal_QuantityFieldSpecified;

		private string renews_Line_NumberField;

		private string renewed_By_Line_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Do_Not_Auto-Renew", Order = 0)]
		public bool Do_Not_AutoRenew
		{
			get
			{
				return this.do_Not_AutoRenewField;
			}
			set
			{
				this.do_Not_AutoRenewField = value;
				this.RaisePropertyChanged("Do_Not_AutoRenew");
			}
		}

		[XmlIgnore]
		public bool Do_Not_AutoRenewSpecified
		{
			get
			{
				return this.do_Not_AutoRenewFieldSpecified;
			}
			set
			{
				this.do_Not_AutoRenewFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_AutoRenewSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Renewal_Amount
		{
			get
			{
				return this.renewal_AmountField;
			}
			set
			{
				this.renewal_AmountField = value;
				this.RaisePropertyChanged("Renewal_Amount");
			}
		}

		[XmlIgnore]
		public bool Renewal_AmountSpecified
		{
			get
			{
				return this.renewal_AmountFieldSpecified;
			}
			set
			{
				this.renewal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Renewal_Quantity
		{
			get
			{
				return this.renewal_QuantityField;
			}
			set
			{
				this.renewal_QuantityField = value;
				this.RaisePropertyChanged("Renewal_Quantity");
			}
		}

		[XmlIgnore]
		public bool Renewal_QuantitySpecified
		{
			get
			{
				return this.renewal_QuantityFieldSpecified;
			}
			set
			{
				this.renewal_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Renewal_QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Renews_Line_Number
		{
			get
			{
				return this.renews_Line_NumberField;
			}
			set
			{
				this.renews_Line_NumberField = value;
				this.RaisePropertyChanged("Renews_Line_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Renewed_By_Line_Number
		{
			get
			{
				return this.renewed_By_Line_NumberField;
			}
			set
			{
				this.renewed_By_Line_NumberField = value;
				this.RaisePropertyChanged("Renewed_By_Line_Number");
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
