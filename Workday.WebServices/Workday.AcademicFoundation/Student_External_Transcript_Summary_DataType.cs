using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Transcript_Summary_DataType : INotifyPropertyChanged
	{
		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		private bool officialField;

		private bool officialFieldSpecified;

		private DateTime student_External_Transcript_Issued_DateField;

		private DateTime student_External_Transcript_Received_DateField;

		private bool student_External_Transcript_Received_DateFieldSpecified;

		private DateTime academic_Start_DateField;

		private bool academic_Start_DateFieldSpecified;

		private DateTime academic_End_DateField;

		private bool academic_End_DateFieldSpecified;

		private Transcript_Exit_CodeObjectType exit_Code_ReferenceField;

		private Student_External_Transcript_TypeObjectType student_External_Transcript_Type_ReferenceField;

		private DateTime entry_DateField;

		private bool entry_DateFieldSpecified;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		private string updated_ByField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Student_External_Transcript_Issued_Date
		{
			get
			{
				return this.student_External_Transcript_Issued_DateField;
			}
			set
			{
				this.student_External_Transcript_Issued_DateField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Issued_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Student_External_Transcript_Received_Date
		{
			get
			{
				return this.student_External_Transcript_Received_DateField;
			}
			set
			{
				this.student_External_Transcript_Received_DateField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Received_Date");
			}
		}

		[XmlIgnore]
		public bool Student_External_Transcript_Received_DateSpecified
		{
			get
			{
				return this.student_External_Transcript_Received_DateFieldSpecified;
			}
			set
			{
				this.student_External_Transcript_Received_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_External_Transcript_Received_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Academic_Start_Date
		{
			get
			{
				return this.academic_Start_DateField;
			}
			set
			{
				this.academic_Start_DateField = value;
				this.RaisePropertyChanged("Academic_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Start_DateSpecified
		{
			get
			{
				return this.academic_Start_DateFieldSpecified;
			}
			set
			{
				this.academic_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Academic_End_Date
		{
			get
			{
				return this.academic_End_DateField;
			}
			set
			{
				this.academic_End_DateField = value;
				this.RaisePropertyChanged("Academic_End_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_End_DateSpecified
		{
			get
			{
				return this.academic_End_DateFieldSpecified;
			}
			set
			{
				this.academic_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Transcript_Exit_CodeObjectType Exit_Code_Reference
		{
			get
			{
				return this.exit_Code_ReferenceField;
			}
			set
			{
				this.exit_Code_ReferenceField = value;
				this.RaisePropertyChanged("Exit_Code_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Student_External_Transcript_TypeObjectType Student_External_Transcript_Type_Reference
		{
			get
			{
				return this.student_External_Transcript_Type_ReferenceField;
			}
			set
			{
				this.student_External_Transcript_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Entry_Date
		{
			get
			{
				return this.entry_DateField;
			}
			set
			{
				this.entry_DateField = value;
				this.RaisePropertyChanged("Entry_Date");
			}
		}

		[XmlIgnore]
		public bool Entry_DateSpecified
		{
			get
			{
				return this.entry_DateFieldSpecified;
			}
			set
			{
				this.entry_DateFieldSpecified = value;
				this.RaisePropertyChanged("Entry_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Last_UpdatedSpecified
		{
			get
			{
				return this.last_UpdatedFieldSpecified;
			}
			set
			{
				this.last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Last_UpdatedSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Updated_By
		{
			get
			{
				return this.updated_ByField;
			}
			set
			{
				this.updated_ByField = value;
				this.RaisePropertyChanged("Updated_By");
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
