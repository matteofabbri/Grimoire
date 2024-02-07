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
	public class Bonus_Plan_Percent_DataType : INotifyPropertyChanged
	{
		private decimal percentageField;

		private bool percentageFieldSpecified;

		private Compensation_BasisObjectType itemField;

		private Bonus_Plan_Percent_Plan_Profile_Replacement_DataType[] percent_Plan_Profile_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Percentage
		{
			get
			{
				return this.percentageField;
			}
			set
			{
				this.percentageField = value;
				this.RaisePropertyChanged("Percentage");
			}
		}

		[XmlIgnore]
		public bool PercentageSpecified
		{
			get
			{
				return this.percentageFieldSpecified;
			}
			set
			{
				this.percentageFieldSpecified = value;
				this.RaisePropertyChanged("PercentageSpecified");
			}
		}

		[XmlElement("Compensation_Basis_Reference", Order = 1)]
		public Compensation_BasisObjectType Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Percent_Plan_Profile_Replacement_Data", Order = 2)]
		public Bonus_Plan_Percent_Plan_Profile_Replacement_DataType[] Percent_Plan_Profile_Replacement_Data
		{
			get
			{
				return this.percent_Plan_Profile_Replacement_DataField;
			}
			set
			{
				this.percent_Plan_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Percent_Plan_Profile_Replacement_Data");
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
