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
	public class Scorecard_Result_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType goal_ReferenceField;

		private decimal achievementField;

		private bool achievementFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Goal_Reference
		{
			get
			{
				return this.goal_ReferenceField;
			}
			set
			{
				this.goal_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Achievement
		{
			get
			{
				return this.achievementField;
			}
			set
			{
				this.achievementField = value;
				this.RaisePropertyChanged("Achievement");
			}
		}

		[XmlIgnore]
		public bool AchievementSpecified
		{
			get
			{
				return this.achievementFieldSpecified;
			}
			set
			{
				this.achievementFieldSpecified = value;
				this.RaisePropertyChanged("AchievementSpecified");
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
