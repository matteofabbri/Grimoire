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
	public class Job_Posting_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Job_Requisition_Restrictions_DataField;

		private bool include_Job_Requisition_Restrictions_DataFieldSpecified;

		private bool include_Job_Requisition_Definition_DataField;

		private bool include_Job_Requisition_Definition_DataFieldSpecified;

		private bool include_QualificationsField;

		private bool include_QualificationsFieldSpecified;

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
		public bool Include_Job_Requisition_Restrictions_Data
		{
			get
			{
				return this.include_Job_Requisition_Restrictions_DataField;
			}
			set
			{
				this.include_Job_Requisition_Restrictions_DataField = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Restrictions_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Requisition_Restrictions_DataSpecified
		{
			get
			{
				return this.include_Job_Requisition_Restrictions_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Requisition_Restrictions_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Restrictions_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Job_Requisition_Definition_Data
		{
			get
			{
				return this.include_Job_Requisition_Definition_DataField;
			}
			set
			{
				this.include_Job_Requisition_Definition_DataField = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Definition_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Requisition_Definition_DataSpecified
		{
			get
			{
				return this.include_Job_Requisition_Definition_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Requisition_Definition_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Requisition_Definition_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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
