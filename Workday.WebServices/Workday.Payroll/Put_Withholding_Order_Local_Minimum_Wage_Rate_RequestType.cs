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
	public class Put_Withholding_Order_Local_Minimum_Wage_Rate_RequestType : INotifyPropertyChanged
	{
		private Put_Withholding_Order_Local_Minimum_Wage_DataType[] california_Local_Minimum_Wage_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("California_Local_Minimum_Wage_Data", Order = 0)]
		public Put_Withholding_Order_Local_Minimum_Wage_DataType[] California_Local_Minimum_Wage_Data
		{
			get
			{
				return this.california_Local_Minimum_Wage_DataField;
			}
			set
			{
				this.california_Local_Minimum_Wage_DataField = value;
				this.RaisePropertyChanged("California_Local_Minimum_Wage_Data");
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
