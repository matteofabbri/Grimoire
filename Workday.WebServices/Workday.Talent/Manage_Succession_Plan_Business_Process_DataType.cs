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
	public class Manage_Succession_Plan_Business_Process_DataType : INotifyPropertyChanged
	{
		private Position_ElementObjectType position_Element_ReferenceField;

		private bool consider_External_CandidateField;

		private bool consider_External_CandidateFieldSpecified;

		private Manage_Succession_Plan_Event_Candidate_DataType[] candidate_DataField;

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
		public bool Consider_External_Candidate
		{
			get
			{
				return this.consider_External_CandidateField;
			}
			set
			{
				this.consider_External_CandidateField = value;
				this.RaisePropertyChanged("Consider_External_Candidate");
			}
		}

		[XmlIgnore]
		public bool Consider_External_CandidateSpecified
		{
			get
			{
				return this.consider_External_CandidateFieldSpecified;
			}
			set
			{
				this.consider_External_CandidateFieldSpecified = value;
				this.RaisePropertyChanged("Consider_External_CandidateSpecified");
			}
		}

		[XmlElement("Candidate_Data", Order = 2)]
		public Manage_Succession_Plan_Event_Candidate_DataType[] Candidate_Data
		{
			get
			{
				return this.candidate_DataField;
			}
			set
			{
				this.candidate_DataField = value;
				this.RaisePropertyChanged("Candidate_Data");
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
