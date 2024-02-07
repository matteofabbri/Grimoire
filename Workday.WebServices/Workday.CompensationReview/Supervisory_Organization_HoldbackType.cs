using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supervisory_Organization_HoldbackType : INotifyPropertyChanged
	{
		private string award_TypeField;

		private decimal holdback_AmountField;

		private bool holdback_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Type
		{
			get
			{
				return this.award_TypeField;
			}
			set
			{
				this.award_TypeField = value;
				this.RaisePropertyChanged("Award_Type");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Holdback_Amount
		{
			get
			{
				return this.holdback_AmountField;
			}
			set
			{
				this.holdback_AmountField = value;
				this.RaisePropertyChanged("Holdback_Amount");
			}
		}

		[XmlIgnore]
		public bool Holdback_AmountSpecified
		{
			get
			{
				return this.holdback_AmountFieldSpecified;
			}
			set
			{
				this.holdback_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Holdback_AmountSpecified");
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
