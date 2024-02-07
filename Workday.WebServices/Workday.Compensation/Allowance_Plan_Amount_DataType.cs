using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allowance_Plan_Amount_DataType : INotifyPropertyChanged
	{
		private decimal amountField;

		private bool amountFieldSpecified;

		private Allowance_Plan_Amount_Based_Profile_Replacement_DataType[] allowance_Plan_Amount_Based_Profile_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement("Allowance_Plan_Amount_Based_Profile_Replacement_Data", Order = 1)]
		public Allowance_Plan_Amount_Based_Profile_Replacement_DataType[] Allowance_Plan_Amount_Based_Profile_Replacement_Data
		{
			get
			{
				return this.allowance_Plan_Amount_Based_Profile_Replacement_DataField;
			}
			set
			{
				this.allowance_Plan_Amount_Based_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Allowance_Plan_Amount_Based_Profile_Replacement_Data");
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
