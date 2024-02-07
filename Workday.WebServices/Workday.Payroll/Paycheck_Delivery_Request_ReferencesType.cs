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
	public class Paycheck_Delivery_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] paycheck_Delivery_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Paycheck_Delivery_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Paycheck_Delivery_Reference
		{
			get
			{
				return this.paycheck_Delivery_ReferenceField;
			}
			set
			{
				this.paycheck_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Paycheck_Delivery_Reference");
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
