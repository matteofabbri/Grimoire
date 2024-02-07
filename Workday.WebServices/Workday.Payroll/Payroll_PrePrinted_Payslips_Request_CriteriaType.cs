using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Pre-Printed_Payslips_Request_CriteriaType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_PrePrinted_Payslips_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime prePrinted_Payslip_Creation_From_MomentField;

		private DateTime prePrinted_Payslip_Creation_To_MomentField;

		private Pay_Run_Group_SelectionObjectType[] pay_Run_Group_Selection_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Pre-Printed_Payslip_Creation_From_Moment", Order = 0)]
		public DateTime PrePrinted_Payslip_Creation_From_Moment
		{
			get
			{
				return this.prePrinted_Payslip_Creation_From_MomentField;
			}
			set
			{
				this.prePrinted_Payslip_Creation_From_MomentField = value;
				this.RaisePropertyChanged("PrePrinted_Payslip_Creation_From_Moment");
			}
		}

		[XmlElement("Pre-Printed_Payslip_Creation_To_Moment", Order = 1)]
		public DateTime PrePrinted_Payslip_Creation_To_Moment
		{
			get
			{
				return this.prePrinted_Payslip_Creation_To_MomentField;
			}
			set
			{
				this.prePrinted_Payslip_Creation_To_MomentField = value;
				this.RaisePropertyChanged("PrePrinted_Payslip_Creation_To_Moment");
			}
		}

		[XmlElement("Pay_Run_Group_Selection_Reference", Order = 2)]
		public Pay_Run_Group_SelectionObjectType[] Pay_Run_Group_Selection_Reference
		{
			get
			{
				return this.pay_Run_Group_Selection_ReferenceField;
			}
			set
			{
				this.pay_Run_Group_Selection_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Run_Group_Selection_Reference");
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
