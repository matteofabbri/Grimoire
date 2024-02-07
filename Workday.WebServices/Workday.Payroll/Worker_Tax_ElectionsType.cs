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
	public class Worker_Tax_ElectionsType : INotifyPropertyChanged
	{
		private decimal number_of_AllowancesField;

		private bool number_of_AllowancesFieldSpecified;

		private string marital_StatusField;

		private bool exemptedField;

		private bool exemptedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Marital_Status
		{
			get
			{
				return this.marital_StatusField;
			}
			set
			{
				this.marital_StatusField = value;
				this.RaisePropertyChanged("Marital_Status");
			}
		}

		[XmlElement(Order = 2)]
		public bool Exempted
		{
			get
			{
				return this.exemptedField;
			}
			set
			{
				this.exemptedField = value;
				this.RaisePropertyChanged("Exempted");
			}
		}

		[XmlIgnore]
		public bool ExemptedSpecified
		{
			get
			{
				return this.exemptedFieldSpecified;
			}
			set
			{
				this.exemptedFieldSpecified = value;
				this.RaisePropertyChanged("ExemptedSpecified");
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
