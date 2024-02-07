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
	public class Run_Pay_Calculation_Request_ReferencesType : INotifyPropertyChanged
	{
		private Background_Process_RuntimeObjectType[] run_Pay_Calculation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Run_Pay_Calculation_Reference", Order = 0)]
		public Background_Process_RuntimeObjectType[] Run_Pay_Calculation_Reference
		{
			get
			{
				return this.run_Pay_Calculation_ReferenceField;
			}
			set
			{
				this.run_Pay_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Reference");
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
