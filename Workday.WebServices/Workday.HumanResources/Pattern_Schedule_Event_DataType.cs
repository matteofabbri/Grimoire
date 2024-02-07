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
	public class Pattern_Schedule_Event_DataType : INotifyPropertyChanged
	{
		private decimal week_NumberField;

		private Day_of_the_WeekObjectType[] day_of_the_Week_ReferenceField;

		private DateTime start_TimeField;

		private bool start_TimeFieldSpecified;

		private DateTime end_TimeField;

		private bool end_TimeFieldSpecified;

		private bool _24_Hour_ShiftField;

		private bool _24_Hour_ShiftFieldSpecified;

		private DateTime meal_StartField;

		private bool meal_StartFieldSpecified;

		private DateTime meal_EndField;

		private bool meal_EndFieldSpecified;

		private string idField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Week_Number
		{
			get
			{
				return this.week_NumberField;
			}
			set
			{
				this.week_NumberField = value;
				this.RaisePropertyChanged("Week_Number");
			}
		}

		[XmlElement("Day_of_the_Week_Reference", Order = 1)]
		public Day_of_the_WeekObjectType[] Day_of_the_Week_Reference
		{
			get
			{
				return this.day_of_the_Week_ReferenceField;
			}
			set
			{
				this.day_of_the_Week_ReferenceField = value;
				this.RaisePropertyChanged("Day_of_the_Week_Reference");
			}
		}

		[XmlElement(DataType = "time", Order = 2)]
		public DateTime Start_Time
		{
			get
			{
				return this.start_TimeField;
			}
			set
			{
				this.start_TimeField = value;
				this.RaisePropertyChanged("Start_Time");
			}
		}

		[XmlIgnore]
		public bool Start_TimeSpecified
		{
			get
			{
				return this.start_TimeFieldSpecified;
			}
			set
			{
				this.start_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Start_TimeSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 3)]
		public DateTime End_Time
		{
			get
			{
				return this.end_TimeField;
			}
			set
			{
				this.end_TimeField = value;
				this.RaisePropertyChanged("End_Time");
			}
		}

		[XmlIgnore]
		public bool End_TimeSpecified
		{
			get
			{
				return this.end_TimeFieldSpecified;
			}
			set
			{
				this.end_TimeFieldSpecified = value;
				this.RaisePropertyChanged("End_TimeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool _24_Hour_Shift
		{
			get
			{
				return this._24_Hour_ShiftField;
			}
			set
			{
				this._24_Hour_ShiftField = value;
				this.RaisePropertyChanged("_24_Hour_Shift");
			}
		}

		[XmlIgnore]
		public bool _24_Hour_ShiftSpecified
		{
			get
			{
				return this._24_Hour_ShiftFieldSpecified;
			}
			set
			{
				this._24_Hour_ShiftFieldSpecified = value;
				this.RaisePropertyChanged("_24_Hour_ShiftSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 5)]
		public DateTime Meal_Start
		{
			get
			{
				return this.meal_StartField;
			}
			set
			{
				this.meal_StartField = value;
				this.RaisePropertyChanged("Meal_Start");
			}
		}

		[XmlIgnore]
		public bool Meal_StartSpecified
		{
			get
			{
				return this.meal_StartFieldSpecified;
			}
			set
			{
				this.meal_StartFieldSpecified = value;
				this.RaisePropertyChanged("Meal_StartSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 6)]
		public DateTime Meal_End
		{
			get
			{
				return this.meal_EndField;
			}
			set
			{
				this.meal_EndField = value;
				this.RaisePropertyChanged("Meal_End");
			}
		}

		[XmlIgnore]
		public bool Meal_EndSpecified
		{
			get
			{
				return this.meal_EndFieldSpecified;
			}
			set
			{
				this.meal_EndFieldSpecified = value;
				this.RaisePropertyChanged("Meal_EndSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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
