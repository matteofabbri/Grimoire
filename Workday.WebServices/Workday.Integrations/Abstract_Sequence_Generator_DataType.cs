using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Workday.Integrations;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Abstract_Sequence_Generator_DataType : INotifyPropertyChanged
	{
		private string sequence_IDField;

		private string sequence_NameField;

		private decimal start_NumberField;

		private bool start_NumberFieldSpecified;

		private decimal increment_ByField;

		private Date_IntervalObjectType restart_Date_Interval_ReferenceField;

		private Time_ZoneObjectType use_Time_Zone_ReferenceField;

		private decimal last_Number_UsedField;

		private bool last_Number_UsedFieldSpecified;

		private DateTime last_DateTime_UsedField;

		private bool last_DateTime_UsedFieldSpecified;

		private decimal padding_With_ZeroField;

		private bool padding_With_ZeroFieldSpecified;

		private string formatField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Sequence_ID
		{
			get
			{
				return this.sequence_IDField;
			}
			set
			{
				this.sequence_IDField = value;
				this.RaisePropertyChanged("Sequence_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sequence_Name
		{
			get
			{
				return this.sequence_NameField;
			}
			set
			{
				this.sequence_NameField = value;
				this.RaisePropertyChanged("Sequence_Name");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Start_Number
		{
			get
			{
				return this.start_NumberField;
			}
			set
			{
				this.start_NumberField = value;
				this.RaisePropertyChanged("Start_Number");
			}
		}

		[XmlIgnore]
		public bool Start_NumberSpecified
		{
			get
			{
				return this.start_NumberFieldSpecified;
			}
			set
			{
				this.start_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Start_NumberSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Increment_By
		{
			get
			{
				return this.increment_ByField;
			}
			set
			{
				this.increment_ByField = value;
				this.RaisePropertyChanged("Increment_By");
			}
		}

		[XmlElement(Order = 4)]
		public Date_IntervalObjectType Restart_Date_Interval_Reference
		{
			get
			{
				return this.restart_Date_Interval_ReferenceField;
			}
			set
			{
				this.restart_Date_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Restart_Date_Interval_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Time_ZoneObjectType Use_Time_Zone_Reference
		{
			get
			{
				return this.use_Time_Zone_ReferenceField;
			}
			set
			{
				this.use_Time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Use_Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Last_Number_Used
		{
			get
			{
				return this.last_Number_UsedField;
			}
			set
			{
				this.last_Number_UsedField = value;
				this.RaisePropertyChanged("Last_Number_Used");
			}
		}

		[XmlIgnore]
		public bool Last_Number_UsedSpecified
		{
			get
			{
				return this.last_Number_UsedFieldSpecified;
			}
			set
			{
				this.last_Number_UsedFieldSpecified = value;
				this.RaisePropertyChanged("Last_Number_UsedSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Last_DateTime_Used
		{
			get
			{
				return this.last_DateTime_UsedField;
			}
			set
			{
				this.last_DateTime_UsedField = value;
				this.RaisePropertyChanged("Last_DateTime_Used");
			}
		}

		[XmlIgnore]
		public bool Last_DateTime_UsedSpecified
		{
			get
			{
				return this.last_DateTime_UsedFieldSpecified;
			}
			set
			{
				this.last_DateTime_UsedFieldSpecified = value;
				this.RaisePropertyChanged("Last_DateTime_UsedSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Padding_With_Zero
		{
			get
			{
				return this.padding_With_ZeroField;
			}
			set
			{
				this.padding_With_ZeroField = value;
				this.RaisePropertyChanged("Padding_With_Zero");
			}
		}

		[XmlIgnore]
		public bool Padding_With_ZeroSpecified
		{
			get
			{
				return this.padding_With_ZeroFieldSpecified;
			}
			set
			{
				this.padding_With_ZeroFieldSpecified = value;
				this.RaisePropertyChanged("Padding_With_ZeroSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
				this.RaisePropertyChanged("Format");
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
