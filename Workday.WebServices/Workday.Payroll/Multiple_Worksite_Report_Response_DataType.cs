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
	public class Multiple_Worksite_Report_Response_DataType : INotifyPropertyChanged
	{
		private Multiple_Worksite_Report_DataType multiple_Worksite_Report_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Multiple_Worksite_Report_DataType Multiple_Worksite_Report_Data
		{
			get
			{
				return this.multiple_Worksite_Report_DataField;
			}
			set
			{
				this.multiple_Worksite_Report_DataField = value;
				this.RaisePropertyChanged("Multiple_Worksite_Report_Data");
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
