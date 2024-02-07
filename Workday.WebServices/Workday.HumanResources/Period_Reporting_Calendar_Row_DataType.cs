using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Reporting_Calendar_Row_DataType : INotifyPropertyChanged
	{
		private Period_Reporting_Calendar_RowObjectType period_Reporting_Calendar_Row_ReferenceField;

		private string orderField;

		private string calendar_Period_NameField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private Evaluation_ConstraintObjectType evaluation_Constraint_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Reporting_Calendar_RowObjectType Period_Reporting_Calendar_Row_Reference
		{
			get
			{
				return this.period_Reporting_Calendar_Row_ReferenceField;
			}
			set
			{
				this.period_Reporting_Calendar_Row_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reporting_Calendar_Row_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 2)]
		public string Calendar_Period_Name
		{
			get
			{
				return this.calendar_Period_NameField;
			}
			set
			{
				this.calendar_Period_NameField = value;
				this.RaisePropertyChanged("Calendar_Period_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlElement(Order = 6)]
		public Evaluation_ConstraintObjectType Evaluation_Constraint_Reference
		{
			get
			{
				return this.evaluation_Constraint_ReferenceField;
			}
			set
			{
				this.evaluation_Constraint_ReferenceField = value;
				this.RaisePropertyChanged("Evaluation_Constraint_Reference");
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
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
