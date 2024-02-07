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
	public class Payroll_Run_Detail_Pay_Calc_StatusType : INotifyPropertyChanged
	{
		private Pay_GroupObjectType pay_Group_ReferenceField;

		private Run_CategoryObjectType run_Category_ReferenceField;

		private Pay_Group_Period_Pay_Calculation_Status_As_Of_NowType[] calc_StatusField;

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

		[XmlElement(Order = 1)]
		public Run_CategoryObjectType Run_Category_Reference
		{
			get
			{
				return this.run_Category_ReferenceField;
			}
			set
			{
				this.run_Category_ReferenceField = value;
				this.RaisePropertyChanged("Run_Category_Reference");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Pay_Group_Period_Pay_Calculation_Status_As_Of_Now", typeof(Pay_Group_Period_Pay_Calculation_Status_As_Of_NowType), IsNullable = false)]
		public Pay_Group_Period_Pay_Calculation_Status_As_Of_NowType[] Calc_Status
		{
			get
			{
				return this.calc_StatusField;
			}
			set
			{
				this.calc_StatusField = value;
				this.RaisePropertyChanged("Calc_Status");
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
