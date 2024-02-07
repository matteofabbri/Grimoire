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
	public class Payroll_Payee_EIC_Election_for_State_and_LocalType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private decimal number_of_AllowancesField;

		private bool number_of_AllowancesFieldSpecified;

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
		public bool Exempt
		{
			get
			{
				return this.exemptField;
			}
			set
			{
				this.exemptField = value;
				this.RaisePropertyChanged("Exempt");
			}
		}

		[XmlIgnore]
		public bool ExemptSpecified
		{
			get
			{
				return this.exemptFieldSpecified;
			}
			set
			{
				this.exemptFieldSpecified = value;
				this.RaisePropertyChanged("ExemptSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_of_Allowances
		{
			get
			{
				return this.number_of_AllowancesField;
			}
			set
			{
				this.number_of_AllowancesField = value;
				this.RaisePropertyChanged("Number_of_Allowances");
			}
		}

		[XmlIgnore]
		public bool Number_of_AllowancesSpecified
		{
			get
			{
				return this.number_of_AllowancesFieldSpecified;
			}
			set
			{
				this.number_of_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_AllowancesSpecified");
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
