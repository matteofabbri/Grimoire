using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Meeting_Agenda_Item_Data_SubeditType : INotifyPropertyChanged
	{
		private Committee_Meeting_Agenda_ItemObjectType agenda_Item_ReferenceField;

		private string agenda_Item_IDField;

		private string agenda_Item_NumberField;

		private string agenda_Item_DescriptionField;

		private Committee_Meeting_Agenda_Item_TypeObjectType committee_Meeting_Agenda_Item_Type_ReferenceField;

		private string agenda_Item_PresenterField;

		private string agenda_Item_DetailsField;

		private Unique_IdentifierObjectType related_Academic_Appointment_Event_ReferenceField;

		private Committee_Meeting_Minutes_SubDataType agenda_Item_Minutes_DataField;

		private Committee_Meeting_Action_Item_Sub_DataType[] agenda_Item_Action_Item_DataField;

		private Committee_Meeting_Agenda_Item_Attachment_DataType[] attachmentsField;

		private Committee_Meeting_Agenda_Item_Vote_Data_SubeditType[] committee_Meeting_Agenda_Item_VoteField;

		private bool delete_OnlyField;

		private bool delete_OnlyFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_Agenda_ItemObjectType Agenda_Item_Reference
		{
			get
			{
				return this.agenda_Item_ReferenceField;
			}
			set
			{
				this.agenda_Item_ReferenceField = value;
				this.RaisePropertyChanged("Agenda_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Agenda_Item_ID
		{
			get
			{
				return this.agenda_Item_IDField;
			}
			set
			{
				this.agenda_Item_IDField = value;
				this.RaisePropertyChanged("Agenda_Item_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Agenda_Item_Number
		{
			get
			{
				return this.agenda_Item_NumberField;
			}
			set
			{
				this.agenda_Item_NumberField = value;
				this.RaisePropertyChanged("Agenda_Item_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Agenda_Item_Description
		{
			get
			{
				return this.agenda_Item_DescriptionField;
			}
			set
			{
				this.agenda_Item_DescriptionField = value;
				this.RaisePropertyChanged("Agenda_Item_Description");
			}
		}

		[XmlElement(Order = 4)]
		public Committee_Meeting_Agenda_Item_TypeObjectType Committee_Meeting_Agenda_Item_Type_Reference
		{
			get
			{
				return this.committee_Meeting_Agenda_Item_Type_ReferenceField;
			}
			set
			{
				this.committee_Meeting_Agenda_Item_Type_ReferenceField = value;
				this.RaisePropertyChanged("Committee_Meeting_Agenda_Item_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Agenda_Item_Presenter
		{
			get
			{
				return this.agenda_Item_PresenterField;
			}
			set
			{
				this.agenda_Item_PresenterField = value;
				this.RaisePropertyChanged("Agenda_Item_Presenter");
			}
		}

		[XmlElement(Order = 6)]
		public string Agenda_Item_Details
		{
			get
			{
				return this.agenda_Item_DetailsField;
			}
			set
			{
				this.agenda_Item_DetailsField = value;
				this.RaisePropertyChanged("Agenda_Item_Details");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Related_Academic_Appointment_Event_Reference
		{
			get
			{
				return this.related_Academic_Appointment_Event_ReferenceField;
			}
			set
			{
				this.related_Academic_Appointment_Event_ReferenceField = value;
				this.RaisePropertyChanged("Related_Academic_Appointment_Event_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Committee_Meeting_Minutes_SubDataType Agenda_Item_Minutes_Data
		{
			get
			{
				return this.agenda_Item_Minutes_DataField;
			}
			set
			{
				this.agenda_Item_Minutes_DataField = value;
				this.RaisePropertyChanged("Agenda_Item_Minutes_Data");
			}
		}

		[XmlElement("Agenda_Item_Action_Item_Data", Order = 9)]
		public Committee_Meeting_Action_Item_Sub_DataType[] Agenda_Item_Action_Item_Data
		{
			get
			{
				return this.agenda_Item_Action_Item_DataField;
			}
			set
			{
				this.agenda_Item_Action_Item_DataField = value;
				this.RaisePropertyChanged("Agenda_Item_Action_Item_Data");
			}
		}

		[XmlArray(Order = 10), XmlArrayItem("Committee_Meeting_Agenda_Item_Attachment_Data", IsNullable = false)]
		public Committee_Meeting_Agenda_Item_Attachment_DataType[] Attachments
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

		[XmlElement("Committee_Meeting_Agenda_Item_Vote", Order = 11)]
		public Committee_Meeting_Agenda_Item_Vote_Data_SubeditType[] Committee_Meeting_Agenda_Item_Vote
		{
			get
			{
				return this.committee_Meeting_Agenda_Item_VoteField;
			}
			set
			{
				this.committee_Meeting_Agenda_Item_VoteField = value;
				this.RaisePropertyChanged("Committee_Meeting_Agenda_Item_Vote");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete_Only
		{
			get
			{
				return this.delete_OnlyField;
			}
			set
			{
				this.delete_OnlyField = value;
				this.RaisePropertyChanged("Delete_Only");
			}
		}

		[XmlIgnore]
		public bool Delete_OnlySpecified
		{
			get
			{
				return this.delete_OnlyFieldSpecified;
			}
			set
			{
				this.delete_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Delete_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
