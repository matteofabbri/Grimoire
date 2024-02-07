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
	public class Payroll_Payee_RPP_or_DPSP_Registration_NumberType : INotifyPropertyChanged
	{
		private Payroll_Payee_RPP_or_DPSP_Registration_NumbersObjectType payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField;

		private Payroll_Payee_RPP_or_DPSP_Registration_Number_DataType[] payroll_Payee_RPP_or_DPSP_Registration_Number_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_RPP_or_DPSP_Registration_NumbersObjectType Payroll_Payee_RPP_or_DPSP_Registration_Number_Reference
		{
			get
			{
				return this.payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField;
			}
			set
			{
				this.payroll_Payee_RPP_or_DPSP_Registration_Number_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_RPP_or_DPSP_Registration_Number_Reference");
			}
		}

		[XmlElement("Payroll_Payee_RPP_or_DPSP_Registration_Number_Data", Order = 1)]
		public Payroll_Payee_RPP_or_DPSP_Registration_Number_DataType[] Payroll_Payee_RPP_or_DPSP_Registration_Number_Data
		{
			get
			{
				return this.payroll_Payee_RPP_or_DPSP_Registration_Number_DataField;
			}
			set
			{
				this.payroll_Payee_RPP_or_DPSP_Registration_Number_DataField = value;
				this.RaisePropertyChanged("Payroll_Payee_RPP_or_DPSP_Registration_Number_Data");
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
