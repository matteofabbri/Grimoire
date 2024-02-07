using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allowed_for_Tax_Deduction_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private bool allowed_for_Tax_DeductionField;

		private bool allowed_for_Tax_DeductionFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Allowed_for_Tax_Deduction
		{
			get
			{
				return this.allowed_for_Tax_DeductionField;
			}
			set
			{
				this.allowed_for_Tax_DeductionField = value;
				this.RaisePropertyChanged("Allowed_for_Tax_Deduction");
			}
		}

		[XmlIgnore]
		public bool Allowed_for_Tax_DeductionSpecified
		{
			get
			{
				return this.allowed_for_Tax_DeductionFieldSpecified;
			}
			set
			{
				this.allowed_for_Tax_DeductionFieldSpecified = value;
				this.RaisePropertyChanged("Allowed_for_Tax_DeductionSpecified");
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
