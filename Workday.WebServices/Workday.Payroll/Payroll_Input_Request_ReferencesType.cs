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
	public class Payroll_Input_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_InputObjectType[] payroll_Input_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Input_Reference", Order = 0)]
		public Payroll_InputObjectType[] Payroll_Input_Reference
		{
			get
			{
				return this.payroll_Input_ReferenceField;
			}
			set
			{
				this.payroll_Input_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Input_Reference");
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
