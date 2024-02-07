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
	public class Payee_Earnings_and_Deductions_Summary_DataType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Payee_Earning_Deduction_Code_Summary_DataType[] payee_Earnings_Summary_DataField;

		private Payee_Earning_Deduction_Code_Summary_DataType[] payee_Deductions_Summary_DataField;

		private Earning_Deduction_Code_Time_Off_DataType[] payee_Time_Off_Summary_DataField;

		private Payee_Earning_Deduction_Code_One_Time_Payment_Summary_DataType[] payee_One_Time_Payments_Summary_DataField;

		private Payee_Time_Tracking_Summary_DataType payee_Time_Tracking_Summary_DataField;

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

		[XmlArray(Order = 1), XmlArrayItem("Payee_Earning_Code_Summary_Data", IsNullable = false)]
		public Payee_Earning_Deduction_Code_Summary_DataType[] Payee_Earnings_Summary_Data
		{
			get
			{
				return this.payee_Earnings_Summary_DataField;
			}
			set
			{
				this.payee_Earnings_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_Earnings_Summary_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Payee_Deduction_Code_Summary_Data", IsNullable = false)]
		public Payee_Earning_Deduction_Code_Summary_DataType[] Payee_Deductions_Summary_Data
		{
			get
			{
				return this.payee_Deductions_Summary_DataField;
			}
			set
			{
				this.payee_Deductions_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_Deductions_Summary_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Payee_Time_Off_Data", IsNullable = false)]
		public Earning_Deduction_Code_Time_Off_DataType[] Payee_Time_Off_Summary_Data
		{
			get
			{
				return this.payee_Time_Off_Summary_DataField;
			}
			set
			{
				this.payee_Time_Off_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_Time_Off_Summary_Data");
			}
		}

		[XmlArray(Order = 4), XmlArrayItem("Payee_One_Time_Payment_Summary_Data", IsNullable = false)]
		public Payee_Earning_Deduction_Code_One_Time_Payment_Summary_DataType[] Payee_One_Time_Payments_Summary_Data
		{
			get
			{
				return this.payee_One_Time_Payments_Summary_DataField;
			}
			set
			{
				this.payee_One_Time_Payments_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_One_Time_Payments_Summary_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Payee_Time_Tracking_Summary_DataType Payee_Time_Tracking_Summary_Data
		{
			get
			{
				return this.payee_Time_Tracking_Summary_DataField;
			}
			set
			{
				this.payee_Time_Tracking_Summary_DataField = value;
				this.RaisePropertyChanged("Payee_Time_Tracking_Summary_Data");
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
