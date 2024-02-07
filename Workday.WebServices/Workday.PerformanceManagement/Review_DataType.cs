using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_DataType : INotifyPropertyChanged
	{
		private string employee_Review_IDField;

		private bool review_CompletedField;

		private bool review_CompletedFieldSpecified;

		private WorkerObjectType employee_ReferenceField;

		private WorkerObjectType manager_ReferenceField;

		private WorkerObjectType[] additional_Manager_ReferenceField;

		private Employee_Review_TemplateObjectType employee_Review_Template_ReferenceField;

		private Disciplinary_Action_ReasonObjectType[] disciplinary_Action_Reasons_ReferenceField;

		private Disciplinary_ActionObjectType[] related_Disciplinary_Actions_ReferenceField;

		private DateTime review_Initiation_DateField;

		private bool review_Initiation_DateFieldSpecified;

		private DateTime review_Period_Start_DateField;

		private bool review_Period_Start_DateFieldSpecified;

		private DateTime review_Period_End_DateField;

		private bool review_Period_End_DateFieldSpecified;

		private Accomplishments_Review_Section_DataType[] accomplishments_Review_Section_DataField;

		private Competencies_Review_Section_DataType[] competencies_Review_Section_DataField;

		private Review_Development_Area_DataType[] development_Areas_Review_Section_DataField;

		private Goals_Review_Section_DataType[] goals_Review_Section_DataField;

		private Responsibilities_Review_Section_DataType[] responsibilities_Review_Section_DataField;

		private Review_Career_Interest_DataType[] career_Interests_Review_Section_DataField;

		private Careers_Review_Section_DataType[] careers_Review_Section_dataField;

		private Questions_Review_Section_DataType[] questions_Review_Section_DataField;

		private Supporting_Document_Evaluation_DataType supporting_Document_Evaluation_DataField;

		private Development_Items_Review_Section_DataType development_Items_Review_Section_DataField;

		private Overall_Evaluation_DataType overall_Evaluation_DataField;

		private Feedback_Review_Section_DataType feedback_Review_Section_DataField;

		private Post_Evaluation_Feedback_DataType post_Evaluation_Feedback_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Employee_Review_ID
		{
			get
			{
				return this.employee_Review_IDField;
			}
			set
			{
				this.employee_Review_IDField = value;
				this.RaisePropertyChanged("Employee_Review_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Review_Completed
		{
			get
			{
				return this.review_CompletedField;
			}
			set
			{
				this.review_CompletedField = value;
				this.RaisePropertyChanged("Review_Completed");
			}
		}

		[XmlIgnore]
		public bool Review_CompletedSpecified
		{
			get
			{
				return this.review_CompletedFieldSpecified;
			}
			set
			{
				this.review_CompletedFieldSpecified = value;
				this.RaisePropertyChanged("Review_CompletedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public WorkerObjectType Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement("Additional_Manager_Reference", Order = 4)]
		public WorkerObjectType[] Additional_Manager_Reference
		{
			get
			{
				return this.additional_Manager_ReferenceField;
			}
			set
			{
				this.additional_Manager_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Manager_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Employee_Review_TemplateObjectType Employee_Review_Template_Reference
		{
			get
			{
				return this.employee_Review_Template_ReferenceField;
			}
			set
			{
				this.employee_Review_Template_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Review_Template_Reference");
			}
		}

		[XmlElement("Disciplinary_Action_Reasons_Reference", Order = 6)]
		public Disciplinary_Action_ReasonObjectType[] Disciplinary_Action_Reasons_Reference
		{
			get
			{
				return this.disciplinary_Action_Reasons_ReferenceField;
			}
			set
			{
				this.disciplinary_Action_Reasons_ReferenceField = value;
				this.RaisePropertyChanged("Disciplinary_Action_Reasons_Reference");
			}
		}

		[XmlElement("Related_Disciplinary_Actions_Reference", Order = 7)]
		public Disciplinary_ActionObjectType[] Related_Disciplinary_Actions_Reference
		{
			get
			{
				return this.related_Disciplinary_Actions_ReferenceField;
			}
			set
			{
				this.related_Disciplinary_Actions_ReferenceField = value;
				this.RaisePropertyChanged("Related_Disciplinary_Actions_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime Review_Initiation_Date
		{
			get
			{
				return this.review_Initiation_DateField;
			}
			set
			{
				this.review_Initiation_DateField = value;
				this.RaisePropertyChanged("Review_Initiation_Date");
			}
		}

		[XmlIgnore]
		public bool Review_Initiation_DateSpecified
		{
			get
			{
				return this.review_Initiation_DateFieldSpecified;
			}
			set
			{
				this.review_Initiation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Review_Initiation_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Review_Period_Start_Date
		{
			get
			{
				return this.review_Period_Start_DateField;
			}
			set
			{
				this.review_Period_Start_DateField = value;
				this.RaisePropertyChanged("Review_Period_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Review_Period_Start_DateSpecified
		{
			get
			{
				return this.review_Period_Start_DateFieldSpecified;
			}
			set
			{
				this.review_Period_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Review_Period_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Review_Period_End_Date
		{
			get
			{
				return this.review_Period_End_DateField;
			}
			set
			{
				this.review_Period_End_DateField = value;
				this.RaisePropertyChanged("Review_Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Review_Period_End_DateSpecified
		{
			get
			{
				return this.review_Period_End_DateFieldSpecified;
			}
			set
			{
				this.review_Period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Review_Period_End_DateSpecified");
			}
		}

		[XmlElement("Accomplishments_Review_Section_Data", Order = 11)]
		public Accomplishments_Review_Section_DataType[] Accomplishments_Review_Section_Data
		{
			get
			{
				return this.accomplishments_Review_Section_DataField;
			}
			set
			{
				this.accomplishments_Review_Section_DataField = value;
				this.RaisePropertyChanged("Accomplishments_Review_Section_Data");
			}
		}

		[XmlElement("Competencies_Review_Section_Data", Order = 12)]
		public Competencies_Review_Section_DataType[] Competencies_Review_Section_Data
		{
			get
			{
				return this.competencies_Review_Section_DataField;
			}
			set
			{
				this.competencies_Review_Section_DataField = value;
				this.RaisePropertyChanged("Competencies_Review_Section_Data");
			}
		}

		[XmlArray(Order = 13), XmlArrayItem("Review_Development_Area_Data", IsNullable = false)]
		public Review_Development_Area_DataType[] Development_Areas_Review_Section_Data
		{
			get
			{
				return this.development_Areas_Review_Section_DataField;
			}
			set
			{
				this.development_Areas_Review_Section_DataField = value;
				this.RaisePropertyChanged("Development_Areas_Review_Section_Data");
			}
		}

		[XmlElement("Goals_Review_Section_Data", Order = 14)]
		public Goals_Review_Section_DataType[] Goals_Review_Section_Data
		{
			get
			{
				return this.goals_Review_Section_DataField;
			}
			set
			{
				this.goals_Review_Section_DataField = value;
				this.RaisePropertyChanged("Goals_Review_Section_Data");
			}
		}

		[XmlElement("Responsibilities_Review_Section_Data", Order = 15)]
		public Responsibilities_Review_Section_DataType[] Responsibilities_Review_Section_Data
		{
			get
			{
				return this.responsibilities_Review_Section_DataField;
			}
			set
			{
				this.responsibilities_Review_Section_DataField = value;
				this.RaisePropertyChanged("Responsibilities_Review_Section_Data");
			}
		}

		[XmlArray(Order = 16), XmlArrayItem("Review_Career_Interest_Data", IsNullable = false)]
		public Review_Career_Interest_DataType[] Career_Interests_Review_Section_Data
		{
			get
			{
				return this.career_Interests_Review_Section_DataField;
			}
			set
			{
				this.career_Interests_Review_Section_DataField = value;
				this.RaisePropertyChanged("Career_Interests_Review_Section_Data");
			}
		}

		[XmlElement("Careers_Review_Section_data", Order = 17)]
		public Careers_Review_Section_DataType[] Careers_Review_Section_data
		{
			get
			{
				return this.careers_Review_Section_dataField;
			}
			set
			{
				this.careers_Review_Section_dataField = value;
				this.RaisePropertyChanged("Careers_Review_Section_data");
			}
		}

		[XmlElement("Questions_Review_Section_Data", Order = 18)]
		public Questions_Review_Section_DataType[] Questions_Review_Section_Data
		{
			get
			{
				return this.questions_Review_Section_DataField;
			}
			set
			{
				this.questions_Review_Section_DataField = value;
				this.RaisePropertyChanged("Questions_Review_Section_Data");
			}
		}

		[XmlElement(Order = 19)]
		public Supporting_Document_Evaluation_DataType Supporting_Document_Evaluation_Data
		{
			get
			{
				return this.supporting_Document_Evaluation_DataField;
			}
			set
			{
				this.supporting_Document_Evaluation_DataField = value;
				this.RaisePropertyChanged("Supporting_Document_Evaluation_Data");
			}
		}

		[XmlElement(Order = 20)]
		public Development_Items_Review_Section_DataType Development_Items_Review_Section_Data
		{
			get
			{
				return this.development_Items_Review_Section_DataField;
			}
			set
			{
				this.development_Items_Review_Section_DataField = value;
				this.RaisePropertyChanged("Development_Items_Review_Section_Data");
			}
		}

		[XmlElement(Order = 21)]
		public Overall_Evaluation_DataType Overall_Evaluation_Data
		{
			get
			{
				return this.overall_Evaluation_DataField;
			}
			set
			{
				this.overall_Evaluation_DataField = value;
				this.RaisePropertyChanged("Overall_Evaluation_Data");
			}
		}

		[XmlElement(Order = 22)]
		public Feedback_Review_Section_DataType Feedback_Review_Section_Data
		{
			get
			{
				return this.feedback_Review_Section_DataField;
			}
			set
			{
				this.feedback_Review_Section_DataField = value;
				this.RaisePropertyChanged("Feedback_Review_Section_Data");
			}
		}

		[XmlElement(Order = 23)]
		public Post_Evaluation_Feedback_DataType Post_Evaluation_Feedback_Data
		{
			get
			{
				return this.post_Evaluation_Feedback_DataField;
			}
			set
			{
				this.post_Evaluation_Feedback_DataField = value;
				this.RaisePropertyChanged("Post_Evaluation_Feedback_Data");
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
