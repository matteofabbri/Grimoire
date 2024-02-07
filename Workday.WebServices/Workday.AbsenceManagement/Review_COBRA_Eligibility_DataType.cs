using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_COBRA_Eligibility_DataType : INotifyPropertyChanged
	{
		private bool cOBRA_EligibleField;

		private bool cOBRA_EligibleFieldSpecified;

		private COBRA_Eligibility_ReasonObjectType reason_ReferenceField;

		private DateTime cOBRA_Eligible_DateField;

		private bool cOBRA_Eligible_DateFieldSpecified;

		private DateTime qualifying_Event_DateField;

		private bool qualifying_Event_DateFieldSpecified;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private COBRA_ParticipantObjectType[] participant_ReferenceField;

		private Benefit_PlanObjectType benefit_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool COBRA_Eligible
		{
			get
			{
				return this.cOBRA_EligibleField;
			}
			set
			{
				this.cOBRA_EligibleField = value;
				this.RaisePropertyChanged("COBRA_Eligible");
			}
		}

		[XmlIgnore]
		public bool COBRA_EligibleSpecified
		{
			get
			{
				return this.cOBRA_EligibleFieldSpecified;
			}
			set
			{
				this.cOBRA_EligibleFieldSpecified = value;
				this.RaisePropertyChanged("COBRA_EligibleSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public COBRA_Eligibility_ReasonObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime COBRA_Eligible_Date
		{
			get
			{
				return this.cOBRA_Eligible_DateField;
			}
			set
			{
				this.cOBRA_Eligible_DateField = value;
				this.RaisePropertyChanged("COBRA_Eligible_Date");
			}
		}

		[XmlIgnore]
		public bool COBRA_Eligible_DateSpecified
		{
			get
			{
				return this.cOBRA_Eligible_DateFieldSpecified;
			}
			set
			{
				this.cOBRA_Eligible_DateFieldSpecified = value;
				this.RaisePropertyChanged("COBRA_Eligible_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Qualifying_Event_Date
		{
			get
			{
				return this.qualifying_Event_DateField;
			}
			set
			{
				this.qualifying_Event_DateField = value;
				this.RaisePropertyChanged("Qualifying_Event_Date");
			}
		}

		[XmlIgnore]
		public bool Qualifying_Event_DateSpecified
		{
			get
			{
				return this.qualifying_Event_DateFieldSpecified;
			}
			set
			{
				this.qualifying_Event_DateFieldSpecified = value;
				this.RaisePropertyChanged("Qualifying_Event_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement("Participant_Reference", Order = 5)]
		public COBRA_ParticipantObjectType[] Participant_Reference
		{
			get
			{
				return this.participant_ReferenceField;
			}
			set
			{
				this.participant_ReferenceField = value;
				this.RaisePropertyChanged("Participant_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Benefit_PlanObjectType Benefit_Plan_Reference
		{
			get
			{
				return this.benefit_Plan_ReferenceField;
			}
			set
			{
				this.benefit_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Plan_Reference");
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
