using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Interface_Contribution_DataType : INotifyPropertyChanged
	{
		private decimal contribution_AmountField;

		private bool contribution_AmountFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Contribution_Amount
		{
			get
			{
				return this.contribution_AmountField;
			}
			set
			{
				this.contribution_AmountField = value;
				this.RaisePropertyChanged("Contribution_Amount");
			}
		}

		[XmlIgnore]
		public bool Contribution_AmountSpecified
		{
			get
			{
				return this.contribution_AmountFieldSpecified;
			}
			set
			{
				this.contribution_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Contribution_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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
