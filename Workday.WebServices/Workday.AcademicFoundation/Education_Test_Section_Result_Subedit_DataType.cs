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
	public class Education_Test_Section_Result_Subedit_DataType : INotifyPropertyChanged
	{
		private Education_Test_Section_ResultObjectType test_Section_Result_ReferenceField;

		private Education_Test_Section__All_ObjectType test_Section_ReferenceField;

		private DateTime year_TakenField;

		private bool year_TakenFieldSpecified;

		private decimal scoreField;

		private bool scoreFieldSpecified;

		private Education_Test_Section_NonNumeric_Value__Metadata_ObjectType education_Test_Section_Non_Numeric_Value_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Education_Test_Section_ResultObjectType Test_Section_Result_Reference
		{
			get
			{
				return this.test_Section_Result_ReferenceField;
			}
			set
			{
				this.test_Section_Result_ReferenceField = value;
				this.RaisePropertyChanged("Test_Section_Result_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Education_Test_Section__All_ObjectType Test_Section_Reference
		{
			get
			{
				return this.test_Section_ReferenceField;
			}
			set
			{
				this.test_Section_ReferenceField = value;
				this.RaisePropertyChanged("Test_Section_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Year_Taken
		{
			get
			{
				return this.year_TakenField;
			}
			set
			{
				this.year_TakenField = value;
				this.RaisePropertyChanged("Year_Taken");
			}
		}

		[XmlIgnore]
		public bool Year_TakenSpecified
		{
			get
			{
				return this.year_TakenFieldSpecified;
			}
			set
			{
				this.year_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Year_TakenSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Score
		{
			get
			{
				return this.scoreField;
			}
			set
			{
				this.scoreField = value;
				this.RaisePropertyChanged("Score");
			}
		}

		[XmlIgnore]
		public bool ScoreSpecified
		{
			get
			{
				return this.scoreFieldSpecified;
			}
			set
			{
				this.scoreFieldSpecified = value;
				this.RaisePropertyChanged("ScoreSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Education_Test_Section_NonNumeric_Value__Metadata_ObjectType Education_Test_Section_Non_Numeric_Value_Reference
		{
			get
			{
				return this.education_Test_Section_Non_Numeric_Value_ReferenceField;
			}
			set
			{
				this.education_Test_Section_Non_Numeric_Value_ReferenceField = value;
				this.RaisePropertyChanged("Education_Test_Section_Non_Numeric_Value_Reference");
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
