using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_CAN_Year_End_Form_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] payroll_CAN_Year_End_Form_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_CAN_Year_End_Form_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Payroll_CAN_Year_End_Form_Reference
		{
			get
			{
				return this.payroll_CAN_Year_End_Form_ReferenceField;
			}
			set
			{
				this.payroll_CAN_Year_End_Form_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_CAN_Year_End_Form_Reference");
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
