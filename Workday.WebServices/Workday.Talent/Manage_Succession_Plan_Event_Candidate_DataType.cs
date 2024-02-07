using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Succession_Plan_Event_Candidate_DataType : INotifyPropertyChanged
	{
		private Succession_Plan_MemberObjectType candidate_ReferenceField;

		private Succession_StrategyObjectType succession_Strategy_ReferenceField;

		private Succession_ReadinessObjectType succession_Readiness_ReferenceField;

		private bool top_CandidateField;

		private bool top_CandidateFieldSpecified;

		private bool temporary_FillField;

		private bool temporary_FillFieldSpecified;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Succession_Plan_MemberObjectType Candidate_Reference
		{
			get
			{
				return this.candidate_ReferenceField;
			}
			set
			{
				this.candidate_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Succession_StrategyObjectType Succession_Strategy_Reference
		{
			get
			{
				return this.succession_Strategy_ReferenceField;
			}
			set
			{
				this.succession_Strategy_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Strategy_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Succession_ReadinessObjectType Succession_Readiness_Reference
		{
			get
			{
				return this.succession_Readiness_ReferenceField;
			}
			set
			{
				this.succession_Readiness_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Readiness_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Top_Candidate
		{
			get
			{
				return this.top_CandidateField;
			}
			set
			{
				this.top_CandidateField = value;
				this.RaisePropertyChanged("Top_Candidate");
			}
		}

		[XmlIgnore]
		public bool Top_CandidateSpecified
		{
			get
			{
				return this.top_CandidateFieldSpecified;
			}
			set
			{
				this.top_CandidateFieldSpecified = value;
				this.RaisePropertyChanged("Top_CandidateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Temporary_Fill
		{
			get
			{
				return this.temporary_FillField;
			}
			set
			{
				this.temporary_FillField = value;
				this.RaisePropertyChanged("Temporary_Fill");
			}
		}

		[XmlIgnore]
		public bool Temporary_FillSpecified
		{
			get
			{
				return this.temporary_FillFieldSpecified;
			}
			set
			{
				this.temporary_FillFieldSpecified = value;
				this.RaisePropertyChanged("Temporary_FillSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
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
