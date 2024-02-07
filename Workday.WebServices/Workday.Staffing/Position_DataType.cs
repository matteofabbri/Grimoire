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
	public class Position_DataType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Position_Details_DataType position_Definition_DataField;

		private Position_Group_Restriction_Summary_DataType position_Restrictions_DataField;

		private Compensation_Default_DataType default_Compensation_DataField;

		private Default_Position_Organization_Assignments_DataType default_Position_Organization_Assignments_DataField;

		private Worker_For_Filled_PositionType worker_For_Filled_PositionField;

		private Qualifications_from_Position_Restrictions_DataType qualification_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private Job_Requisition_DataType job_Requisition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Details_DataType Position_Definition_Data
		{
			get
			{
				return this.position_Definition_DataField;
			}
			set
			{
				this.position_Definition_DataField = value;
				this.RaisePropertyChanged("Position_Definition_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Position_Group_Restriction_Summary_DataType Position_Restrictions_Data
		{
			get
			{
				return this.position_Restrictions_DataField;
			}
			set
			{
				this.position_Restrictions_DataField = value;
				this.RaisePropertyChanged("Position_Restrictions_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Compensation_Default_DataType Default_Compensation_Data
		{
			get
			{
				return this.default_Compensation_DataField;
			}
			set
			{
				this.default_Compensation_DataField = value;
				this.RaisePropertyChanged("Default_Compensation_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Default_Position_Organization_Assignments_DataType Default_Position_Organization_Assignments_Data
		{
			get
			{
				return this.default_Position_Organization_Assignments_DataField;
			}
			set
			{
				this.default_Position_Organization_Assignments_DataField = value;
				this.RaisePropertyChanged("Default_Position_Organization_Assignments_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Worker_For_Filled_PositionType Worker_For_Filled_Position
		{
			get
			{
				return this.worker_For_Filled_PositionField;
			}
			set
			{
				this.worker_For_Filled_PositionField = value;
				this.RaisePropertyChanged("Worker_For_Filled_Position");
			}
		}

		[XmlElement(Order = 7)]
		public Qualifications_from_Position_Restrictions_DataType Qualification_Data
		{
			get
			{
				return this.qualification_DataField;
			}
			set
			{
				this.qualification_DataField = value;
				this.RaisePropertyChanged("Qualification_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 8)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Job_Requisition_DataType Job_Requisition_Data
		{
			get
			{
				return this.job_Requisition_DataField;
			}
			set
			{
				this.job_Requisition_DataField = value;
				this.RaisePropertyChanged("Job_Requisition_Data");
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
