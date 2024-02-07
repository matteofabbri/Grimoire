using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assess_Candidate_Event_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Recruiting_Assessment_DataType candidate_Assessment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Candidate_Criteria_Data", typeof(Candidate_CriteriaType), Order = 0), XmlElement("Event_Reference", typeof(Unique_IdentifierObjectType), Order = 0), XmlElement("Job_Application_Reference", typeof(Job_ApplicationObjectType), Order = 0)]
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

		[XmlElement(Order = 1)]
		public Recruiting_Assessment_DataType Candidate_Assessment_Data
		{
			get
			{
				return this.candidate_Assessment_DataField;
			}
			set
			{
				this.candidate_Assessment_DataField = value;
				this.RaisePropertyChanged("Candidate_Assessment_Data");
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
