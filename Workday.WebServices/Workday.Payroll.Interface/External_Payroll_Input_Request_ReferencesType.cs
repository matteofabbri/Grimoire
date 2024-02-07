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
	public class External_Payroll_Input_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_InputObjectType[] external_Payroll_Input_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("External_Payroll_Input_Reference", Order = 0)]
		public Payroll_InputObjectType[] External_Payroll_Input_Reference
		{
			get
			{
				return this.external_Payroll_Input_ReferenceField;
			}
			set
			{
				this.external_Payroll_Input_ReferenceField = value;
				this.RaisePropertyChanged("External_Payroll_Input_Reference");
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
