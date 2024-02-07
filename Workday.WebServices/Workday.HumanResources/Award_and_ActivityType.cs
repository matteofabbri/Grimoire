using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_and_ActivityType : INotifyPropertyChanged
	{
		private AwardObjectType award_and_Activity_ReferenceField;

		private Award_and_Activity_Achievement_DataType award_and_Activity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public AwardObjectType Award_and_Activity_Reference
		{
			get
			{
				return this.award_and_Activity_ReferenceField;
			}
			set
			{
				this.award_and_Activity_ReferenceField = value;
				this.RaisePropertyChanged("Award_and_Activity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Award_and_Activity_Achievement_DataType Award_and_Activity_Data
		{
			get
			{
				return this.award_and_Activity_DataField;
			}
			set
			{
				this.award_and_Activity_DataField = value;
				this.RaisePropertyChanged("Award_and_Activity_Data");
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
