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
	public class Payroll_Remittance_Absence_PlanType : INotifyPropertyChanged
	{
		private string gB_NameField;

		private string nameField;

		private decimal accruedField;

		private bool accruedFieldSpecified;

		private decimal reducedField;

		private bool reducedFieldSpecified;

		private decimal balanceField;

		private bool balanceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string GB_Name
		{
			get
			{
				return this.gB_NameField;
			}
			set
			{
				this.gB_NameField = value;
				this.RaisePropertyChanged("GB_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Accrued
		{
			get
			{
				return this.accruedField;
			}
			set
			{
				this.accruedField = value;
				this.RaisePropertyChanged("Accrued");
			}
		}

		[XmlIgnore]
		public bool AccruedSpecified
		{
			get
			{
				return this.accruedFieldSpecified;
			}
			set
			{
				this.accruedFieldSpecified = value;
				this.RaisePropertyChanged("AccruedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Reduced
		{
			get
			{
				return this.reducedField;
			}
			set
			{
				this.reducedField = value;
				this.RaisePropertyChanged("Reduced");
			}
		}

		[XmlIgnore]
		public bool ReducedSpecified
		{
			get
			{
				return this.reducedFieldSpecified;
			}
			set
			{
				this.reducedFieldSpecified = value;
				this.RaisePropertyChanged("ReducedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Balance
		{
			get
			{
				return this.balanceField;
			}
			set
			{
				this.balanceField = value;
				this.RaisePropertyChanged("Balance");
			}
		}

		[XmlIgnore]
		public bool BalanceSpecified
		{
			get
			{
				return this.balanceFieldSpecified;
			}
			set
			{
				this.balanceFieldSpecified = value;
				this.RaisePropertyChanged("BalanceSpecified");
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
