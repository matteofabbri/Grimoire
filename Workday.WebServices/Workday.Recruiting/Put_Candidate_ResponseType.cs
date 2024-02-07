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
	public class Put_Candidate_ResponseType : INotifyPropertyChanged
	{
		private CandidateObjectType candidate_ReferenceField;

		private Candidate_Job_Application_DataType[] candidate_Job_Application_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CandidateObjectType Candidate_Reference
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

		[XmlElement("Candidate_Job_Application_Data", Order = 1)]
		public Candidate_Job_Application_DataType[] Candidate_Job_Application_Data
		{
			get
			{
				return this.candidate_Job_Application_DataField;
			}
			set
			{
				this.candidate_Job_Application_DataField = value;
				this.RaisePropertyChanged("Candidate_Job_Application_Data");
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
