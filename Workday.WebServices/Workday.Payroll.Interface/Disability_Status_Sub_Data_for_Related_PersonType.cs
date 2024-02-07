using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Disability_Status_Sub_Data_for_Related_PersonType : INotifyPropertyChanged
	{
		private DisabilityObjectType disability_ReferenceField;

		private DateTime disability_Status_DateField;

		private bool disability_Status_DateFieldSpecified;

		private DateTime date_KnownField;

		private bool date_KnownFieldSpecified;

		private DateTime disability_End_DateField;

		private bool disability_End_DateFieldSpecified;

		private Disability_GradeObjectType disability_Grade_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DisabilityObjectType Disability_Reference
		{
			get
			{
				return this.disability_ReferenceField;
			}
			set
			{
				this.disability_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Disability_Status_Date
		{
			get
			{
				return this.disability_Status_DateField;
			}
			set
			{
				this.disability_Status_DateField = value;
				this.RaisePropertyChanged("Disability_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_Status_DateSpecified
		{
			get
			{
				return this.disability_Status_DateFieldSpecified;
			}
			set
			{
				this.disability_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_Status_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date_Known
		{
			get
			{
				return this.date_KnownField;
			}
			set
			{
				this.date_KnownField = value;
				this.RaisePropertyChanged("Date_Known");
			}
		}

		[XmlIgnore]
		public bool Date_KnownSpecified
		{
			get
			{
				return this.date_KnownFieldSpecified;
			}
			set
			{
				this.date_KnownFieldSpecified = value;
				this.RaisePropertyChanged("Date_KnownSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Disability_End_Date
		{
			get
			{
				return this.disability_End_DateField;
			}
			set
			{
				this.disability_End_DateField = value;
				this.RaisePropertyChanged("Disability_End_Date");
			}
		}

		[XmlIgnore]
		public bool Disability_End_DateSpecified
		{
			get
			{
				return this.disability_End_DateFieldSpecified;
			}
			set
			{
				this.disability_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Disability_End_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Disability_GradeObjectType Disability_Grade_Reference
		{
			get
			{
				return this.disability_Grade_ReferenceField;
			}
			set
			{
				this.disability_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Disability_Grade_Reference");
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
