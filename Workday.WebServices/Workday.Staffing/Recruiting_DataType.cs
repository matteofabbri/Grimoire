using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recruiting_DataType : INotifyPropertyChanged
	{
		private DateTime applicant_Entered_DateField;

		private bool applicant_Entered_DateFieldSpecified;

		private string applicant_CommentsField;

		private bool ineligible_for_HireField;

		private bool ineligible_for_HireFieldSpecified;

		private string ineligible_for_Hire_CommentsField;

		private Applicant_SourceObjectType applicant_Source_ReferenceField;

		private WorkerObjectType[] referred_by_Worker_ReferenceField;

		private Position_GroupObjectType[] positions_Considered_for_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Applicant_Entered_Date
		{
			get
			{
				return this.applicant_Entered_DateField;
			}
			set
			{
				this.applicant_Entered_DateField = value;
				this.RaisePropertyChanged("Applicant_Entered_Date");
			}
		}

		[XmlIgnore]
		public bool Applicant_Entered_DateSpecified
		{
			get
			{
				return this.applicant_Entered_DateFieldSpecified;
			}
			set
			{
				this.applicant_Entered_DateFieldSpecified = value;
				this.RaisePropertyChanged("Applicant_Entered_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Applicant_Comments
		{
			get
			{
				return this.applicant_CommentsField;
			}
			set
			{
				this.applicant_CommentsField = value;
				this.RaisePropertyChanged("Applicant_Comments");
			}
		}

		[XmlElement(Order = 2)]
		public bool Ineligible_for_Hire
		{
			get
			{
				return this.ineligible_for_HireField;
			}
			set
			{
				this.ineligible_for_HireField = value;
				this.RaisePropertyChanged("Ineligible_for_Hire");
			}
		}

		[XmlIgnore]
		public bool Ineligible_for_HireSpecified
		{
			get
			{
				return this.ineligible_for_HireFieldSpecified;
			}
			set
			{
				this.ineligible_for_HireFieldSpecified = value;
				this.RaisePropertyChanged("Ineligible_for_HireSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Ineligible_for_Hire_Comments
		{
			get
			{
				return this.ineligible_for_Hire_CommentsField;
			}
			set
			{
				this.ineligible_for_Hire_CommentsField = value;
				this.RaisePropertyChanged("Ineligible_for_Hire_Comments");
			}
		}

		[XmlElement(Order = 4)]
		public Applicant_SourceObjectType Applicant_Source_Reference
		{
			get
			{
				return this.applicant_Source_ReferenceField;
			}
			set
			{
				this.applicant_Source_ReferenceField = value;
				this.RaisePropertyChanged("Applicant_Source_Reference");
			}
		}

		[XmlElement("Referred_by_Worker_Reference", Order = 5)]
		public WorkerObjectType[] Referred_by_Worker_Reference
		{
			get
			{
				return this.referred_by_Worker_ReferenceField;
			}
			set
			{
				this.referred_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Referred_by_Worker_Reference");
			}
		}

		[XmlElement("Positions_Considered_for_Reference", Order = 6)]
		public Position_GroupObjectType[] Positions_Considered_for_Reference
		{
			get
			{
				return this.positions_Considered_for_ReferenceField;
			}
			set
			{
				this.positions_Considered_for_ReferenceField = value;
				this.RaisePropertyChanged("Positions_Considered_for_Reference");
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
