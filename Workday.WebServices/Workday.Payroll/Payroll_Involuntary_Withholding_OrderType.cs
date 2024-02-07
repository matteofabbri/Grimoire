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
	public class Payroll_Involuntary_Withholding_OrderType : INotifyPropertyChanged
	{
		private Withholding_OrderObjectType payroll_Involuntary_Withholding_Order_ReferenceField;

		private Payroll_Involuntary_Withholding_Order_DataType[] payroll_Involuntary_Withholding_Order_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Withholding_OrderObjectType Payroll_Involuntary_Withholding_Order_Reference
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

		[XmlElement("Payroll_Involuntary_Withholding_Order_Data", Order = 1)]
		public Payroll_Involuntary_Withholding_Order_DataType[] Payroll_Involuntary_Withholding_Order_Data
		{
			get
			{
				return this.payroll_Involuntary_Withholding_Order_DataField;
			}
			set
			{
				this.payroll_Involuntary_Withholding_Order_DataField = value;
				this.RaisePropertyChanged("Payroll_Involuntary_Withholding_Order_Data");
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
