using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Award_Bonus_DataType : INotifyPropertyChanged
	{
		private Bonus_PlanObjectType bonus_Plan_ReferenceField;

		private decimal bonus_PercentField;

		private bool bonus_PercentFieldSpecified;

		private decimal bonus_AmountField;

		private bool bonus_AmountFieldSpecified;

		private decimal bonus_Factor_PercentField;

		private bool bonus_Factor_PercentFieldSpecified;

		private string bonus_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bonus_PlanObjectType Bonus_Plan_Reference
		{
			get
			{
				return this.bonus_Plan_ReferenceField;
			}
			set
			{
				this.bonus_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Bonus_Percent
		{
			get
			{
				return this.bonus_PercentField;
			}
			set
			{
				this.bonus_PercentField = value;
				this.RaisePropertyChanged("Bonus_Percent");
			}
		}

		[XmlIgnore]
		public bool Bonus_PercentSpecified
		{
			get
			{
				return this.bonus_PercentFieldSpecified;
			}
			set
			{
				this.bonus_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Bonus_Amount
		{
			get
			{
				return this.bonus_AmountField;
			}
			set
			{
				this.bonus_AmountField = value;
				this.RaisePropertyChanged("Bonus_Amount");
			}
		}

		[XmlIgnore]
		public bool Bonus_AmountSpecified
		{
			get
			{
				return this.bonus_AmountFieldSpecified;
			}
			set
			{
				this.bonus_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Bonus_Factor_Percent
		{
			get
			{
				return this.bonus_Factor_PercentField;
			}
			set
			{
				this.bonus_Factor_PercentField = value;
				this.RaisePropertyChanged("Bonus_Factor_Percent");
			}
		}

		[XmlIgnore]
		public bool Bonus_Factor_PercentSpecified
		{
			get
			{
				return this.bonus_Factor_PercentFieldSpecified;
			}
			set
			{
				this.bonus_Factor_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Factor_PercentSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Bonus_Notes
		{
			get
			{
				return this.bonus_NotesField;
			}
			set
			{
				this.bonus_NotesField = value;
				this.RaisePropertyChanged("Bonus_Notes");
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
