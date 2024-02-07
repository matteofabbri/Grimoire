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
	public class Payee_Pay_Group_Earnings_and_Deductions_DataType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Payee_Earning_DataType[] payee_Earnings_DataField;

		private Payee_Deduction_DataType[] payee_Deductions_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_GroupObjectType Pay_Group_Reference
		{
			get
			{
				return this.pay_Group_ReferenceField;
			}
			set
			{
				this.pay_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Payee_Earning_Data", IsNullable = false)]
		public Payee_Earning_DataType[] Payee_Earnings_Data
		{
			get
			{
				return this.payee_Earnings_DataField;
			}
			set
			{
				this.payee_Earnings_DataField = value;
				this.RaisePropertyChanged("Payee_Earnings_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Payee_Deduction_Data", IsNullable = false)]
		public Payee_Deduction_DataType[] Payee_Deductions_Data
		{
			get
			{
				return this.payee_Deductions_DataField;
			}
			set
			{
				this.payee_Deductions_DataField = value;
				this.RaisePropertyChanged("Payee_Deductions_Data");
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
