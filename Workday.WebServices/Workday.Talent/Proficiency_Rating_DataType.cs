using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proficiency_Rating_DataType : INotifyPropertyChanged
	{
		private Proficiency_RatingObjectType proficiency_Rating_ReferenceField;

		private string proficiency_Rating_IDField;

		private string rating_OrderField;

		private string ratingField;

		private bool exclude_From_CalculationsField;

		private bool exclude_From_CalculationsFieldSpecified;

		private decimal rating_ValueField;

		private bool rating_ValueFieldSpecified;

		private decimal range_BeginField;

		private bool range_BeginFieldSpecified;

		private decimal range_EndField;

		private bool range_EndFieldSpecified;

		private Proficiency_Rating_Behavior_DataType proficiency_Rating_Behavior_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Proficiency_RatingObjectType Proficiency_Rating_Reference
		{
			get
			{
				return this.proficiency_Rating_ReferenceField;
			}
			set
			{
				this.proficiency_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Proficiency_Rating_ID
		{
			get
			{
				return this.proficiency_Rating_IDField;
			}
			set
			{
				this.proficiency_Rating_IDField = value;
				this.RaisePropertyChanged("Proficiency_Rating_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Rating_Order
		{
			get
			{
				return this.rating_OrderField;
			}
			set
			{
				this.rating_OrderField = value;
				this.RaisePropertyChanged("Rating_Order");
			}
		}

		[XmlElement(Order = 3)]
		public string Rating
		{
			get
			{
				return this.ratingField;
			}
			set
			{
				this.ratingField = value;
				this.RaisePropertyChanged("Rating");
			}
		}

		[XmlElement(Order = 4)]
		public bool Exclude_From_Calculations
		{
			get
			{
				return this.exclude_From_CalculationsField;
			}
			set
			{
				this.exclude_From_CalculationsField = value;
				this.RaisePropertyChanged("Exclude_From_Calculations");
			}
		}

		[XmlIgnore]
		public bool Exclude_From_CalculationsSpecified
		{
			get
			{
				return this.exclude_From_CalculationsFieldSpecified;
			}
			set
			{
				this.exclude_From_CalculationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_From_CalculationsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Rating_Value
		{
			get
			{
				return this.rating_ValueField;
			}
			set
			{
				this.rating_ValueField = value;
				this.RaisePropertyChanged("Rating_Value");
			}
		}

		[XmlIgnore]
		public bool Rating_ValueSpecified
		{
			get
			{
				return this.rating_ValueFieldSpecified;
			}
			set
			{
				this.rating_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Rating_ValueSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Range_Begin
		{
			get
			{
				return this.range_BeginField;
			}
			set
			{
				this.range_BeginField = value;
				this.RaisePropertyChanged("Range_Begin");
			}
		}

		[XmlIgnore]
		public bool Range_BeginSpecified
		{
			get
			{
				return this.range_BeginFieldSpecified;
			}
			set
			{
				this.range_BeginFieldSpecified = value;
				this.RaisePropertyChanged("Range_BeginSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Range_End
		{
			get
			{
				return this.range_EndField;
			}
			set
			{
				this.range_EndField = value;
				this.RaisePropertyChanged("Range_End");
			}
		}

		[XmlIgnore]
		public bool Range_EndSpecified
		{
			get
			{
				return this.range_EndFieldSpecified;
			}
			set
			{
				this.range_EndFieldSpecified = value;
				this.RaisePropertyChanged("Range_EndSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Proficiency_Rating_Behavior_DataType Proficiency_Rating_Behavior_Data
		{
			get
			{
				return this.proficiency_Rating_Behavior_DataField;
			}
			set
			{
				this.proficiency_Rating_Behavior_DataField = value;
				this.RaisePropertyChanged("Proficiency_Rating_Behavior_Data");
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
