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
	public class Candidate_Experience_DataType : INotifyPropertyChanged
	{
		private Job_History_CompanyObjectType company_ReferenceField;

		private string company_NameField;

		private string titleField;

		private string locationField;

		private decimal start_MonthField;

		private bool start_MonthFieldSpecified;

		private decimal start_YearField;

		private decimal end_MonthField;

		private bool end_MonthFieldSpecified;

		private decimal end_YearField;

		private bool end_YearFieldSpecified;

		private bool currently_Work_HereField;

		private bool currently_Work_HereFieldSpecified;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_History_CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Company_Name
		{
			get
			{
				return this.company_NameField;
			}
			set
			{
				this.company_NameField = value;
				this.RaisePropertyChanged("Company_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(Order = 3)]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				this.RaisePropertyChanged("Location");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Start_Month
		{
			get
			{
				return this.start_MonthField;
			}
			set
			{
				this.start_MonthField = value;
				this.RaisePropertyChanged("Start_Month");
			}
		}

		[XmlIgnore]
		public bool Start_MonthSpecified
		{
			get
			{
				return this.start_MonthFieldSpecified;
			}
			set
			{
				this.start_MonthFieldSpecified = value;
				this.RaisePropertyChanged("Start_MonthSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Start_Year
		{
			get
			{
				return this.start_YearField;
			}
			set
			{
				this.start_YearField = value;
				this.RaisePropertyChanged("Start_Year");
			}
		}

		[XmlElement(Order = 6)]
		public decimal End_Month
		{
			get
			{
				return this.end_MonthField;
			}
			set
			{
				this.end_MonthField = value;
				this.RaisePropertyChanged("End_Month");
			}
		}

		[XmlIgnore]
		public bool End_MonthSpecified
		{
			get
			{
				return this.end_MonthFieldSpecified;
			}
			set
			{
				this.end_MonthFieldSpecified = value;
				this.RaisePropertyChanged("End_MonthSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal End_Year
		{
			get
			{
				return this.end_YearField;
			}
			set
			{
				this.end_YearField = value;
				this.RaisePropertyChanged("End_Year");
			}
		}

		[XmlIgnore]
		public bool End_YearSpecified
		{
			get
			{
				return this.end_YearFieldSpecified;
			}
			set
			{
				this.end_YearFieldSpecified = value;
				this.RaisePropertyChanged("End_YearSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Currently_Work_Here
		{
			get
			{
				return this.currently_Work_HereField;
			}
			set
			{
				this.currently_Work_HereField = value;
				this.RaisePropertyChanged("Currently_Work_Here");
			}
		}

		[XmlIgnore]
		public bool Currently_Work_HereSpecified
		{
			get
			{
				return this.currently_Work_HereFieldSpecified;
			}
			set
			{
				this.currently_Work_HereFieldSpecified = value;
				this.RaisePropertyChanged("Currently_Work_HereSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
