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
	public class Award_Personnel_ResponsibilityType : INotifyPropertyChanged
	{
		private Award_Personnel_ResponsibilityObjectType award_Personnel_Responsibility_ReferenceField;

		private Award_Personnel_Responsibility_DataType[] award_Personnel_Responsibility_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Personnel_ResponsibilityObjectType Award_Personnel_Responsibility_Reference
		{
			get
			{
				return this.award_Personnel_Responsibility_ReferenceField;
			}
			set
			{
				this.award_Personnel_Responsibility_ReferenceField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_Reference");
			}
		}

		[XmlElement("Award_Personnel_Responsibility_Data", Order = 1)]
		public Award_Personnel_Responsibility_DataType[] Award_Personnel_Responsibility_Data
		{
			get
			{
				return this.award_Personnel_Responsibility_DataField;
			}
			set
			{
				this.award_Personnel_Responsibility_DataField = value;
				this.RaisePropertyChanged("Award_Personnel_Responsibility_Data");
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
