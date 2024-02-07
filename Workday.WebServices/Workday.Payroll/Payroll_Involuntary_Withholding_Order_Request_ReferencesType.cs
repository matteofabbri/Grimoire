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
	public class Payroll_Involuntary_Withholding_Order_Request_ReferencesType : INotifyPropertyChanged
	{
		private Withholding_OrderObjectType[] payroll_Involuntary_Withholding_Order_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Involuntary_Withholding_Order_Reference", Order = 0)]
		public Withholding_OrderObjectType[] Payroll_Involuntary_Withholding_Order_Reference
		{
			get
			{
				return this.payroll_Involuntary_Withholding_Order_ReferenceField;
			}
			set
			{
				this.payroll_Involuntary_Withholding_Order_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Involuntary_Withholding_Order_Reference");
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
