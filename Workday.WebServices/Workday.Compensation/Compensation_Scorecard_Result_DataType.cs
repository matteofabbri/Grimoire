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
	public class Compensation_Scorecard_Result_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime evaluation_DateField;

		private Default_ScorecardObjectType compensation_Scorecard_ReferenceField;

		private Scorecard_Result_DataType[] scorecard_Result_DataField;

		private Profile_Compensation_Scorecard_Result_DataType[] profile_Scorecard_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Evaluation_Date
		{
			get
			{
				return this.evaluation_DateField;
			}
			set
			{
				this.evaluation_DateField = value;
				this.RaisePropertyChanged("Evaluation_Date");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Scorecard_Result_Data", Order = 3)]
		public Scorecard_Result_DataType[] Scorecard_Result_Data
		{
			get
			{
				return this.scorecard_Result_DataField;
			}
			set
			{
				this.scorecard_Result_DataField = value;
				this.RaisePropertyChanged("Scorecard_Result_Data");
			}
		}

		[XmlElement("Profile_Scorecard_Result_Data", Order = 4)]
		public Profile_Compensation_Scorecard_Result_DataType[] Profile_Scorecard_Result_Data
		{
			get
			{
				return this.profile_Scorecard_Result_DataField;
			}
			set
			{
				this.profile_Scorecard_Result_DataField = value;
				this.RaisePropertyChanged("Profile_Scorecard_Result_Data");
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
