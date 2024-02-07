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
	public class Funding_Source_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Funding_Source_RuleObjectType[] funding_Source_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Funding_Source_Rule_Reference", Order = 0)]
		public Funding_Source_RuleObjectType[] Funding_Source_Rule_Reference
		{
			get
			{
				return this.funding_Source_Rule_ReferenceField;
			}
			set
			{
				this.funding_Source_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Funding_Source_Rule_Reference");
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
