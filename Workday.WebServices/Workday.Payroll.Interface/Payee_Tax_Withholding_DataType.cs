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
	public class Payee_Tax_Withholding_DataType : INotifyPropertyChanged
	{
		private Payee_T1_Withholding_DataType[] payee_T1_Withholding_DataField;

		private Payee_W4_Withholding_DataType[] payee_W4_Withholding_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payee_T1_Withholding_Data", Order = 0)]
		public Payee_T1_Withholding_DataType[] Payee_T1_Withholding_Data
		{
			get
			{
				return this.payee_T1_Withholding_DataField;
			}
			set
			{
				this.payee_T1_Withholding_DataField = value;
				this.RaisePropertyChanged("Payee_T1_Withholding_Data");
			}
		}

		[XmlElement("Payee_W-4_Withholding_Data", Order = 1)]
		public Payee_W4_Withholding_DataType[] Payee_W4_Withholding_Data
		{
			get
			{
				return this.payee_W4_Withholding_DataField;
			}
			set
			{
				this.payee_W4_Withholding_DataField = value;
				this.RaisePropertyChanged("Payee_W4_Withholding_Data");
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
