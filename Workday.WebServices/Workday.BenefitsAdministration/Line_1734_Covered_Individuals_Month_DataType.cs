using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Line_17-34_Covered_Individuals_Month_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Line_1734_Covered_Individuals_Month_DataType : INotifyPropertyChanged
	{
		private string covered_Individual_ReferenceField;

		private string covered_Individual_First_NameField;

		private string covered_Individual_Middle_NameField;

		private string covered_Individual_Last_NameField;

		private string covered_Individual_Suffix_NameField;

		private string covered_Individual_SSN_or_ITINField;

		private DateTime covered_Individual_DOBField;

		private bool covered_Individual_DOBFieldSpecified;

		private bool all_12_MonthsField;

		private bool all_12_MonthsFieldSpecified;

		private bool janField;

		private bool janFieldSpecified;

		private bool febField;

		private bool febFieldSpecified;

		private bool marField;

		private bool marFieldSpecified;

		private bool aprField;

		private bool aprFieldSpecified;

		private bool mayField;

		private bool mayFieldSpecified;

		private bool junField;

		private bool junFieldSpecified;

		private bool julField;

		private bool julFieldSpecified;

		private bool augField;

		private bool augFieldSpecified;

		private bool sepField;

		private bool sepFieldSpecified;

		private bool octField;

		private bool octFieldSpecified;

		private bool novField;

		private bool novFieldSpecified;

		private bool decField;

		private bool decFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Covered_Individual_Reference
		{
			get
			{
				return this.covered_Individual_ReferenceField;
			}
			set
			{
				this.covered_Individual_ReferenceField = value;
				this.RaisePropertyChanged("Covered_Individual_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Covered_Individual_First_Name
		{
			get
			{
				return this.covered_Individual_First_NameField;
			}
			set
			{
				this.covered_Individual_First_NameField = value;
				this.RaisePropertyChanged("Covered_Individual_First_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Covered_Individual_Middle_Name
		{
			get
			{
				return this.covered_Individual_Middle_NameField;
			}
			set
			{
				this.covered_Individual_Middle_NameField = value;
				this.RaisePropertyChanged("Covered_Individual_Middle_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Covered_Individual_Last_Name
		{
			get
			{
				return this.covered_Individual_Last_NameField;
			}
			set
			{
				this.covered_Individual_Last_NameField = value;
				this.RaisePropertyChanged("Covered_Individual_Last_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Covered_Individual_Suffix_Name
		{
			get
			{
				return this.covered_Individual_Suffix_NameField;
			}
			set
			{
				this.covered_Individual_Suffix_NameField = value;
				this.RaisePropertyChanged("Covered_Individual_Suffix_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Covered_Individual_SSN_or_ITIN
		{
			get
			{
				return this.covered_Individual_SSN_or_ITINField;
			}
			set
			{
				this.covered_Individual_SSN_or_ITINField = value;
				this.RaisePropertyChanged("Covered_Individual_SSN_or_ITIN");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Covered_Individual_DOB
		{
			get
			{
				return this.covered_Individual_DOBField;
			}
			set
			{
				this.covered_Individual_DOBField = value;
				this.RaisePropertyChanged("Covered_Individual_DOB");
			}
		}

		[XmlIgnore]
		public bool Covered_Individual_DOBSpecified
		{
			get
			{
				return this.covered_Individual_DOBFieldSpecified;
			}
			set
			{
				this.covered_Individual_DOBFieldSpecified = value;
				this.RaisePropertyChanged("Covered_Individual_DOBSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool All_12_Months
		{
			get
			{
				return this.all_12_MonthsField;
			}
			set
			{
				this.all_12_MonthsField = value;
				this.RaisePropertyChanged("All_12_Months");
			}
		}

		[XmlIgnore]
		public bool All_12_MonthsSpecified
		{
			get
			{
				return this.all_12_MonthsFieldSpecified;
			}
			set
			{
				this.all_12_MonthsFieldSpecified = value;
				this.RaisePropertyChanged("All_12_MonthsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Jan
		{
			get
			{
				return this.janField;
			}
			set
			{
				this.janField = value;
				this.RaisePropertyChanged("Jan");
			}
		}

		[XmlIgnore]
		public bool JanSpecified
		{
			get
			{
				return this.janFieldSpecified;
			}
			set
			{
				this.janFieldSpecified = value;
				this.RaisePropertyChanged("JanSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Feb
		{
			get
			{
				return this.febField;
			}
			set
			{
				this.febField = value;
				this.RaisePropertyChanged("Feb");
			}
		}

		[XmlIgnore]
		public bool FebSpecified
		{
			get
			{
				return this.febFieldSpecified;
			}
			set
			{
				this.febFieldSpecified = value;
				this.RaisePropertyChanged("FebSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Mar
		{
			get
			{
				return this.marField;
			}
			set
			{
				this.marField = value;
				this.RaisePropertyChanged("Mar");
			}
		}

		[XmlIgnore]
		public bool MarSpecified
		{
			get
			{
				return this.marFieldSpecified;
			}
			set
			{
				this.marFieldSpecified = value;
				this.RaisePropertyChanged("MarSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Apr
		{
			get
			{
				return this.aprField;
			}
			set
			{
				this.aprField = value;
				this.RaisePropertyChanged("Apr");
			}
		}

		[XmlIgnore]
		public bool AprSpecified
		{
			get
			{
				return this.aprFieldSpecified;
			}
			set
			{
				this.aprFieldSpecified = value;
				this.RaisePropertyChanged("AprSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool May
		{
			get
			{
				return this.mayField;
			}
			set
			{
				this.mayField = value;
				this.RaisePropertyChanged("May");
			}
		}

		[XmlIgnore]
		public bool MaySpecified
		{
			get
			{
				return this.mayFieldSpecified;
			}
			set
			{
				this.mayFieldSpecified = value;
				this.RaisePropertyChanged("MaySpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Jun
		{
			get
			{
				return this.junField;
			}
			set
			{
				this.junField = value;
				this.RaisePropertyChanged("Jun");
			}
		}

		[XmlIgnore]
		public bool JunSpecified
		{
			get
			{
				return this.junFieldSpecified;
			}
			set
			{
				this.junFieldSpecified = value;
				this.RaisePropertyChanged("JunSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Jul
		{
			get
			{
				return this.julField;
			}
			set
			{
				this.julField = value;
				this.RaisePropertyChanged("Jul");
			}
		}

		[XmlIgnore]
		public bool JulSpecified
		{
			get
			{
				return this.julFieldSpecified;
			}
			set
			{
				this.julFieldSpecified = value;
				this.RaisePropertyChanged("JulSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Aug
		{
			get
			{
				return this.augField;
			}
			set
			{
				this.augField = value;
				this.RaisePropertyChanged("Aug");
			}
		}

		[XmlIgnore]
		public bool AugSpecified
		{
			get
			{
				return this.augFieldSpecified;
			}
			set
			{
				this.augFieldSpecified = value;
				this.RaisePropertyChanged("AugSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Sep
		{
			get
			{
				return this.sepField;
			}
			set
			{
				this.sepField = value;
				this.RaisePropertyChanged("Sep");
			}
		}

		[XmlIgnore]
		public bool SepSpecified
		{
			get
			{
				return this.sepFieldSpecified;
			}
			set
			{
				this.sepFieldSpecified = value;
				this.RaisePropertyChanged("SepSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Oct
		{
			get
			{
				return this.octField;
			}
			set
			{
				this.octField = value;
				this.RaisePropertyChanged("Oct");
			}
		}

		[XmlIgnore]
		public bool OctSpecified
		{
			get
			{
				return this.octFieldSpecified;
			}
			set
			{
				this.octFieldSpecified = value;
				this.RaisePropertyChanged("OctSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Nov
		{
			get
			{
				return this.novField;
			}
			set
			{
				this.novField = value;
				this.RaisePropertyChanged("Nov");
			}
		}

		[XmlIgnore]
		public bool NovSpecified
		{
			get
			{
				return this.novFieldSpecified;
			}
			set
			{
				this.novFieldSpecified = value;
				this.RaisePropertyChanged("NovSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Dec
		{
			get
			{
				return this.decField;
			}
			set
			{
				this.decField = value;
				this.RaisePropertyChanged("Dec");
			}
		}

		[XmlIgnore]
		public bool DecSpecified
		{
			get
			{
				return this.decFieldSpecified;
			}
			set
			{
				this.decFieldSpecified = value;
				this.RaisePropertyChanged("DecSpecified");
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
