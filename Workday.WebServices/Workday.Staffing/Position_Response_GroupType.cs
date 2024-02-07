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
	public class Position_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Position_Definition_DataField;

		private bool include_Position_Definition_DataFieldSpecified;

		private bool include_Position_Restrictions_DataField;

		private bool include_Position_Restrictions_DataFieldSpecified;

		private bool include_Default_Compensation_DataField;

		private bool include_Default_Compensation_DataFieldSpecified;

		private bool include_Default_Position_Organization_Assignment_DataField;

		private bool include_Default_Position_Organization_Assignment_DataFieldSpecified;

		private bool include_Worker_For_Filled_Positions_DataField;

		private bool include_Worker_For_Filled_Positions_DataFieldSpecified;

		private bool include_QualificationsField;

		private bool include_QualificationsFieldSpecified;

		private bool include_Job_Requisition_DataField;

		private bool include_Job_Requisition_DataFieldSpecified;

		private bool include_Job_Requisition_AttachmentsField;

		private bool include_Job_Requisition_AttachmentsFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Position_Definition_Data
		{
			get
			{
				return this.include_Position_Definition_DataField;
			}
			set
			{
				this.include_Position_Definition_DataField = value;
				this.RaisePropertyChanged("Include_Position_Definition_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Position_Definition_DataSpecified
		{
			get
			{
				return this.include_Position_Definition_DataFieldSpecified;
			}
			set
			{
				this.include_Position_Definition_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Position_Definition_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Position_Restrictions_Data
		{
			get
			{
				return this.include_Position_Restrictions_DataField;
			}
			set
			{
				this.include_Position_Restrictions_DataField = value;
				this.RaisePropertyChanged("Include_Position_Restrictions_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Position_Restrictions_DataSpecified
		{
			get
			{
				return this.include_Position_Restrictions_DataFieldSpecified;
			}
			set
			{
				this.include_Position_Restrictions_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Position_Restrictions_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Default_Compensation_Data
		{
			get
			{
				return this.include_Default_Compensation_DataField;
			}
			set
			{
				this.include_Default_Compensation_DataField = value;
				this.RaisePropertyChanged("Include_Default_Compensation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Default_Compensation_DataSpecified
		{
			get
			{
				return this.include_Default_Compensation_DataFieldSpecified;
			}
			set
			{
				this.include_Default_Compensation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Default_Compensation_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Default_Position_Organization_Assignment_Data
		{
			get
			{
				return this.include_Default_Position_Organization_Assignment_DataField;
			}
			set
			{
				this.include_Default_Position_Organization_Assignment_DataField = value;
				this.RaisePropertyChanged("Include_Default_Position_Organization_Assignment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Default_Position_Organization_Assignment_DataSpecified
		{
			get
			{
				return this.include_Default_Position_Organization_Assignment_DataFieldSpecified;
			}
			set
			{
				this.include_Default_Position_Organization_Assignment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Default_Position_Organization_Assignment_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Worker_For_Filled_Positions_Data
		{
			get
			{
				return this.include_Worker_For_Filled_Positions_DataField;
			}
			set
			{
				this.include_Worker_For_Filled_Positions_DataField = value;
				this.RaisePropertyChanged("Include_Worker_For_Filled_Positions_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Worker_For_Filled_Positions_DataSpecified
		{
			get
			{
				return this.include_Worker_For_Filled_Positions_DataFieldSpecified;
			}
			set
			{
				this.include_Worker_For_Filled_Positions_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Worker_For_Filled_Positions_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Qualifications
		{
			get
			{
				return this.include_QualificationsField;
			}
			set
			{
				this.include_QualificationsField = value;
				this.RaisePropertyChanged("Include_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_QualificationsSpecified
		{
			get
			{
				return this.include_QualificationsFieldSpecified;
			}
			set
			{
				this.include_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_Job_Requisition_Data
		{
			get
			{
				return this.include_Job_Requisition_DataField;
			}
			set
			{
				this.include_Job_Requisition_DataField = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Requisition_DataSpecified
		{
			get
			{
				return this.include_Job_Requisition_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Requisition_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Requisition_DataSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Job_Requisition_Attachments
		{
			get
			{
				return this.include_Job_Requisition_AttachmentsField;
			}
			set
			{
				this.include_Job_Requisition_AttachmentsField = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Attachments");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Requisition_AttachmentsSpecified
		{
			get
			{
				return this.include_Job_Requisition_AttachmentsFieldSpecified;
			}
			set
			{
				this.include_Job_Requisition_AttachmentsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Requisition_AttachmentsSpecified");
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
