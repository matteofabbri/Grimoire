using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class XMLNAME_1099_Electronic_Filing_Run_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType electronic_Filing_1099_Run_ReferenceField;

		private DateTime calendar_YearField;

		private bool calendar_YearFieldSpecified;

		private XMLNAME_1099_Company_DataType[] transmitter_Company_DataField;

		private bool iRS_1099_Electronic_Filing_Run_CorrectionField;

		private bool iRS_1099_Electronic_Filing_Run_CorrectionFieldSpecified;

		private bool test_file_for_1099_Electronic_Filing_RunField;

		private bool test_file_for_1099_Electronic_Filing_RunFieldSpecified;

		private bool iRS_1099_Electronic_Filing_ReplacementField;

		private bool iRS_1099_Electronic_Filing_ReplacementFieldSpecified;

		private Person_DataType person_DataField;

		private decimal count_of_PayorsField;

		private bool count_of_PayorsFieldSpecified;

		private decimal count_of_1099_Miscs_for_1099_Electronic_Filing_RunField;

		private bool count_of_1099_Miscs_for_1099_Electronic_Filing_RunFieldSpecified;

		private XMLNAME_1099_Run_DataType[] iRS_1099_Run_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Electronic_Filing_1099_Run_Reference
		{
			get
			{
				return this.electronic_Filing_1099_Run_ReferenceField;
			}
			set
			{
				this.electronic_Filing_1099_Run_ReferenceField = value;
				this.RaisePropertyChanged("Electronic_Filing_1099_Run_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Calendar_Year
		{
			get
			{
				return this.calendar_YearField;
			}
			set
			{
				this.calendar_YearField = value;
				this.RaisePropertyChanged("Calendar_Year");
			}
		}

		[XmlIgnore]
		public bool Calendar_YearSpecified
		{
			get
			{
				return this.calendar_YearFieldSpecified;
			}
			set
			{
				this.calendar_YearFieldSpecified = value;
				this.RaisePropertyChanged("Calendar_YearSpecified");
			}
		}

		[XmlElement("Transmitter_Company_Data", Order = 2)]
		public XMLNAME_1099_Company_DataType[] Transmitter_Company_Data
		{
			get
			{
				return this.transmitter_Company_DataField;
			}
			set
			{
				this.transmitter_Company_DataField = value;
				this.RaisePropertyChanged("Transmitter_Company_Data");
			}
		}

		[XmlElement(Order = 3)]
		public bool IRS_1099_Electronic_Filing_Run_Correction
		{
			get
			{
				return this.iRS_1099_Electronic_Filing_Run_CorrectionField;
			}
			set
			{
				this.iRS_1099_Electronic_Filing_Run_CorrectionField = value;
				this.RaisePropertyChanged("IRS_1099_Electronic_Filing_Run_Correction");
			}
		}

		[XmlIgnore]
		public bool IRS_1099_Electronic_Filing_Run_CorrectionSpecified
		{
			get
			{
				return this.iRS_1099_Electronic_Filing_Run_CorrectionFieldSpecified;
			}
			set
			{
				this.iRS_1099_Electronic_Filing_Run_CorrectionFieldSpecified = value;
				this.RaisePropertyChanged("IRS_1099_Electronic_Filing_Run_CorrectionSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Test_file_for_1099_Electronic_Filing_Run
		{
			get
			{
				return this.test_file_for_1099_Electronic_Filing_RunField;
			}
			set
			{
				this.test_file_for_1099_Electronic_Filing_RunField = value;
				this.RaisePropertyChanged("Test_file_for_1099_Electronic_Filing_Run");
			}
		}

		[XmlIgnore]
		public bool Test_file_for_1099_Electronic_Filing_RunSpecified
		{
			get
			{
				return this.test_file_for_1099_Electronic_Filing_RunFieldSpecified;
			}
			set
			{
				this.test_file_for_1099_Electronic_Filing_RunFieldSpecified = value;
				this.RaisePropertyChanged("Test_file_for_1099_Electronic_Filing_RunSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool IRS_1099_Electronic_Filing_Replacement
		{
			get
			{
				return this.iRS_1099_Electronic_Filing_ReplacementField;
			}
			set
			{
				this.iRS_1099_Electronic_Filing_ReplacementField = value;
				this.RaisePropertyChanged("IRS_1099_Electronic_Filing_Replacement");
			}
		}

		[XmlIgnore]
		public bool IRS_1099_Electronic_Filing_ReplacementSpecified
		{
			get
			{
				return this.iRS_1099_Electronic_Filing_ReplacementFieldSpecified;
			}
			set
			{
				this.iRS_1099_Electronic_Filing_ReplacementFieldSpecified = value;
				this.RaisePropertyChanged("IRS_1099_Electronic_Filing_ReplacementSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Person_DataType Person_Data
		{
			get
			{
				return this.person_DataField;
			}
			set
			{
				this.person_DataField = value;
				this.RaisePropertyChanged("Person_Data");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Count_of_Payors
		{
			get
			{
				return this.count_of_PayorsField;
			}
			set
			{
				this.count_of_PayorsField = value;
				this.RaisePropertyChanged("Count_of_Payors");
			}
		}

		[XmlIgnore]
		public bool Count_of_PayorsSpecified
		{
			get
			{
				return this.count_of_PayorsFieldSpecified;
			}
			set
			{
				this.count_of_PayorsFieldSpecified = value;
				this.RaisePropertyChanged("Count_of_PayorsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Count_of_1099_Miscs_for_1099_Electronic_Filing_Run
		{
			get
			{
				return this.count_of_1099_Miscs_for_1099_Electronic_Filing_RunField;
			}
			set
			{
				this.count_of_1099_Miscs_for_1099_Electronic_Filing_RunField = value;
				this.RaisePropertyChanged("Count_of_1099_Miscs_for_1099_Electronic_Filing_Run");
			}
		}

		[XmlIgnore]
		public bool Count_of_1099_Miscs_for_1099_Electronic_Filing_RunSpecified
		{
			get
			{
				return this.count_of_1099_Miscs_for_1099_Electronic_Filing_RunFieldSpecified;
			}
			set
			{
				this.count_of_1099_Miscs_for_1099_Electronic_Filing_RunFieldSpecified = value;
				this.RaisePropertyChanged("Count_of_1099_Miscs_for_1099_Electronic_Filing_RunSpecified");
			}
		}

		[XmlElement("IRS_1099_Run_Data", Order = 9)]
		public XMLNAME_1099_Run_DataType[] IRS_1099_Run_Data
		{
			get
			{
				return this.iRS_1099_Run_DataField;
			}
			set
			{
				this.iRS_1099_Run_DataField = value;
				this.RaisePropertyChanged("IRS_1099_Run_Data");
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
