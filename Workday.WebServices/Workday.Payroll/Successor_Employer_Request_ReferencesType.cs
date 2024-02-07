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
	public class Successor_Employer_Request_ReferencesType : INotifyPropertyChanged
	{
		private Successor_EmployerObjectType[] successor_Employer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Successor_Employer_Reference", Order = 0)]
		public Successor_EmployerObjectType[] Successor_Employer_Reference
		{
			get
			{
				return this.successor_Employer_ReferenceField;
			}
			set
			{
				this.successor_Employer_ReferenceField = value;
				this.RaisePropertyChanged("Successor_Employer_Reference");
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
