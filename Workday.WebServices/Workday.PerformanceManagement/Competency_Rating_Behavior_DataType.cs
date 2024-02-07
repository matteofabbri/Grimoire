using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Competency_Rating_Behavior_DataType : INotifyPropertyChanged
	{
		private Proficiency_RatingObjectType proficiency_Rating_ReferenceField;

		private string rating_BehaviorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Proficiency_RatingObjectType Proficiency_Rating_Reference
		{
			get
			{
				return this.proficiency_Rating_ReferenceField;
			}
			set
			{
				this.proficiency_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Rating_Behavior
		{
			get
			{
				return this.rating_BehaviorField;
			}
			set
			{
				this.rating_BehaviorField = value;
				this.RaisePropertyChanged("Rating_Behavior");
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
