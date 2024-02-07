using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Applicant_Data_WWSType : INotifyPropertyChanged
	{
		private string applicant_IDField;

		private Personal_Information_DataType personal_DataField;

		private Person_Qualification_DataType qualification_DataField;

		private Recruiting_DataType recruiting_DataField;

		private Applicant_Resume_Detail_DataType[] resume_DataField;

		private Background_Check_Overall_Status_DataType[] background_Check_DataField;

		private IDType[] external_Integration_ID_DataField;

		private Document_Field_Result_DataType[] document_Field_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Applicant_ID
		{
			get
			{
				return this.applicant_IDField;
			}
			set
			{
				this.applicant_IDField = value;
				this.RaisePropertyChanged("Applicant_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Personal_Information_DataType Personal_Data
		{
			get
			{
				return this.personal_DataField;
			}
			set
			{
				this.personal_DataField = value;
				this.RaisePropertyChanged("Personal_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Person_Qualification_DataType Qualification_Data
		{
			get
			{
				return this.qualification_DataField;
			}
			set
			{
				this.qualification_DataField = value;
				this.RaisePropertyChanged("Qualification_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Recruiting_DataType Recruiting_Data
		{
			get
			{
				return this.recruiting_DataField;
			}
			set
			{
				this.recruiting_DataField = value;
				this.RaisePropertyChanged("Recruiting_Data");
			}
		}

		[XmlArray(Order = 4), XmlArrayItem("Resume", IsNullable = false)]
		public Applicant_Resume_Detail_DataType[] Resume_Data
		{
			get
			{
				return this.resume_DataField;
			}
			set
			{
				this.resume_DataField = value;
				this.RaisePropertyChanged("Resume_Data");
			}
		}

		[XmlElement("Background_Check_Data", Order = 5)]
		public Background_Check_Overall_Status_DataType[] Background_Check_Data
		{
			get
			{
				return this.background_Check_DataField;
			}
			set
			{
				this.background_Check_DataField = value;
				this.RaisePropertyChanged("Background_Check_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_Integration_ID_Data
		{
			get
			{
				return this.external_Integration_ID_DataField;
			}
			set
			{
				this.external_Integration_ID_DataField = value;
				this.RaisePropertyChanged("External_Integration_ID_Data");
			}
		}

		[XmlElement("Document_Field_Result_Data", Order = 7)]
		public Document_Field_Result_DataType[] Document_Field_Result_Data
		{
			get
			{
				return this.document_Field_Result_DataField;
			}
			set
			{
				this.document_Field_Result_DataField = value;
				this.RaisePropertyChanged("Document_Field_Result_Data");
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
