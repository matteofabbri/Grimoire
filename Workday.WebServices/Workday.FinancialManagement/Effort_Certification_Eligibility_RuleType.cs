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
	public class Effort_Certification_Eligibility_RuleType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType effort_Certification_Eligibility_Rule_ReferenceField;

		private Condition_Rule_Data_WWSType[] effort_Certification_Eligibility_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Effort_Certification_Eligibility_Rule_Reference
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

		[XmlElement("Effort_Certification_Eligibility_Rule_Data", Order = 1)]
		public Condition_Rule_Data_WWSType[] Effort_Certification_Eligibility_Rule_Data
		{
			get
			{
				return this.effort_Certification_Eligibility_Rule_DataField;
			}
			set
			{
				this.effort_Certification_Eligibility_Rule_DataField = value;
				this.RaisePropertyChanged("Effort_Certification_Eligibility_Rule_Data");
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
