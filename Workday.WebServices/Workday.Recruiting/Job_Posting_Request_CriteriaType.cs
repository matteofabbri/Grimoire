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
	public class Job_Posting_Request_CriteriaType : INotifyPropertyChanged
	{
		private DateTime job_Posting_Start_DateField;

		private bool job_Posting_Start_DateFieldSpecified;

		private DateTime job_Posting_End_DateField;

		private bool job_Posting_End_DateFieldSpecified;

		private string job_Posting_Site_NameField;

		private Job_Posting_SiteObjectType[] job_Posting_Site_ReferenceField;

		private Supervisory_OrganizationObjectType[] supervisory_Organization_ReferenceField;

		private Job_Requisition_EnabledObjectType[] job_Requisition_ReferenceField;

		private bool show_Only_Active_Job_PostingsField;

		private bool show_Only_Active_Job_PostingsFieldSpecified;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Job_Posting_Start_Date
		{
			get
			{
				return this.job_Posting_Start_DateField;
			}
			set
			{
				this.job_Posting_Start_DateField = value;
				this.RaisePropertyChanged("Job_Posting_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_Start_DateSpecified
		{
			get
			{
				return this.job_Posting_Start_DateFieldSpecified;
			}
			set
			{
				this.job_Posting_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Job_Posting_End_Date
		{
			get
			{
				return this.job_Posting_End_DateField;
			}
			set
			{
				this.job_Posting_End_DateField = value;
				this.RaisePropertyChanged("Job_Posting_End_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_End_DateSpecified
		{
			get
			{
				return this.job_Posting_End_DateFieldSpecified;
			}
			set
			{
				this.job_Posting_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_End_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Job_Posting_Site_Name
		{
			get
			{
				return this.job_Posting_Site_NameField;
			}
			set
			{
				this.job_Posting_Site_NameField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Name");
			}
		}

		[XmlElement("Job_Posting_Site_Reference", Order = 3)]
		public Job_Posting_SiteObjectType[] Job_Posting_Site_Reference
		{
			get
			{
				return this.job_Posting_Site_ReferenceField;
			}
			set
			{
				this.job_Posting_Site_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Reference");
			}
		}

		[XmlElement("Supervisory_Organization_Reference", Order = 4)]
		public Supervisory_OrganizationObjectType[] Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Job_Requisition_Reference", Order = 5)]
		public Job_Requisition_EnabledObjectType[] Job_Requisition_Reference
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

		[XmlElement(Order = 6)]
		public bool Show_Only_Active_Job_Postings
		{
			get
			{
				return this.show_Only_Active_Job_PostingsField;
			}
			set
			{
				this.show_Only_Active_Job_PostingsField = value;
				this.RaisePropertyChanged("Show_Only_Active_Job_Postings");
			}
		}

		[XmlIgnore]
		public bool Show_Only_Active_Job_PostingsSpecified
		{
			get
			{
				return this.show_Only_Active_Job_PostingsFieldSpecified;
			}
			set
			{
				this.show_Only_Active_Job_PostingsFieldSpecified = value;
				this.RaisePropertyChanged("Show_Only_Active_Job_PostingsSpecified");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
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
