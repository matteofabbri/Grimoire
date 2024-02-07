using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Has_Billable_Load_Status_DataType : INotifyPropertyChanged
	{
		private decimal minimum_UnitsField;

		private bool minimum_UnitsFieldSpecified;

		private decimal maximum_UnitsField;

		private bool maximum_UnitsFieldSpecified;

		private decimal contact_HoursField;

		private bool contact_HoursFieldSpecified;

		private bool other_Credit_ValuesField;

		private bool other_Credit_ValuesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Minimum_Units
		{
			get
			{
				return this.minimum_UnitsField;
			}
			set
			{
				this.minimum_UnitsField = value;
				this.RaisePropertyChanged("Minimum_Units");
			}
		}

		[XmlIgnore]
		public bool Minimum_UnitsSpecified
		{
			get
			{
				return this.minimum_UnitsFieldSpecified;
			}
			set
			{
				this.minimum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Maximum_Units
		{
			get
			{
				return this.maximum_UnitsField;
			}
			set
			{
				this.maximum_UnitsField = value;
				this.RaisePropertyChanged("Maximum_Units");
			}
		}

		[XmlIgnore]
		public bool Maximum_UnitsSpecified
		{
			get
			{
				return this.maximum_UnitsFieldSpecified;
			}
			set
			{
				this.maximum_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Contact_Hours
		{
			get
			{
				return this.contact_HoursField;
			}
			set
			{
				this.contact_HoursField = value;
				this.RaisePropertyChanged("Contact_Hours");
			}
		}

		[XmlIgnore]
		public bool Contact_HoursSpecified
		{
			get
			{
				return this.contact_HoursFieldSpecified;
			}
			set
			{
				this.contact_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Contact_HoursSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Other_Credit_Values
		{
			get
			{
				return this.other_Credit_ValuesField;
			}
			set
			{
				this.other_Credit_ValuesField = value;
				this.RaisePropertyChanged("Other_Credit_Values");
			}
		}

		[XmlIgnore]
		public bool Other_Credit_ValuesSpecified
		{
			get
			{
				return this.other_Credit_ValuesFieldSpecified;
			}
			set
			{
				this.other_Credit_ValuesFieldSpecified = value;
				this.RaisePropertyChanged("Other_Credit_ValuesSpecified");
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
