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
	public class Succession_Pool_Candidate_Note_DataType : INotifyPropertyChanged
	{
		private string succession_Pool_Candidate_NotesField;

		private WorkerObjectType added_By__Worker__ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Succession_Pool_Candidate_Notes
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

		[XmlElement(Order = 1)]
		public WorkerObjectType Added_By__Worker__Reference
		{
			get
			{
				return this.added_By__Worker__ReferenceField;
			}
			set
			{
				this.added_By__Worker__ReferenceField = value;
				this.RaisePropertyChanged("Added_By__Worker__Reference");
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
