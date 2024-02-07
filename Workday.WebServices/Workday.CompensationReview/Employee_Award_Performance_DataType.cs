using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Performance_DataType : INotifyPropertyChanged
	{
		private Review_RatingObjectType performance_ReferenceField;

		private RetentionObjectType retention_Risk_ReferenceField;

		private PotentialObjectType talent_Potential_ReferenceField;

		private Achievable_LevelObjectType achievable_Level_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Review_RatingObjectType Performance_Reference
		{
			get
			{
				return this.performance_ReferenceField;
			}
			set
			{
				this.performance_ReferenceField = value;
				this.RaisePropertyChanged("Performance_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public RetentionObjectType Retention_Risk_Reference
		{
			get
			{
				return this.retention_Risk_ReferenceField;
			}
			set
			{
				this.retention_Risk_ReferenceField = value;
				this.RaisePropertyChanged("Retention_Risk_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public PotentialObjectType Talent_Potential_Reference
		{
			get
			{
				return this.talent_Potential_ReferenceField;
			}
			set
			{
				this.talent_Potential_ReferenceField = value;
				this.RaisePropertyChanged("Talent_Potential_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Achievable_LevelObjectType Achievable_Level_Reference
		{
			get
			{
				return this.achievable_Level_ReferenceField;
			}
			set
			{
				this.achievable_Level_ReferenceField = value;
				this.RaisePropertyChanged("Achievable_Level_Reference");
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
