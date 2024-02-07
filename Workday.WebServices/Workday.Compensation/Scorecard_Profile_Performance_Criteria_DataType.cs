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
	public class Scorecard_Profile_Performance_Criteria_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType scorecard_Profile_Goal_ReferenceField;

		private string scorecard_Profile_Goal_NameField;

		private string scorecard_Profile_Goal_DescriptionField;

		private decimal scorecard_Profile_Goal_WeightField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Scorecard_Profile_Goal_Reference
		{
			get
			{
				return this.scorecard_Profile_Goal_ReferenceField;
			}
			set
			{
				this.scorecard_Profile_Goal_ReferenceField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Goal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Scorecard_Profile_Goal_Name
		{
			get
			{
				return this.scorecard_Profile_Goal_NameField;
			}
			set
			{
				this.scorecard_Profile_Goal_NameField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Goal_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Scorecard_Profile_Goal_Description
		{
			get
			{
				return this.scorecard_Profile_Goal_DescriptionField;
			}
			set
			{
				this.scorecard_Profile_Goal_DescriptionField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Goal_Description");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Scorecard_Profile_Goal_Weight
		{
			get
			{
				return this.scorecard_Profile_Goal_WeightField;
			}
			set
			{
				this.scorecard_Profile_Goal_WeightField = value;
				this.RaisePropertyChanged("Scorecard_Profile_Goal_Weight");
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
