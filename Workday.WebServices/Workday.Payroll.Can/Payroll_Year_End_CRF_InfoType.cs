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
	public class Payroll_Year_End_CRF_InfoType : INotifyPropertyChanged
	{
		private string year_End_Box_NameField;

		private string year_End_Box_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Year_End_Box_Name
		{
			get
			{
				return this.year_End_Box_NameField;
			}
			set
			{
				this.year_End_Box_NameField = value;
				this.RaisePropertyChanged("Year_End_Box_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Year_End_Box_Value
		{
			get
			{
				return this.year_End_Box_ValueField;
			}
			set
			{
				this.year_End_Box_ValueField = value;
				this.RaisePropertyChanged("Year_End_Box_Value");
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
