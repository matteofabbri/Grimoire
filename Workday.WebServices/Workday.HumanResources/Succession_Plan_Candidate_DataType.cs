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
	public class Succession_Plan_Candidate_DataType : INotifyPropertyChanged
	{
		private Position_ElementObjectType position_Element_ReferenceField;

		private Succession_ReadinessObjectType succession_Readiness_ReferenceField;

		private bool top_CandidateField;

		private bool top_CandidateFieldSpecified;

		private string notesField;

		private string last_UpdatedField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_ElementObjectType Position_Element_Reference
		{
			get
			{
				return this.position_Element_ReferenceField;
			}
			set
			{
				this.position_Element_ReferenceField = value;
				this.RaisePropertyChanged("Position_Element_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
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
