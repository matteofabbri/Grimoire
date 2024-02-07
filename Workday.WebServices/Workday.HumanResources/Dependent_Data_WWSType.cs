using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dependent_Data_WWSType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private string dependent_Educational_InstitutionField;

		private bool fulltime_StudentField;

		private bool fulltime_StudentFieldSpecified;

		private DateTime student_Status_Start_DateField;

		private bool student_Status_Start_DateFieldSpecified;

		private DateTime student_Status_End_DateField;

		private bool student_Status_End_DateFieldSpecified;

		private DateTime dependent_Date_of_DeathField;

		private bool dependent_Date_of_DeathFieldSpecified;

		private bool disabledField;

		private bool disabledFieldSpecified;

		private Qualified_Domestic_Relations_Order_Replacement_DataType[] court_Order_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement(Order = 1)]
		public string Dependent_Educational_Institution
		{
			get
			{
				return this.dependent_Educational_InstitutionField;
			}
			set
			{
				this.dependent_Educational_InstitutionField = value;
				this.RaisePropertyChanged("Dependent_Educational_Institution");
			}
		}

		[XmlElement("Full-time_Student", Order = 2)]
		public bool Fulltime_Student
		{
			get
			{
				return this.fulltime_StudentField;
			}
			set
			{
				this.fulltime_StudentField = value;
				this.RaisePropertyChanged("Fulltime_Student");
			}
		}

		[XmlIgnore]
		public bool Fulltime_StudentSpecified
		{
			get
			{
				return this.fulltime_StudentFieldSpecified;
			}
			set
			{
				this.fulltime_StudentFieldSpecified = value;
				this.RaisePropertyChanged("Fulltime_StudentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Student_Status_Start_Date
		{
			get
			{
				return this.student_Status_Start_DateField;
			}
			set
			{
				this.student_Status_Start_DateField = value;
				this.RaisePropertyChanged("Student_Status_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Status_Start_DateSpecified
		{
			get
			{
				return this.student_Status_Start_DateFieldSpecified;
			}
			set
			{
				this.student_Status_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Status_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Student_Status_End_Date
		{
			get
			{
				return this.student_Status_End_DateField;
			}
			set
			{
				this.student_Status_End_DateField = value;
				this.RaisePropertyChanged("Student_Status_End_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Status_End_DateSpecified
		{
			get
			{
				return this.student_Status_End_DateFieldSpecified;
			}
			set
			{
				this.student_Status_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Status_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Dependent_Date_of_Death
		{
			get
			{
				return this.dependent_Date_of_DeathField;
			}
			set
			{
				this.dependent_Date_of_DeathField = value;
				this.RaisePropertyChanged("Dependent_Date_of_Death");
			}
		}

		[XmlIgnore]
		public bool Dependent_Date_of_DeathSpecified
		{
			get
			{
				return this.dependent_Date_of_DeathFieldSpecified;
			}
			set
			{
				this.dependent_Date_of_DeathFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_Date_of_DeathSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Disabled
		{
			get
			{
				return this.disabledField;
			}
			set
			{
				this.disabledField = value;
				this.RaisePropertyChanged("Disabled");
			}
		}

		[XmlIgnore]
		public bool DisabledSpecified
		{
			get
			{
				return this.disabledFieldSpecified;
			}
			set
			{
				this.disabledFieldSpecified = value;
				this.RaisePropertyChanged("DisabledSpecified");
			}
		}

		[XmlElement("Court_Order_Replacement_Data", Order = 7)]
		public Qualified_Domestic_Relations_Order_Replacement_DataType[] Court_Order_Replacement_Data
		{
			get
			{
				return this.court_Order_Replacement_DataField;
			}
			set
			{
				this.court_Order_Replacement_DataField = value;
				this.RaisePropertyChanged("Court_Order_Replacement_Data");
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
