using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Participation_Rate_Table_Entry_DataType : INotifyPropertyChanged
	{
		private string entry_Sort_OrderField;

		private Management_LevelObjectType[] management_Level_ReferenceField;

		private Job_ProfileObjectType[] job_Profile_ReferenceField;

		private CountryObjectType[] country_ReferenceField;

		private Compensation_GradeObjectType[] compensation_Grade_ReferenceField;

		private decimal percentage_RateField;

		private bool percentage_RateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Entry_Sort_Order
		{
			get
			{
				return this.entry_Sort_OrderField;
			}
			set
			{
				this.entry_Sort_OrderField = value;
				this.RaisePropertyChanged("Entry_Sort_Order");
			}
		}

		[XmlElement("Management_Level_Reference", Order = 1)]
		public Management_LevelObjectType[] Management_Level_Reference
		{
			get
			{
				return this.management_Level_ReferenceField;
			}
			set
			{
				this.management_Level_ReferenceField = value;
				this.RaisePropertyChanged("Management_Level_Reference");
			}
		}

		[XmlElement("Job_Profile_Reference", Order = 2)]
		public Job_ProfileObjectType[] Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement("Country_Reference", Order = 3)]
		public CountryObjectType[] Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Compensation_Grade_Reference", Order = 4)]
		public Compensation_GradeObjectType[] Compensation_Grade_Reference
		{
			get
			{
				return this.compensation_Grade_ReferenceField;
			}
			set
			{
				this.compensation_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Grade_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Percentage_Rate
		{
			get
			{
				return this.percentage_RateField;
			}
			set
			{
				this.percentage_RateField = value;
				this.RaisePropertyChanged("Percentage_Rate");
			}
		}

		[XmlIgnore]
		public bool Percentage_RateSpecified
		{
			get
			{
				return this.percentage_RateFieldSpecified;
			}
			set
			{
				this.percentage_RateFieldSpecified = value;
				this.RaisePropertyChanged("Percentage_RateSpecified");
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
