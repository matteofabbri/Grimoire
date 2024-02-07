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
	public class Student_Application_Recommender_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_Application_RecommenderObjectType student_Application_Recommender_ReferenceField;

		private string recommender_NameField;

		private Association_to_ApplicantObjectType association_to_Applicant_ReferenceField;

		private Contact_Information_DataType[] contact_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Application_RecommenderObjectType Student_Application_Recommender_Reference
		{
			get
			{
				return this.student_Application_Recommender_ReferenceField;
			}
			set
			{
				this.student_Application_Recommender_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Recommender_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Recommender_Name
		{
			get
			{
				return this.recommender_NameField;
			}
			set
			{
				this.recommender_NameField = value;
				this.RaisePropertyChanged("Recommender_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Association_to_ApplicantObjectType Association_to_Applicant_Reference
		{
			get
			{
				return this.association_to_Applicant_ReferenceField;
			}
			set
			{
				this.association_to_Applicant_ReferenceField = value;
				this.RaisePropertyChanged("Association_to_Applicant_Reference");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 3)]
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
