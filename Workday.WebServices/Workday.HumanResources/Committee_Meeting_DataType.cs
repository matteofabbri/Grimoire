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
	public class Committee_Meeting_DataType : INotifyPropertyChanged
	{
		private string committee_Meeting_IDField;

		private CommitteeObjectType committee_ReferenceField;

		private Committee_Meeting_StatusObjectType committee_Meeting_Status_ReferenceField;

		private string committee_Meeting_HostField;

		private Committee_Meeting_TypeObjectType committee_Meeting_Type_ReferenceField;

		private string committee_Meeting_SubjectField;

		private string committee_Meeting_AbstractField;

		private DateTime committee_Meeting_DateField;

		private DateTime committee_Meeting_TimeField;

		private Time_ZoneObjectType committee_Meeting_Time_Zone_ReferenceField;

		private decimal duration_in_HoursField;

		private string committee_Meeting_LocationField;

		private object[] itemsField;

		private Committee_Member_EnabledObjectType[] committee_Meeting_Attendee_ReferenceField;

		private Committee_Meeting_Minutes_SubDataType committee_Meeting_Minutes_DataField;

		private Committee_Meeting_Attachment_DataType[] attachmentsField;

		private Committee_Meeting_Action_Item_Sub_DataType[] committee_Meeting_Action_Item_DataField;

		private Committee_Meeting_Agenda_Item_Data_SubeditType[] committee_Meeting_Agenda_Item_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Committee_Meeting_ID
		{
			get
			{
				return this.committee_Meeting_IDField;
			}
			set
			{
				this.committee_Meeting_IDField = value;
				this.RaisePropertyChanged("Committee_Meeting_ID");
			}
		}

		[XmlElement(Order = 1)]
		public CommitteeObjectType Committee_Reference
		{
			get
			{
				return this.committee_ReferenceField;
			}
			set
			{
				this.committee_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Committee_Meeting_StatusObjectType Committee_Meeting_Status_Reference
		{
			get
			{
				return this.committee_Meeting_Status_ReferenceField;
			}
			set
			{
				this.committee_Meeting_Status_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Committee_Meeting_Host
		{
			get
			{
				return this.committee_Meeting_HostField;
			}
			set
			{
				this.committee_Meeting_HostField = value;
				this.RaisePropertyChanged("Committee_Meeting_Host");
			}
		}

		[XmlElement(Order = 4)]
		public Committee_Meeting_TypeObjectType Committee_Meeting_Type_Reference
		{
			get
			{
				return this.committee_Meeting_Type_ReferenceField;
			}
			set
			{
				this.committee_Meeting_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Committee_Meeting_Subject
		{
			get
			{
				return this.committee_Meeting_SubjectField;
			}
			set
			{
				this.committee_Meeting_SubjectField = value;
				this.RaisePropertyChanged("Committee_Meeting_Subject");
			}
		}

		[XmlElement(Order = 6)]
		public string Committee_Meeting_Abstract
		{
			get
			{
				return this.committee_Meeting_AbstractField;
			}
			set
			{
				this.committee_Meeting_AbstractField = value;
				this.RaisePropertyChanged("Committee_Meeting_Abstract");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Committee_Meeting_Date
		{
			get
			{
				return this.committee_Meeting_DateField;
			}
			set
			{
				this.committee_Meeting_DateField = value;
				this.RaisePropertyChanged("Committee_Meeting_Date");
			}
		}

		[XmlElement(DataType = "time", Order = 8)]
		public DateTime Committee_Meeting_Time
		{
			get
			{
				return this.committee_Meeting_TimeField;
			}
			set
			{
				this.committee_Meeting_TimeField = value;
				this.RaisePropertyChanged("Committee_Meeting_Time");
			}
		}

		[XmlElement(Order = 9)]
		public Time_ZoneObjectType Committee_Meeting_Time_Zone_Reference
		{
			get
			{
				return this.committee_Meeting_Time_Zone_ReferenceField;
			}
			set
			{
				this.committee_Meeting_Time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Duration_in_Hours
		{
			get
			{
				return this.duration_in_HoursField;
			}
			set
			{
				this.duration_in_HoursField = value;
				this.RaisePropertyChanged("Duration_in_Hours");
			}
		}

		[XmlElement(Order = 11)]
		public string Committee_Meeting_Location
		{
			get
			{
				return this.committee_Meeting_LocationField;
			}
			set
			{
				this.committee_Meeting_LocationField = value;
				this.RaisePropertyChanged("Committee_Meeting_Location");
			}
		}

		[XmlElement("Committee_Meeting_Invite_All_Members", typeof(bool), Order = 12), XmlElement("Committee_Member_Reference", typeof(Committee_Member_EnabledObjectType), Order = 12)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("Committee_Meeting_Attendee_Reference", Order = 13)]
		public Committee_Member_EnabledObjectType[] Committee_Meeting_Attendee_Reference
		{
			get
			{
				return this.committee_Meeting_Attendee_ReferenceField;
			}
			set
			{
				this.committee_Meeting_Attendee_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Attendee_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Committee_Meeting_Minutes_SubDataType Committee_Meeting_Minutes_Data
		{
			get
			{
				return this.committee_Meeting_Minutes_DataField;
			}
			set
			{
				this.committee_Meeting_Minutes_DataField = value;
				this.RaisePropertyChanged("Committee_Meeting_Minutes_Data");
			}
		}

		[XmlArray(Order = 15), XmlArrayItem("Committee_Meeting_Attachment_Data", IsNullable = false)]
		public Committee_Meeting_Attachment_DataType[] Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
				this.RaisePropertyChanged("Attachments");
			}
		}

		[XmlElement("Committee_Meeting_Action_Item_Data", Order = 16)]
		public Committee_Meeting_Action_Item_Sub_DataType[] Committee_Meeting_Action_Item_Data
		{
			get
			{
				return this.committee_Meeting_Action_Item_DataField;
			}
			set
			{
				this.committee_Meeting_Action_Item_DataField = value;
				this.RaisePropertyChanged("Committee_Meeting_Action_Item_Data");
			}
		}

		[XmlElement("Committee_Meeting_Agenda_Item_Data", Order = 17)]
		public Committee_Meeting_Agenda_Item_Data_SubeditType[] Committee_Meeting_Agenda_Item_Data
		{
			get
			{
				return this.committee_Meeting_Agenda_Item_DataField;
			}
			set
			{
				this.committee_Meeting_Agenda_Item_DataField = value;
				this.RaisePropertyChanged("Committee_Meeting_Agenda_Item_Data");
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
