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
	public class Goal_Targets_and_Actuals_Unit_DataType : INotifyPropertyChanged
	{
		private Goal_Target_And_Actual_Track_By__Tenanted_ObjectType goal_Unit_ReferenceField;

		private decimal target_Unit_ValueField;

		private bool target_Unit_ValueFieldSpecified;

		private decimal actual_Unit_ValueField;

		private bool actual_Unit_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goal_Target_And_Actual_Track_By__Tenanted_ObjectType Goal_Unit_Reference
		{
			get
			{
				return this.goal_Unit_ReferenceField;
			}
			set
			{
				this.goal_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Unit_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Target_Unit_Value
		{
			get
			{
				return this.target_Unit_ValueField;
			}
			set
			{
				this.target_Unit_ValueField = value;
				this.RaisePropertyChanged("Target_Unit_Value");
			}
		}

		[XmlIgnore]
		public bool Target_Unit_ValueSpecified
		{
			get
			{
				return this.target_Unit_ValueFieldSpecified;
			}
			set
			{
				this.target_Unit_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Target_Unit_ValueSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Actual_Unit_Value
		{
			get
			{
				return this.actual_Unit_ValueField;
			}
			set
			{
				this.actual_Unit_ValueField = value;
				this.RaisePropertyChanged("Actual_Unit_Value");
			}
		}

		[XmlIgnore]
		public bool Actual_Unit_ValueSpecified
		{
			get
			{
				return this.actual_Unit_ValueFieldSpecified;
			}
			set
			{
				this.actual_Unit_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Unit_ValueSpecified");
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
