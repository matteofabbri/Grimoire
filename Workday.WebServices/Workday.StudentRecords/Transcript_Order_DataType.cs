using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Transcript_Order_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime transcript_Request_DateField;

		private bool transcript_Request_DateFieldSpecified;

		private StudentObjectType student_ReferenceField;

		private Academic_LevelObjectType academic_Level_ReferenceField;

		private Transcript_Delivery_TypeObjectType transcript_Delivery_Method_ReferenceField;

		private decimal number_of_TranscriptsField;

		private string recipient_Name_or_OrganizationField;

		private Contact_Information_DataType contact_Information_DataField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Transcript_Request_Date
		{
			get
			{
				return this.transcript_Request_DateField;
			}
			set
			{
				this.transcript_Request_DateField = value;
				this.RaisePropertyChanged("Transcript_Request_Date");
			}
		}

		[XmlIgnore]
		public bool Transcript_Request_DateSpecified
		{
			get
			{
				return this.transcript_Request_DateFieldSpecified;
			}
			set
			{
				this.transcript_Request_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transcript_Request_DateSpecified");
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
		public Academic_LevelObjectType Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Transcript_Delivery_TypeObjectType Transcript_Delivery_Method_Reference
		{
			get
			{
				return this.transcript_Delivery_Method_ReferenceField;
			}
			set
			{
				this.transcript_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Transcript_Delivery_Method_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Number_of_Transcripts
		{
			get
			{
				return this.number_of_TranscriptsField;
			}
			set
			{
				this.number_of_TranscriptsField = value;
				this.RaisePropertyChanged("Number_of_Transcripts");
			}
		}

		[XmlElement(Order = 6)]
		public string Recipient_Name_or_Organization
		{
			get
			{
				return this.recipient_Name_or_OrganizationField;
			}
			set
			{
				this.recipient_Name_or_OrganizationField = value;
				this.RaisePropertyChanged("Recipient_Name_or_Organization");
			}
		}

		[XmlElement(Order = 7)]
		public Contact_Information_DataType Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
			}
		}

		[XmlElement("Student_Attachment_Data", Order = 8)]
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
