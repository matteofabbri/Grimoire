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
	public class Educational_Institution_Accreditation_DataType : INotifyPropertyChanged
	{
		private Educational_Institution_AccreditationObjectType educational_Institution_Accreditation_ReferenceField;

		private DateTime accreditation_File_Creation_DateField;

		private bool accreditation_File_Creation_DateFieldSpecified;

		private Educational_Institution_Accreditation_AgencyObjectType accreditation_Agency_ReferenceField;

		private string accreditation_Program_NameField;

		private Educational_Institution_Accreditation_TypeObjectType accreditation_Type_ReferenceField;

		private Educational_Institution_Accreditation_StatusObjectType accreditation_Status_ReferenceField;

		private DateTime accreditation_Start_DateField;

		private bool accreditation_Start_DateFieldSpecified;

		private DateTime accreditation_End_DateField;

		private bool accreditation_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_Institution_AccreditationObjectType Educational_Institution_Accreditation_Reference
		{
			get
			{
				return this.educational_Institution_Accreditation_ReferenceField;
			}
			set
			{
				this.educational_Institution_Accreditation_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Accreditation_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Accreditation_File_Creation_Date
		{
			get
			{
				return this.accreditation_File_Creation_DateField;
			}
			set
			{
				this.accreditation_File_Creation_DateField = value;
				this.RaisePropertyChanged("Accreditation_File_Creation_Date");
			}
		}

		[XmlIgnore]
		public bool Accreditation_File_Creation_DateSpecified
		{
			get
			{
				return this.accreditation_File_Creation_DateFieldSpecified;
			}
			set
			{
				this.accreditation_File_Creation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accreditation_File_Creation_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Educational_Institution_Accreditation_AgencyObjectType Accreditation_Agency_Reference
		{
			get
			{
				return this.accreditation_Agency_ReferenceField;
			}
			set
			{
				this.accreditation_Agency_ReferenceField = value;
				this.RaisePropertyChanged("Accreditation_Agency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Accreditation_Program_Name
		{
			get
			{
				return this.accreditation_Program_NameField;
			}
			set
			{
				this.accreditation_Program_NameField = value;
				this.RaisePropertyChanged("Accreditation_Program_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Educational_Institution_Accreditation_TypeObjectType Accreditation_Type_Reference
		{
			get
			{
				return this.accreditation_Type_ReferenceField;
			}
			set
			{
				this.accreditation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Accreditation_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Educational_Institution_Accreditation_StatusObjectType Accreditation_Status_Reference
		{
			get
			{
				return this.accreditation_Status_ReferenceField;
			}
			set
			{
				this.accreditation_Status_ReferenceField = value;
				this.RaisePropertyChanged("Accreditation_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Accreditation_Start_Date
		{
			get
			{
				return this.accreditation_Start_DateField;
			}
			set
			{
				this.accreditation_Start_DateField = value;
				this.RaisePropertyChanged("Accreditation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Accreditation_Start_DateSpecified
		{
			get
			{
				return this.accreditation_Start_DateFieldSpecified;
			}
			set
			{
				this.accreditation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accreditation_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Accreditation_End_Date
		{
			get
			{
				return this.accreditation_End_DateField;
			}
			set
			{
				this.accreditation_End_DateField = value;
				this.RaisePropertyChanged("Accreditation_End_Date");
			}
		}

		[XmlIgnore]
		public bool Accreditation_End_DateSpecified
		{
			get
			{
				return this.accreditation_End_DateFieldSpecified;
			}
			set
			{
				this.accreditation_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accreditation_End_DateSpecified");
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
