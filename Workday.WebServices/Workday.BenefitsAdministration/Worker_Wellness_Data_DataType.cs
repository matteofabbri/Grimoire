using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Wellness_Data_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private object itemField;

		private DateTime participates_in_Wellness_DateField;

		private bool participates_in_Wellness_DateFieldSpecified;

		private bool participates_in_Wellness_ProgramField;

		private bool participates_in_Wellness_ProgramFieldSpecified;

		private DateTime wellness_Score_DateField;

		private bool wellness_Score_DateFieldSpecified;

		private decimal wellness_ScoreField;

		private bool wellness_ScoreFieldSpecified;

		private DateTime uses_Tobacco_DateField;

		private bool uses_Tobacco_DateFieldSpecified;

		private bool uses_TobaccoField;

		private bool uses_TobaccoFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement("Dependent_Reference", typeof(DependentObjectType), Order = 1), XmlElement("Worker_Reference", typeof(WorkerObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Participates_in_Wellness_Date
		{
			get
			{
				return this.participates_in_Wellness_DateField;
			}
			set
			{
				this.participates_in_Wellness_DateField = value;
				this.RaisePropertyChanged("Participates_in_Wellness_Date");
			}
		}

		[XmlIgnore]
		public bool Participates_in_Wellness_DateSpecified
		{
			get
			{
				return this.participates_in_Wellness_DateFieldSpecified;
			}
			set
			{
				this.participates_in_Wellness_DateFieldSpecified = value;
				this.RaisePropertyChanged("Participates_in_Wellness_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Participates_in_Wellness_Program
		{
			get
			{
				return this.participates_in_Wellness_ProgramField;
			}
			set
			{
				this.participates_in_Wellness_ProgramField = value;
				this.RaisePropertyChanged("Participates_in_Wellness_Program");
			}
		}

		[XmlIgnore]
		public bool Participates_in_Wellness_ProgramSpecified
		{
			get
			{
				return this.participates_in_Wellness_ProgramFieldSpecified;
			}
			set
			{
				this.participates_in_Wellness_ProgramFieldSpecified = value;
				this.RaisePropertyChanged("Participates_in_Wellness_ProgramSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Wellness_Score_Date
		{
			get
			{
				return this.wellness_Score_DateField;
			}
			set
			{
				this.wellness_Score_DateField = value;
				this.RaisePropertyChanged("Wellness_Score_Date");
			}
		}

		[XmlIgnore]
		public bool Wellness_Score_DateSpecified
		{
			get
			{
				return this.wellness_Score_DateFieldSpecified;
			}
			set
			{
				this.wellness_Score_DateFieldSpecified = value;
				this.RaisePropertyChanged("Wellness_Score_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Wellness_Score
		{
			get
			{
				return this.wellness_ScoreField;
			}
			set
			{
				this.wellness_ScoreField = value;
				this.RaisePropertyChanged("Wellness_Score");
			}
		}

		[XmlIgnore]
		public bool Wellness_ScoreSpecified
		{
			get
			{
				return this.wellness_ScoreFieldSpecified;
			}
			set
			{
				this.wellness_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Wellness_ScoreSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Uses_Tobacco_Date
		{
			get
			{
				return this.uses_Tobacco_DateField;
			}
			set
			{
				this.uses_Tobacco_DateField = value;
				this.RaisePropertyChanged("Uses_Tobacco_Date");
			}
		}

		[XmlIgnore]
		public bool Uses_Tobacco_DateSpecified
		{
			get
			{
				return this.uses_Tobacco_DateFieldSpecified;
			}
			set
			{
				this.uses_Tobacco_DateFieldSpecified = value;
				this.RaisePropertyChanged("Uses_Tobacco_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Uses_Tobacco
		{
			get
			{
				return this.uses_TobaccoField;
			}
			set
			{
				this.uses_TobaccoField = value;
				this.RaisePropertyChanged("Uses_Tobacco");
			}
		}

		[XmlIgnore]
		public bool Uses_TobaccoSpecified
		{
			get
			{
				return this.uses_TobaccoFieldSpecified;
			}
			set
			{
				this.uses_TobaccoFieldSpecified = value;
				this.RaisePropertyChanged("Uses_TobaccoSpecified");
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
