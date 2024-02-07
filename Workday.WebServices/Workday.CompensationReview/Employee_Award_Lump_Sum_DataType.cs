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
	public class Employee_Award_Lump_Sum_DataType : INotifyPropertyChanged
	{
		private decimal lump_Sum_PercentField;

		private bool lump_Sum_PercentFieldSpecified;

		private decimal lump_Sum_AmountField;

		private bool lump_Sum_AmountFieldSpecified;

		private string lump_Sum_NotesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Lump_Sum_Percent
		{
			get
			{
				return this.lump_Sum_PercentField;
			}
			set
			{
				this.lump_Sum_PercentField = value;
				this.RaisePropertyChanged("Lump_Sum_Percent");
			}
		}

		[XmlIgnore]
		public bool Lump_Sum_PercentSpecified
		{
			get
			{
				return this.lump_Sum_PercentFieldSpecified;
			}
			set
			{
				this.lump_Sum_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Lump_Sum_PercentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Lump_Sum_Amount
		{
			get
			{
				return this.lump_Sum_AmountField;
			}
			set
			{
				this.lump_Sum_AmountField = value;
				this.RaisePropertyChanged("Lump_Sum_Amount");
			}
		}

		[XmlIgnore]
		public bool Lump_Sum_AmountSpecified
		{
			get
			{
				return this.lump_Sum_AmountFieldSpecified;
			}
			set
			{
				this.lump_Sum_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Lump_Sum_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Lump_Sum_Notes
		{
			get
			{
				return this.lump_Sum_NotesField;
			}
			set
			{
				this.lump_Sum_NotesField = value;
				this.RaisePropertyChanged("Lump_Sum_Notes");
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
