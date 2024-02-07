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
	public class Recruiting_Assessment_Test_Result_DataType : INotifyPropertyChanged
	{
		private Recruiting_Assessment_Test_ResultObjectType assessment_Test_Result_ReferenceField;

		private Recruiting_Assessment_TestObjectType assessment_Test_ReferenceField;

		private decimal assessment_Test_ScoreField;

		private bool assessment_Test_ScoreFieldSpecified;

		private Recruiting_Assessment_StatusObjectType assessment_Test_Status_ReferenceField;

		private DateTime assessment_Test_DateField;

		private bool assessment_Test_DateFieldSpecified;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_Assessment_Test_ResultObjectType Assessment_Test_Result_Reference
		{
			get
			{
				return this.assessment_Test_Result_ReferenceField;
			}
			set
			{
				this.assessment_Test_Result_ReferenceField = value;
				this.RaisePropertyChanged("Assessment_Test_Result_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Recruiting_Assessment_TestObjectType Assessment_Test_Reference
		{
			get
			{
				return this.assessment_Test_ReferenceField;
			}
			set
			{
				this.assessment_Test_ReferenceField = value;
				this.RaisePropertyChanged("Assessment_Test_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Assessment_Test_Score
		{
			get
			{
				return this.assessment_Test_ScoreField;
			}
			set
			{
				this.assessment_Test_ScoreField = value;
				this.RaisePropertyChanged("Assessment_Test_Score");
			}
		}

		[XmlIgnore]
		public bool Assessment_Test_ScoreSpecified
		{
			get
			{
				return this.assessment_Test_ScoreFieldSpecified;
			}
			set
			{
				this.assessment_Test_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Assessment_Test_ScoreSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Recruiting_Assessment_StatusObjectType Assessment_Test_Status_Reference
		{
			get
			{
				return this.assessment_Test_Status_ReferenceField;
			}
			set
			{
				this.assessment_Test_Status_ReferenceField = value;
				this.RaisePropertyChanged("Assessment_Test_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Assessment_Test_Date
		{
			get
			{
				return this.assessment_Test_DateField;
			}
			set
			{
				this.assessment_Test_DateField = value;
				this.RaisePropertyChanged("Assessment_Test_Date");
			}
		}

		[XmlIgnore]
		public bool Assessment_Test_DateSpecified
		{
			get
			{
				return this.assessment_Test_DateFieldSpecified;
			}
			set
			{
				this.assessment_Test_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assessment_Test_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
