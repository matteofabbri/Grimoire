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
	public class Pay_Calculation_Balance_DataType : INotifyPropertyChanged
	{
		private Pay_Calculation_ReferenceType[] pay_Calculation_ReferenceField;

		private Balance_Period_Data_for_Get_Payroll_BalancesType[] balance_Period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Pay_Calculation_Reference", Order = 0)]
		public Pay_Calculation_ReferenceType[] Pay_Calculation_Reference
		{
			get
			{
				return this.pay_Calculation_ReferenceField;
			}
			set
			{
				this.pay_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Calculation_Reference");
			}
		}

		[XmlElement("Balance_Period_Data", Order = 1)]
		public Balance_Period_Data_for_Get_Payroll_BalancesType[] Balance_Period_Data
		{
			get
			{
				return this.balance_Period_DataField;
			}
			set
			{
				this.balance_Period_DataField = value;
				this.RaisePropertyChanged("Balance_Period_Data");
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
