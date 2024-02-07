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
	public class Student_External_Transcript_External_Credential_DataType : INotifyPropertyChanged
	{
		private Student_External_CredentialObjectType student_External_Credential_ReferenceField;

		private string idField;

		private Student_External_Credential_TypeObjectType student_External_Credential_Type_ReferenceField;

		private DateTime student_External_Credential_Earned_DateField;

		private bool student_External_Credential_Earned_DateFieldSpecified;

		private CIP_Code__Workday_Owned_ObjectType cIP_Code_ReferenceField;

		private string student_External_Credential_Program_DescriptionField;

		private decimal student_External_Credential_Cumulative_GPAField;

		private bool student_External_Credential_Cumulative_GPAFieldSpecified;

		private decimal student_External_Credential_Weighted_GPAField;

		private bool student_External_Credential_Weighted_GPAFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_CredentialObjectType Student_External_Credential_Reference
		{
			get
			{
				return this.student_External_Credential_ReferenceField;
			}
			set
			{
				this.student_External_Credential_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Credential_Reference");
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
		public Student_External_Credential_TypeObjectType Student_External_Credential_Type_Reference
		{
			get
			{
				return this.student_External_Credential_Type_ReferenceField;
			}
			set
			{
				this.student_External_Credential_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Credential_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Student_External_Credential_Earned_Date
		{
			get
			{
				return this.student_External_Credential_Earned_DateField;
			}
			set
			{
				this.student_External_Credential_Earned_DateField = value;
				this.RaisePropertyChanged("Student_External_Credential_Earned_Date");
			}
		}

		[XmlIgnore]
		public bool Student_External_Credential_Earned_DateSpecified
		{
			get
			{
				return this.student_External_Credential_Earned_DateFieldSpecified;
			}
			set
			{
				this.student_External_Credential_Earned_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_External_Credential_Earned_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public CIP_Code__Workday_Owned_ObjectType CIP_Code_Reference
		{
			get
			{
				return this.cIP_Code_ReferenceField;
			}
			set
			{
				this.cIP_Code_ReferenceField = value;
				this.RaisePropertyChanged("CIP_Code_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Student_External_Credential_Program_Description
		{
			get
			{
				return this.student_External_Credential_Program_DescriptionField;
			}
			set
			{
				this.student_External_Credential_Program_DescriptionField = value;
				this.RaisePropertyChanged("Student_External_Credential_Program_Description");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Student_External_Credential_Cumulative_GPA
		{
			get
			{
				return this.student_External_Credential_Cumulative_GPAField;
			}
			set
			{
				this.student_External_Credential_Cumulative_GPAField = value;
				this.RaisePropertyChanged("Student_External_Credential_Cumulative_GPA");
			}
		}

		[XmlIgnore]
		public bool Student_External_Credential_Cumulative_GPASpecified
		{
			get
			{
				return this.student_External_Credential_Cumulative_GPAFieldSpecified;
			}
			set
			{
				this.student_External_Credential_Cumulative_GPAFieldSpecified = value;
				this.RaisePropertyChanged("Student_External_Credential_Cumulative_GPASpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Student_External_Credential_Weighted_GPA
		{
			get
			{
				return this.student_External_Credential_Weighted_GPAField;
			}
			set
			{
				this.student_External_Credential_Weighted_GPAField = value;
				this.RaisePropertyChanged("Student_External_Credential_Weighted_GPA");
			}
		}

		[XmlIgnore]
		public bool Student_External_Credential_Weighted_GPASpecified
		{
			get
			{
				return this.student_External_Credential_Weighted_GPAFieldSpecified;
			}
			set
			{
				this.student_External_Credential_Weighted_GPAFieldSpecified = value;
				this.RaisePropertyChanged("Student_External_Credential_Weighted_GPASpecified");
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
