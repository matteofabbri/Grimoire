using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Off-cycle_PaymentType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Offcycle_PaymentType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_Result_OverrideObjectType payroll_Offcycle_Result_Override_ReferenceField;

		private Payroll_Offcycle_Payment_Response_DataType[] payroll_Offcycle_Payment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Off-cycle_Result_Override_Reference", Order = 0)]
		public Payroll_Offcycle_Result_OverrideObjectType Payroll_Offcycle_Result_Override_Reference
		{
			get
			{
				return this.payroll_Offcycle_Result_Override_ReferenceField;
			}
			set
			{
				this.payroll_Offcycle_Result_Override_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Offcycle_Result_Override_Reference");
			}
		}

		[XmlElement("Payroll_Off-cycle_Payment_Data", Order = 1)]
		public Payroll_Offcycle_Payment_Response_DataType[] Payroll_Offcycle_Payment_Data
		{
			get
			{
				return this.payroll_Offcycle_Payment_DataField;
			}
			set
			{
				this.payroll_Offcycle_Payment_DataField = value;
				this.RaisePropertyChanged("Payroll_Offcycle_Payment_Data");
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
