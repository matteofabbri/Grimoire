using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Pensions_Auto_Enrolment_External_Assessment_History_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime assessment_DateField;

		private bool assessment_DateFieldSpecified;

		private Payroll_Constant_TextObjectType worker_Type_ReferenceField;

		private DateTime deferral_Date_after_AssessmentField;

		private bool deferral_Date_after_AssessmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Assessment_Date
		{
			get
			{
				return this.assessment_DateField;
			}
			set
			{
				this.assessment_DateField = value;
				this.RaisePropertyChanged("Assessment_Date");
			}
		}

		[XmlIgnore]
		public bool Assessment_DateSpecified
		{
			get
			{
				return this.assessment_DateFieldSpecified;
			}
			set
			{
				this.assessment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assessment_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Constant_TextObjectType Worker_Type_Reference
		{
			get
			{
				return this.worker_Type_ReferenceField;
			}
			set
			{
				this.worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Deferral_Date_after_Assessment
		{
			get
			{
				return this.deferral_Date_after_AssessmentField;
			}
			set
			{
				this.deferral_Date_after_AssessmentField = value;
				this.RaisePropertyChanged("Deferral_Date_after_Assessment");
			}
		}

		[XmlIgnore]
		public bool Deferral_Date_after_AssessmentSpecified
		{
			get
			{
				return this.deferral_Date_after_AssessmentFieldSpecified;
			}
			set
			{
				this.deferral_Date_after_AssessmentFieldSpecified = value;
				this.RaisePropertyChanged("Deferral_Date_after_AssessmentSpecified");
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
