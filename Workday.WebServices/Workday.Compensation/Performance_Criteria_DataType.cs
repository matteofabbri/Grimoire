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
	public class Performance_Criteria_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType goal_ReferenceField;

		private string goal_NameField;

		private string goal_DescriptionField;

		private decimal goal_WeightField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Goal_Reference
		{
			get
			{
				return this.goal_ReferenceField;
			}
			set
			{
				this.goal_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Goal_Name
		{
			get
			{
				return this.goal_NameField;
			}
			set
			{
				this.goal_NameField = value;
				this.RaisePropertyChanged("Goal_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Goal_Description
		{
			get
			{
				return this.goal_DescriptionField;
			}
			set
			{
				this.goal_DescriptionField = value;
				this.RaisePropertyChanged("Goal_Description");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Goal_Weight
		{
			get
			{
				return this.goal_WeightField;
			}
			set
			{
				this.goal_WeightField = value;
				this.RaisePropertyChanged("Goal_Weight");
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
