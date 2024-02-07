using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Payroll_Involuntary_Withholding_Order_RequestType : INotifyPropertyChanged
	{
		private object itemField;

		private Payroll_Involuntary_Withholding_Order_DataType payroll_Involuntary_Withholding_Order_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Involuntary_Withholding_Order_Reference", typeof(Withholding_OrderObjectType), Order = 0), XmlElement("Payroll_Support_Order_Amend_or_Terminate_Data", typeof(Payroll_Support_Order_Amend_or_Terminate_DataType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Payroll_Involuntary_Withholding_Order_DataType Payroll_Involuntary_Withholding_Order_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
