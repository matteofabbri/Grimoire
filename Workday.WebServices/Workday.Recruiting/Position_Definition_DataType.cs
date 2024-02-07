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
	public class Position_Definition_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private string job_Posting_TitleField;

		private string job_Description_SummaryField;

		private string job_DescriptionField;

		private bool critical_JobField;

		private bool critical_JobFieldSpecified;

		private Difficulty_to_FillObjectType difficulty_to_Fill_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Posting_Title
		{
			get
			{
				return this.job_Posting_TitleField;
			}
			set
			{
				this.job_Posting_TitleField = value;
				this.RaisePropertyChanged("Job_Posting_Title");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Description_Summary
		{
			get
			{
				return this.job_Description_SummaryField;
			}
			set
			{
				this.job_Description_SummaryField = value;
				this.RaisePropertyChanged("Job_Description_Summary");
			}
		}

		[XmlElement(Order = 3)]
		public string Job_Description
		{
			get
			{
				return this.job_DescriptionField;
			}
			set
			{
				this.job_DescriptionField = value;
				this.RaisePropertyChanged("Job_Description");
			}
		}

		[XmlElement(Order = 4)]
		public bool Critical_Job
		{
			get
			{
				return this.critical_JobField;
			}
			set
			{
				this.critical_JobField = value;
				this.RaisePropertyChanged("Critical_Job");
			}
		}

		[XmlIgnore]
		public bool Critical_JobSpecified
		{
			get
			{
				return this.critical_JobFieldSpecified;
			}
			set
			{
				this.critical_JobFieldSpecified = value;
				this.RaisePropertyChanged("Critical_JobSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Difficulty_to_FillObjectType Difficulty_to_Fill_Reference
		{
			get
			{
				return this.difficulty_to_Fill_ReferenceField;
			}
			set
			{
				this.difficulty_to_Fill_ReferenceField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Reference");
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
