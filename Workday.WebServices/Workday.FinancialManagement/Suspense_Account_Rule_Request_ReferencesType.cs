using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Suspense_Account_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Suspense_Account_RuleObjectType[] suspense_Account_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Suspense_Account_Rule_Reference", Order = 0)]
		public Suspense_Account_RuleObjectType[] Suspense_Account_Rule_Reference
		{
			get
			{
				return this.suspense_Account_Rule_ReferenceField;
			}
			set
			{
				this.suspense_Account_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Suspense_Account_Rule_Reference");
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
