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
	public class Canadian_Record_of_Employment_Statutory_Holiday_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime rOE_Detail_DateField;

		private bool rOE_Detail_DateFieldSpecified;

		private decimal rOE_Detail_AmountField;

		private bool rOE_Detail_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime ROE_Detail_Date
		{
			get
			{
				return this.rOE_Detail_DateField;
			}
			set
			{
				this.rOE_Detail_DateField = value;
				this.RaisePropertyChanged("ROE_Detail_Date");
			}
		}

		[XmlIgnore]
		public bool ROE_Detail_DateSpecified
		{
			get
			{
				return this.rOE_Detail_DateFieldSpecified;
			}
			set
			{
				this.rOE_Detail_DateFieldSpecified = value;
				this.RaisePropertyChanged("ROE_Detail_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal ROE_Detail_Amount
		{
			get
			{
				return this.rOE_Detail_AmountField;
			}
			set
			{
				this.rOE_Detail_AmountField = value;
				this.RaisePropertyChanged("ROE_Detail_Amount");
			}
		}

		[XmlIgnore]
		public bool ROE_Detail_AmountSpecified
		{
			get
			{
				return this.rOE_Detail_AmountFieldSpecified;
			}
			set
			{
				this.rOE_Detail_AmountFieldSpecified = value;
				this.RaisePropertyChanged("ROE_Detail_AmountSpecified");
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
