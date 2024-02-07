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
	public class Payroll_Year_End_Detail_InfoType : INotifyPropertyChanged
	{
		private string reporting_Code_NameField;

		private string year_End_Form_Detail_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Reporting_Code_Name
		{
			get
			{
				return this.reporting_Code_NameField;
			}
			set
			{
				this.reporting_Code_NameField = value;
				this.RaisePropertyChanged("Reporting_Code_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Year_End_Form_Detail_Value
		{
			get
			{
				return this.year_End_Form_Detail_ValueField;
			}
			set
			{
				this.year_End_Form_Detail_ValueField = value;
				this.RaisePropertyChanged("Year_End_Form_Detail_Value");
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
