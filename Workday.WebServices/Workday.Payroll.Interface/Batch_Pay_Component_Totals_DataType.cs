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
	public class Batch_Pay_Component_Totals_DataType : INotifyPropertyChanged
	{
		private Input_InterfaceObjectType pay_Component_ReferenceField;

		private Input_Line_Currency_Totals_DataType[] pay_Component_Totals_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Input_InterfaceObjectType Pay_Component_Reference
		{
			get
			{
				return this.pay_Component_ReferenceField;
			}
			set
			{
				this.pay_Component_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Reference");
			}
		}

		[XmlElement("Pay_Component_Totals_Data", Order = 1)]
		public Input_Line_Currency_Totals_DataType[] Pay_Component_Totals_Data
		{
			get
			{
				return this.pay_Component_Totals_DataField;
			}
			set
			{
				this.pay_Component_Totals_DataField = value;
				this.RaisePropertyChanged("Pay_Component_Totals_Data");
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
