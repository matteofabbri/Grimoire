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
	public class Performance_Factor_Scorecard_DataType : INotifyPropertyChanged
	{
		private Default_ScorecardObjectType scorecard_ReferenceField;

		private decimal weightField;

		private Default_ScorecardObjectType bonus_Modifier_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Default_ScorecardObjectType Scorecard_Reference
		{
			get
			{
				return this.scorecard_ReferenceField;
			}
			set
			{
				this.scorecard_ReferenceField = value;
				this.RaisePropertyChanged("Scorecard_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}

		[XmlElement(Order = 2)]
		public Default_ScorecardObjectType Bonus_Modifier_Reference
		{
			get
			{
				return this.bonus_Modifier_ReferenceField;
			}
			set
			{
				this.bonus_Modifier_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Modifier_Reference");
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
