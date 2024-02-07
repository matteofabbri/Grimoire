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
	public class Payroll_Payee_Ongoing_Work_Jurisdiction_Tax_Election_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] payroll_Payee_Ongoing_Jurisdiction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_Payee_Ongoing_Jurisdiction_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Payroll_Payee_Ongoing_Jurisdiction_Reference
		{
			get
			{
				return this.payroll_Payee_Ongoing_Jurisdiction_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Ongoing_Jurisdiction_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Ongoing_Jurisdiction_Reference");
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
