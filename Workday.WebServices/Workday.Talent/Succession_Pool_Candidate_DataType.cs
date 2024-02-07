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
	public class Succession_Pool_Candidate_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool top_CandidateField;

		private bool top_CandidateFieldSpecified;

		private object itemField;

		private Succession_ReadinessObjectType succession_Readiness_ReferenceField;

		private Succession_Pool_Candidate_Note_DataType[] succession_Pool_Candidate_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Candidate_Reference", typeof(CandidateObjectType), Order = 2), XmlElement("XMLNAME__Worker__Reference", typeof(WorkerObjectType), Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Succession_Pool_Candidate_Notes", Order = 4)]
		public Succession_Pool_Candidate_Note_DataType[] Succession_Pool_Candidate_Notes
		{
			get
			{
				return this.succession_Pool_Candidate_NotesField;
			}
			set
			{
				this.succession_Pool_Candidate_NotesField = value;
				this.RaisePropertyChanged("Succession_Pool_Candidate_Notes");
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
