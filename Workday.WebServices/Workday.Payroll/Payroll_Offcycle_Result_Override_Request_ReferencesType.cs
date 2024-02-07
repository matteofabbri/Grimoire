using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Off-cycle_Result_Override_Request_ReferencesType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Offcycle_Result_Override_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Offcycle_Result_OverrideObjectType[] payroll_Offcycle_Payment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Off-cycle_Payment_Reference", Order = 0)]
		public Payroll_Offcycle_Result_OverrideObjectType[] Payroll_Offcycle_Payment_Reference
		{
			get
			{
				return this.payroll_Offcycle_Payment_ReferenceField;
			}
			set
			{
				this.payroll_Offcycle_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Offcycle_Payment_Reference");
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
