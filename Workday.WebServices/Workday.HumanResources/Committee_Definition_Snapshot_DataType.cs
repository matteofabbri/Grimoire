using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Definition_Snapshot_DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private string committee_NameField;

		private string committee_CodeField;

		private Committee_Sponsoring_OrganizationObjectType sponsoring_Organization_ReferenceField;

		private Job_RequisitionObjectType[] job_Requisition_ReferenceField;

		private CommitteeObjectType superior_Committee_ReferenceField;

		private string committee_SummaryField;

		private string committee_Purpose__DetailedField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Committee_Membership_Targets_Data_SubeditType[] committee_Membership_Target_Data_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public string Committee_Name
		{
			get
			{
				return this.committee_NameField;
			}
			set
			{
				this.committee_NameField = value;
				this.RaisePropertyChanged("Committee_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Committee_Code
		{
			get
			{
				return this.committee_CodeField;
			}
			set
			{
				this.committee_CodeField = value;
				this.RaisePropertyChanged("Committee_Code");
			}
		}

		[XmlElement(Order = 3)]
		public Committee_Sponsoring_OrganizationObjectType Sponsoring_Organization_Reference
		{
			get
			{
				return this.sponsoring_Organization_ReferenceField;
			}
			set
			{
				this.sponsoring_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Sponsoring_Organization_Reference");
			}
		}

		[XmlElement("Job_Requisition_Reference", Order = 4)]
		public Job_RequisitionObjectType[] Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public CommitteeObjectType Superior_Committee_Reference
		{
			get
			{
				return this.superior_Committee_ReferenceField;
			}
			set
			{
				this.superior_Committee_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Committee_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Committee_Summary
		{
			get
			{
				return this.committee_SummaryField;
			}
			set
			{
				this.committee_SummaryField = value;
				this.RaisePropertyChanged("Committee_Summary");
			}
		}

		[XmlElement("Committee_Purpose_-_Detailed", Order = 7)]
		public string Committee_Purpose__Detailed
		{
			get
			{
				return this.committee_Purpose__DetailedField;
			}
			set
			{
				this.committee_Purpose__DetailedField = value;
				this.RaisePropertyChanged("Committee_Purpose__Detailed");
			}
		}

		[XmlElement(Order = 8)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Committee_Membership_Target_Data_Reference", Order = 9)]
		public Committee_Membership_Targets_Data_SubeditType[] Committee_Membership_Target_Data_Reference
		{
			get
			{
				return this.committee_Membership_Target_Data_ReferenceField;
			}
			set
			{
				this.committee_Membership_Target_Data_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Membership_Target_Data_Reference");
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
