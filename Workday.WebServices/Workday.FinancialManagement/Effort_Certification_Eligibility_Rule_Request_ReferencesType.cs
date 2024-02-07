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
	public class Effort_Certification_Eligibility_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType[] effort_Certification_Eligibility_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Effort_Certification_Eligibility_Rule_Reference", Order = 0)]
		public Condition_RuleObjectType[] Effort_Certification_Eligibility_Rule_Reference
		{
			get
			{
				return this.effort_Certification_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.effort_Certification_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certification_Eligibility_Rule_Reference");
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
