using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Participation_Rate_Table_Entry_Request_DataType : INotifyPropertyChanged
	{
		private Management_LevelObjectType[] management_Level_ReferenceField;

		private Job_ProfileObjectType[] job_Profile_ReferenceField;

		private CountryObjectType[] country_ReferenceField;

		private Compensation_GradeObjectType[] compensation_Grade_ReferenceField;

		private string entry_Sort_OrderField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private decimal percentage_RateField;

		private bool percentage_RateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Management_Level_Reference", Order = 0)]
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

		[XmlElement("Job_Profile_Reference", Order = 1)]
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

		[XmlElement("Country_Reference", Order = 2)]
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

		[XmlElement("Compensation_Grade_Reference", Order = 3)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
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
