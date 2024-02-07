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
	public class Worker_Tax_Treaties_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payroll_Payee_Tax_TreatyObjectType[] worker_Tax_Treaty_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worker_Tax_Treaty_Reference", Order = 0)]
		public Payroll_Payee_Tax_TreatyObjectType[] Worker_Tax_Treaty_Reference
		{
			get
			{
				return this.worker_Tax_Treaty_ReferenceField;
			}
			set
			{
				this.worker_Tax_Treaty_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Tax_Treaty_Reference");
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
