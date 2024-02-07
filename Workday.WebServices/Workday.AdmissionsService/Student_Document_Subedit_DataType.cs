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
	public class Student_Document_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_DocumentObjectType student_Document_ReferenceField;

		private string idField;

		private Student_Document_TypeObjectType student_Document_Type_ReferenceField;

		private Student_Document_Type_CategoryObjectType student_Document_Type_Category_ReferenceField;

		private Student_ProxyObjectType provided_By_ReferenceField;

		private DateTime upload_DateField;

		private bool upload_DateFieldSpecified;

		private DateTime date_ReceivedField;

		private bool date_ReceivedFieldSpecified;

		private bool officialField;

		private bool officialFieldSpecified;

		private Student_Document_Attachment_Subedit_DataType[] student_Document_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_DocumentObjectType Student_Document_Reference
		{
			get
			{
				return this.student_Document_ReferenceField;
			}
			set
			{
				this.student_Document_ReferenceField = value;
				this.RaisePropertyChanged("Student_Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Student_Document_TypeObjectType Student_Document_Type_Reference
		{
			get
			{
				return this.student_Document_Type_ReferenceField;
			}
			set
			{
				this.student_Document_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Document_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Student_Document_Type_CategoryObjectType Student_Document_Type_Category_Reference
		{
			get
			{
				return this.student_Document_Type_Category_ReferenceField;
			}
			set
			{
				this.student_Document_Type_Category_ReferenceField = value;
				this.RaisePropertyChanged("Student_Document_Type_Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Student_ProxyObjectType Provided_By_Reference
		{
			get
			{
				return this.provided_By_ReferenceField;
			}
			set
			{
				this.provided_By_ReferenceField = value;
				this.RaisePropertyChanged("Provided_By_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Upload_Date
		{
			get
			{
				return this.upload_DateField;
			}
			set
			{
				this.upload_DateField = value;
				this.RaisePropertyChanged("Upload_Date");
			}
		}

		[XmlIgnore]
		public bool Upload_DateSpecified
		{
			get
			{
				return this.upload_DateFieldSpecified;
			}
			set
			{
				this.upload_DateFieldSpecified = value;
				this.RaisePropertyChanged("Upload_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Date_Received
		{
			get
			{
				return this.date_ReceivedField;
			}
			set
			{
				this.date_ReceivedField = value;
				this.RaisePropertyChanged("Date_Received");
			}
		}

		[XmlIgnore]
		public bool Date_ReceivedSpecified
		{
			get
			{
				return this.date_ReceivedFieldSpecified;
			}
			set
			{
				this.date_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Date_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Official
		{
			get
			{
				return this.officialField;
			}
			set
			{
				this.officialField = value;
				this.RaisePropertyChanged("Official");
			}
		}

		[XmlIgnore]
		public bool OfficialSpecified
		{
			get
			{
				return this.officialFieldSpecified;
			}
			set
			{
				this.officialFieldSpecified = value;
				this.RaisePropertyChanged("OfficialSpecified");
			}
		}

		[XmlElement("Student_Document_Attachment_Data", Order = 8)]
		public Student_Document_Attachment_Subedit_DataType[] Student_Document_Attachment_Data
		{
			get
			{
				return this.student_Document_Attachment_DataField;
			}
			set
			{
				this.student_Document_Attachment_DataField = value;
				this.RaisePropertyChanged("Student_Document_Attachment_Data");
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
