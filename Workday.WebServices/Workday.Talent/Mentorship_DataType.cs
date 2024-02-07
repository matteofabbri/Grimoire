using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Mentorship_DataType : INotifyPropertyChanged
	{
		private string idField;

		private WorkerObjectType mentor_ReferenceField;

		private WorkerObjectType mentee_ReferenceField;

		private Mentor_TypeObjectType mentor_Type_ReferenceField;

		private DateTime mentorship_Start_DateField;

		private bool mentorship_Start_DateFieldSpecified;

		private DateTime mentorship_End_DateField;

		private bool mentorship_End_DateFieldSpecified;

		private string mentorship_PurposeField;

		private MentorshipObjectType mentorship_ReferenceField;

		private Close_Mentorship_ReasonObjectType close_Mentorship_Reason_ReferenceField;

		private Event_AttachmentObjectType[] attachments_ReferenceField;

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
		public WorkerObjectType Mentor_Reference
		{
			get
			{
				return this.mentor_ReferenceField;
			}
			set
			{
				this.mentor_ReferenceField = value;
				this.RaisePropertyChanged("Mentor_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Mentee_Reference
		{
			get
			{
				return this.mentee_ReferenceField;
			}
			set
			{
				this.mentee_ReferenceField = value;
				this.RaisePropertyChanged("Mentee_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Mentor_TypeObjectType Mentor_Type_Reference
		{
			get
			{
				return this.mentor_Type_ReferenceField;
			}
			set
			{
				this.mentor_Type_ReferenceField = value;
				this.RaisePropertyChanged("Mentor_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Mentorship_Start_Date
		{
			get
			{
				return this.mentorship_Start_DateField;
			}
			set
			{
				this.mentorship_Start_DateField = value;
				this.RaisePropertyChanged("Mentorship_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Mentorship_Start_DateSpecified
		{
			get
			{
				return this.mentorship_Start_DateFieldSpecified;
			}
			set
			{
				this.mentorship_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Mentorship_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Mentorship_End_Date
		{
			get
			{
				return this.mentorship_End_DateField;
			}
			set
			{
				this.mentorship_End_DateField = value;
				this.RaisePropertyChanged("Mentorship_End_Date");
			}
		}

		[XmlIgnore]
		public bool Mentorship_End_DateSpecified
		{
			get
			{
				return this.mentorship_End_DateFieldSpecified;
			}
			set
			{
				this.mentorship_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Mentorship_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Mentorship_Purpose
		{
			get
			{
				return this.mentorship_PurposeField;
			}
			set
			{
				this.mentorship_PurposeField = value;
				this.RaisePropertyChanged("Mentorship_Purpose");
			}
		}

		[XmlElement(Order = 7)]
		public MentorshipObjectType Mentorship_Reference
		{
			get
			{
				return this.mentorship_ReferenceField;
			}
			set
			{
				this.mentorship_ReferenceField = value;
				this.RaisePropertyChanged("Mentorship_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Close_Mentorship_ReasonObjectType Close_Mentorship_Reason_Reference
		{
			get
			{
				return this.close_Mentorship_Reason_ReferenceField;
			}
			set
			{
				this.close_Mentorship_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Close_Mentorship_Reason_Reference");
			}
		}

		[XmlElement("Attachments_Reference", Order = 9)]
		public Event_AttachmentObjectType[] Attachments_Reference
		{
			get
			{
				return this.attachments_ReferenceField;
			}
			set
			{
				this.attachments_ReferenceField = value;
				this.RaisePropertyChanged("Attachments_Reference");
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
