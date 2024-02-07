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
	public class Run_Pay_Calculation_Technical_DetailsType : INotifyPropertyChanged
	{
		private string workday_Integration_Cloud_Platform__ESB__Process_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Workday_Integration_Cloud_Platform__ESB__Process_ID
		{
			get
			{
				return this.workday_Integration_Cloud_Platform__ESB__Process_IDField;
			}
			set
			{
				this.workday_Integration_Cloud_Platform__ESB__Process_IDField = value;
				this.RaisePropertyChanged("Workday_Integration_Cloud_Platform__ESB__Process_ID");
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
