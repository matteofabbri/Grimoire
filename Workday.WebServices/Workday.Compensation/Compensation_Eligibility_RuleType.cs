using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Compensation_Eligibility_RuleType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType compensation_Eligibility_Rule_ReferenceField;

		private Compensation_Eligibility_Rule_DataType[] compensation_Eligibility_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Compensation_Eligibility_Rule_Reference
		{
			get
			{
				return this.compensation_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.compensation_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Eligibility_Rule_Reference");
			}
		}

		[XmlElement("Compensation_Eligibility_Rule_Data", Order = 1)]
		public Compensation_Eligibility_Rule_DataType[] Compensation_Eligibility_Rule_Data
		{
			get
			{
				return this.compensation_Eligibility_Rule_DataField;
			}
			set
			{
				this.compensation_Eligibility_Rule_DataField = value;
				this.RaisePropertyChanged("Compensation_Eligibility_Rule_Data");
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
