using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assess_Candidate_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType candidate_Assessment_Event_ReferenceField;

		private Recruiting_AssessmentObjectType candidate_Assessment_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Candidate_Assessment_Event_Reference
		{
			get
			{
				return this.candidate_Assessment_Event_ReferenceField;
			}
			set
			{
				this.candidate_Assessment_Event_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Assessment_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Recruiting_AssessmentObjectType Candidate_Assessment_Reference
		{
			get
			{
				return this.candidate_Assessment_ReferenceField;
			}
			set
			{
				this.candidate_Assessment_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Assessment_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
