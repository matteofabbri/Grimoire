using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Succession_Pool_CandidateType : INotifyPropertyChanged
	{
		private Succession_Pool_CandidateObjectType[] succession_Pool_Candidate_ReferenceField;

		private Succession_Pool_Candidate_DataType succession_Pool_Candidate_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Succession_Pool_Candidate_Reference", Order = 0)]
		public Succession_Pool_CandidateObjectType[] Succession_Pool_Candidate_Reference
		{
			get
			{
				return this.succession_Pool_Candidate_ReferenceField;
			}
			set
			{
				this.succession_Pool_Candidate_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Pool_Candidate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Succession_Pool_Candidate_DataType Succession_Pool_Candidate_Data
		{
			get
			{
				return this.succession_Pool_Candidate_DataField;
			}
			set
			{
				this.succession_Pool_Candidate_DataField = value;
				this.RaisePropertyChanged("Succession_Pool_Candidate_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
