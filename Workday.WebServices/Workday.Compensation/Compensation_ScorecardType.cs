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
	public class Compensation_ScorecardType : INotifyPropertyChanged
	{
		private Default_ScorecardObjectType compensation_Scorecard_ReferenceField;

		private Compensation_Scorecard_DataType[] compensation_Scorecard_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Default_ScorecardObjectType Compensation_Scorecard_Reference
		{
			get
			{
				return this.compensation_Scorecard_ReferenceField;
			}
			set
			{
				this.compensation_Scorecard_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Scorecard_Reference");
			}
		}

		[XmlElement("Compensation_Scorecard_Data", Order = 1)]
		public Compensation_Scorecard_DataType[] Compensation_Scorecard_Data
		{
			get
			{
				return this.compensation_Scorecard_DataField;
			}
			set
			{
				this.compensation_Scorecard_DataField = value;
				this.RaisePropertyChanged("Compensation_Scorecard_Data");
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
