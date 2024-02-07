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
	public class Recruiting_Assessment_DataType : INotifyPropertyChanged
	{
		private string assess_Candidate_ReferenceField;

		private WorkerObjectType assessed_By_ReferenceField;

		private DateTime assessed_On_DateField;

		private Recruiting_Assessment_StatusObjectType assessment_Status_ReferenceField;

		private string overall_Assessment_CommentField;

		private Recruiting_Assessment_Test_Result_DataType[] assess_Candidate_Test_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Assess_Candidate_Reference
		{
			get
			{
				return this.assess_Candidate_ReferenceField;
			}
			set
			{
				this.assess_Candidate_ReferenceField = value;
				this.RaisePropertyChanged("Assess_Candidate_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Assessed_By_Reference
		{
			get
			{
				return this.assessed_By_ReferenceField;
			}
			set
			{
				this.assessed_By_ReferenceField = value;
				this.RaisePropertyChanged("Assessed_By_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Assessed_On_Date
		{
			get
			{
				return this.assessed_On_DateField;
			}
			set
			{
				this.assessed_On_DateField = value;
				this.RaisePropertyChanged("Assessed_On_Date");
			}
		}

		[XmlElement(Order = 3)]
		public Recruiting_Assessment_StatusObjectType Assessment_Status_Reference
		{
			get
			{
				return this.assessment_Status_ReferenceField;
			}
			set
			{
				this.assessment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Assessment_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Overall_Assessment_Comment
		{
			get
			{
				return this.overall_Assessment_CommentField;
			}
			set
			{
				this.overall_Assessment_CommentField = value;
				this.RaisePropertyChanged("Overall_Assessment_Comment");
			}
		}

		[XmlElement("Assess_Candidate_Test_Result_Data", Order = 5)]
		public Recruiting_Assessment_Test_Result_DataType[] Assess_Candidate_Test_Result_Data
		{
			get
			{
				return this.assess_Candidate_Test_Result_DataField;
			}
			set
			{
				this.assess_Candidate_Test_Result_DataField = value;
				this.RaisePropertyChanged("Assess_Candidate_Test_Result_Data");
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
