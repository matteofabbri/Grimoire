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
	public class Student_External_Transcript_Student_Prospect_Person_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Legal_Name_DataType[] legal_Name_DataField;

		private Contact_Information_DataType[] contact_Information_DataField;

		private Student_Personal_Profile_DataType[] student_Prospect_Personal_Profile_DataField;

		private Person_Identification_DataType[] person_Identification_DataField;

		private Self_Identification_DataType[] self_Identification_DataField;

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

		[XmlElement("Legal_Name_Data", Order = 1)]
		public Legal_Name_DataType[] Legal_Name_Data
		{
			get
			{
				return this.legal_Name_DataField;
			}
			set
			{
				this.legal_Name_DataField = value;
				this.RaisePropertyChanged("Legal_Name_Data");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 2)]
		public Contact_Information_DataType[] Contact_Information_Data
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

		[XmlElement("Student_Prospect_Personal_Profile_Data", Order = 3)]
		public Student_Personal_Profile_DataType[] Student_Prospect_Personal_Profile_Data
		{
			get
			{
				return this.student_Prospect_Personal_Profile_DataField;
			}
			set
			{
				this.student_Prospect_Personal_Profile_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Personal_Profile_Data");
			}
		}

		[XmlElement("Person_Identification_Data", Order = 4)]
		public Person_Identification_DataType[] Person_Identification_Data
		{
			get
			{
				return this.person_Identification_DataField;
			}
			set
			{
				this.person_Identification_DataField = value;
				this.RaisePropertyChanged("Person_Identification_Data");
			}
		}

		[XmlElement("Self_Identification_Data", Order = 5)]
		public Self_Identification_DataType[] Self_Identification_Data
		{
			get
			{
				return this.self_Identification_DataField;
			}
			set
			{
				this.self_Identification_DataField = value;
				this.RaisePropertyChanged("Self_Identification_Data");
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
