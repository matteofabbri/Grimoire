using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notice_Period_Eligibility_RuleType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType notice_Period_Eligibility_Rule_ReferenceField;

		private Condition_Rule_Data_WWSType[] notice_Period_Eligibility_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Notice_Period_Eligibility_Rule_Reference
		{
			get
			{
				return this.notice_Period_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.notice_Period_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Notice_Period_Eligibility_Rule_Reference");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Condition_Rule_Data", typeof(Condition_Rule_Data_WWSType), IsNullable = false)]
		public Condition_Rule_Data_WWSType[] Notice_Period_Eligibility_Rule_Data
		{
			get
			{
				return this.notice_Period_Eligibility_Rule_DataField;
			}
			set
			{
				this.notice_Period_Eligibility_Rule_DataField = value;
				this.RaisePropertyChanged("Notice_Period_Eligibility_Rule_Data");
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
