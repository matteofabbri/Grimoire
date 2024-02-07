using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Action_Item_Assignment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Application_Action_ItemObjectType engagement_Action_Item_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private Engagement_Action_Item_AssignableObjectType engagement_Action_Item_Assignable_ReferenceField;

		private Engagement_Action_Item_Assignment_StatusObjectType assignment_Status_ReferenceField;

		private DateTime completion_DateField;

		private bool completion_DateFieldSpecified;

		private Engagement_Action_Item_Waiver_ReasonObjectType engagement_Action_Item_Waiver_Reason_ReferenceField;

		private string engagement_Action_Item_NotesField;

		private External_URL_for_Action_Item_DataType[] external_URL_DataField;

		private Student_Attachment_Drag_and_Drop_DataType[] student_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public Application_Action_ItemObjectType Engagement_Action_Item_Reference
		{
			get
			{
				return this.engagement_Action_Item_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Engagement_Action_Item_AssignableObjectType Engagement_Action_Item_Assignable_Reference
		{
			get
			{
				return this.engagement_Action_Item_Assignable_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_Assignable_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Assignable_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Engagement_Action_Item_Assignment_StatusObjectType Assignment_Status_Reference
		{
			get
			{
				return this.assignment_Status_ReferenceField;
			}
			set
			{
				this.assignment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Assignment_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Completion_Date
		{
			get
			{
				return this.completion_DateField;
			}
			set
			{
				this.completion_DateField = value;
				this.RaisePropertyChanged("Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Completion_DateSpecified
		{
			get
			{
				return this.completion_DateFieldSpecified;
			}
			set
			{
				this.completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completion_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Engagement_Action_Item_Waiver_ReasonObjectType Engagement_Action_Item_Waiver_Reason_Reference
		{
			get
			{
				return this.engagement_Action_Item_Waiver_Reason_ReferenceField;
			}
			set
			{
				this.engagement_Action_Item_Waiver_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Waiver_Reason_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Engagement_Action_Item_Notes
		{
			get
			{
				return this.engagement_Action_Item_NotesField;
			}
			set
			{
				this.engagement_Action_Item_NotesField = value;
				this.RaisePropertyChanged("Engagement_Action_Item_Notes");
			}
		}

		[XmlElement("External_URL_Data", Order = 8)]
		public External_URL_for_Action_Item_DataType[] External_URL_Data
		{
			get
			{
				return this.external_URL_DataField;
			}
			set
			{
				this.external_URL_DataField = value;
				this.RaisePropertyChanged("External_URL_Data");
			}
		}

		[XmlElement("Student_Attachment_Data", Order = 9)]
		public Student_Attachment_Drag_and_Drop_DataType[] Student_Attachment_Data
		{
			get
			{
				return this.student_Attachment_DataField;
			}
			set
			{
				this.student_Attachment_DataField = value;
				this.RaisePropertyChanged("Student_Attachment_Data");
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
