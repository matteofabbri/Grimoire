using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goal_Targets_and_Actuals_Percent_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType goal_Target_And_Actual_Track_By_ReferenceField;

		private decimal target_PercentField;

		private bool target_PercentFieldSpecified;

		private decimal actual_PercentField;

		private bool actual_PercentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Goal_Target_And_Actual_Track_By_Reference
		{
			get
			{
				return this.goal_Target_And_Actual_Track_By_ReferenceField;
			}
			set
			{
				this.goal_Target_And_Actual_Track_By_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Target_And_Actual_Track_By_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Target_Percent
		{
			get
			{
				return this.target_PercentField;
			}
			set
			{
				this.target_PercentField = value;
				this.RaisePropertyChanged("Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Target_PercentSpecified
		{
			get
			{
				return this.target_PercentFieldSpecified;
			}
			set
			{
				this.target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Actual_Percent
		{
			get
			{
				return this.actual_PercentField;
			}
			set
			{
				this.actual_PercentField = value;
				this.RaisePropertyChanged("Actual_Percent");
			}
		}

		[XmlIgnore]
		public bool Actual_PercentSpecified
		{
			get
			{
				return this.actual_PercentFieldSpecified;
			}
			set
			{
				this.actual_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Actual_PercentSpecified");
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
