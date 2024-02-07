using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_SSP_History_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] payroll_SSP_History_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_SSP_History_Request_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Payroll_SSP_History_Request_Reference
		{
			get
			{
				return this.payroll_SSP_History_Request_ReferenceField;
			}
			set
			{
				this.payroll_SSP_History_Request_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_SSP_History_Request_Reference");
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
