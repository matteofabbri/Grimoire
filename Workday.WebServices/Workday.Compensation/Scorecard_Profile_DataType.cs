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
	public class Scorecard_Profile_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType scorecard_Profile_Target__Rule_ReferenceField;

		private Scorecard_Profile_Performance_Criteria_DataType[] scorecard_Profile_Goal_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Scorecard_Profile_Target__Rule_Reference
		{
			get
			{
				return this.scorecard_Profile_Target__Rule_ReferenceField;
			}
			set
			{
				this.scorecard_Profile_Target__Rule_ReferenceField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Target__Rule_Reference");
			}
		}

		[XmlElement("Scorecard_Profile_Goal_Data", Order = 1)]
		public Scorecard_Profile_Performance_Criteria_DataType[] Scorecard_Profile_Goal_Data
		{
			get
			{
				return this.scorecard_Profile_Goal_DataField;
			}
			set
			{
				this.scorecard_Profile_Goal_DataField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Goal_Data");
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
